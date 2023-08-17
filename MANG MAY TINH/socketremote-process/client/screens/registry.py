from PyQt6.QtWidgets import (
    QWidget,
    QPushButton,
    QLineEdit,
    QTextEdit,
    QComboBox,
    QLabel,
    QVBoxLayout,
    QHBoxLayout,
    QFileDialog,
    QMessageBox,
)

import ctypes
import re
import io
from configparser import ConfigParser
import pandas as pd


class Registry(QWidget):
    def __init__(self, socket):
        super().__init__()
        self.socket = socket
        self.data_of_log = []

        self.initUI()

    def initUI(self):

        user32 = ctypes.windll.user32

        desktop_width = user32.GetSystemMetrics(0)
        desktop_height = user32.GetSystemMetrics(1)

        width = int(desktop_width * 0.406)
        height = int(desktop_height * 0.167)

        self.resize(width, height)

        vbox1 = QVBoxLayout()

        hbox1 = QHBoxLayout()

        self.path_edit = QLineEdit()
        self.path_edit.setReadOnly(True)

        browser_button = QPushButton('Browser...')
        browser_button.clicked.connect(self.open_reg)

        hbox1.addWidget(self.path_edit)
        hbox1.addWidget(browser_button)


        vbox1.addLayout(hbox1)
        
        hbox2 = QHBoxLayout()

        self.file_content = QTextEdit()
        self.file_content.setReadOnly(True)

        send_content_button = QPushButton('Gởi nội dung')
        send_content_button.clicked.connect(self.send_file)

        hbox2.addWidget(self.file_content)
        hbox2.addWidget(send_content_button)

        vbox1.addLayout(hbox2)

        vbox1.addStretch()

        label = QLabel("Sửa giá trị trực tiếp")

        self.type = QComboBox()
        self.type.addItem('Get value', 'Get value')
        self.type.addItem('Set value', 'Set value')
        self.type.addItem('Delete value', 'Delete value')
        self.type.addItem('Create key', 'Create key')
        self.type.addItem('Delete key', 'Delete key')
        self.type.currentTextChanged.connect(
            self.typeGroupTextChanged
        )

        self.key_edit = QLineEdit()
        self.key_edit.setPlaceholderText("Đường dẫn")

        hbox3 = QHBoxLayout()

        self.name_edit = QLineEdit()
        self.name_edit.setPlaceholderText("Name")
        self.value_edit = QLineEdit()
        self.value_edit.hide()
        self.value_edit.setPlaceholderText("Value")
        self.value_type = QComboBox()
        self.value_type.hide()
        self.value_type.addItem('String', 'String')
        self.value_type.addItem('Binary', 'Binary')
        self.value_type.addItem('DWORD', 'DWORD')
        self.value_type.addItem('QWORD', 'QWORD')
        self.value_type.addItem('Multi-String', 'Multi-String')
        self.value_type.addItem('Expandable String', 'Expandable String')

        hbox3.addWidget(self.name_edit)
        hbox3.addWidget(self.value_edit)
        hbox3.addWidget(self.value_type)

        self.notification = QTextEdit()
        self.notification.setReadOnly(True)

        hbox4 = QHBoxLayout()
        
        send_button = QPushButton('Gởi')
        send_button.clicked.connect(self.send)
        delete_button = QPushButton('Xóa')

        hbox4.addStretch()
        hbox4.addWidget(send_button)
        hbox4.addWidget(delete_button)
        hbox4.addStretch()

        vbox1.addWidget(label)
        vbox1.addWidget(self.type)
        vbox1.addWidget(self.key_edit)
        vbox1.addLayout(hbox3)
        vbox1.addWidget(self.notification)
        vbox1.addLayout(hbox4)

        self.setLayout(vbox1)

        self.show()

    def open_reg(self):
        file_name, _ = QFileDialog.getOpenFileName(
            self,
            "Open",
            '.',
            "(*.reg)"
        )

        if file_name:
            self.path_edit.setText(file_name)

            with open(file_name, "r+", encoding="utf-16") as f:
                contents = f.readlines()
                
                text = ''
                for content in contents:
                    text += content

                self.file_content.setText(text)

            with io.open(file_name, encoding='utf-16') as f:
                data = f.read()

                # get rid of non-section strings in the beginning of .reg file
                data = re.sub(r'^[^\[]*\n', '', data, flags=re.S)
                cfg = ConfigParser(strict=False)
                # dirty hack for "disabling" case-insensitive keys in "configparser"
                cfg.optionxform=str
                cfg.read_string(data)
                data = []
                # iterate over sections and keys and generate `data` for pandas.DataFrame
                for s in cfg.sections():
                    if not cfg[s]:
                        data.append([s, None, None, None])
                    for key in cfg[s]:
                        tp = val = None
                        if cfg[s][key]:
                            # take care of value type
                            if ':' in cfg[s][key]:
                                tp, val = cfg[s][key].split(':')
                            else:
                                val = cfg[s][key].replace('"', '').replace(r'\\\n', '')
                        data.append([s, key.replace('"', ''), tp, val])
                df = pd.DataFrame(data, columns=['Path','Key','Type','Value'])
                # make `hex` values "one-line"
                df.loc[df.Type.notnull() & df.Type.str.contains(r'^hex'), 'Value'] = \
                    df.loc[df.Type.notnull() & df.Type.str.contains(r'^hex'), 'Value'].str.replace(r'\\\n','')

                self.data_of_log = []
                index = df.index
                number_of_rows = len(index)

                for i in range(0, number_of_rows):
                    self.data_of_log.append(
                        {
                            "Link": df.loc[i]["Path"],
                            "Name": df.loc[i]["Key"],
                            "Value": df.loc[i]["Value"],
                            "Value-Type": df.loc[i]["Type"]
                        }
                    )


    def send_file(self):
        for data in self.data_of_log:
            link = data['Link']
            name = data['Name']
            value = data['Value']

            if data['Value-Type'] is None:
                value_type = 'String'
            elif data['Value-Type'] == 'hex':
                value_type = 'Binary'
            elif data['Value-Type'] == 'dword':
                value_type = 'DWORD'
            elif data['Value-Type'] == 'hex(b)':
                value_type = 'QWORD'
            elif data['Value-Type'] == 'hex(7)':
                value_type = 'Multi-String'
            elif data['Value-Type'] == 'hex(2)':
                value_type = 'Expandable String'

            self.socket.sendall(bytes(f'send_file`{link}`{name}`{value}`{value_type}', 'utf-8'))
            
            result = self.socket.recv(2048).decode("utf-8")

            if result == '1':
                continue
            else:
                msg = QMessageBox()
                msg.setWindowTitle("SEND FILE")
                msg.setText("Gửi file thất bại")
                msg.exec()
                return

        msg = QMessageBox()
        msg.setWindowTitle("SEND FILE")
        msg.setText("Gửi file thành công")
        msg.exec()
    
    def send(self):

        if self.type.currentText() == 'Get value':
            link = self.key_edit.text()
            name = self.name_edit.text()

            self.socket.sendall(bytes(f'get_value`{link}`{name}', 'utf-8'))
            data = self.socket.recv(2048).decode("utf-8")

        elif self.type.currentText() == 'Set value':
            link = self.key_edit.text()
            name = self.name_edit.text()
            value = self.value_edit.text()
            value_type = self.value_type.currentText()

            self.socket.sendall(bytes(f'set_value`{link}`{name}`{value}`{value_type}', 'utf-8'))
            data = self.socket.recv(2048).decode("utf-8")

        elif self.type.currentText() == 'Delete value':
            link = self.key_edit.text()
            name = self.name_edit.text()

            self.socket.sendall(bytes(f'delete_value`{link}`{name}', 'utf-8'))
            data = self.socket.recv(2048).decode("utf-8")

        elif self.type.currentText() == 'Create key':
            link = self.key_edit.text()

            self.socket.sendall(bytes(f'create_key`{link}', 'utf-8'))
            data = self.socket.recv(2048).decode("utf-8")

        elif self.type.currentText() == 'Delete key':
            link = self.key_edit.text()

            self.socket.sendall(bytes(f'delete_key`{link}', 'utf-8'))
            data = self.socket.recv(2048).decode("utf-8")

        self.notification.setPlainText(data + "\n" + self.notification.toPlainText())

    def typeGroupTextChanged(self, text):
        if text == 'Get value' or text == 'Delete value':
            self.name_edit.show()
            self.value_edit.hide()
            self.value_type.hide()
        elif text == 'Set value':
            self.name_edit.show()
            self.value_edit.show()
            self.value_type.show()
        elif text == 'Create key' or text == 'Delete key':
            self.name_edit.hide()
            self.value_edit.hide()
            self.value_type.hide()