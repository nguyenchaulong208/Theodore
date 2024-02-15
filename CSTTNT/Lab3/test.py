from math import inf as infinity
from random import choice
import platform
import time
import os

HUMAN = -1
COMP = +1
#Cài đặt bàn cờ có kích thước là 4x4
board = [
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0],
    [0, 0, 0, 0]
]

#Ham danh gia: Nếu máy thắng thì score trả về +1, người chơi thắng thì score trả về 2, hoà thì score = 0
def evaluate(state):
    if wins(state, COMP):
        score = +1
    elif wins(state, HUMAN):
        score = -1
    else:
        score = 0

    return score

#Hàm định nghĩa các ô [XXX] hoặc [OOO] liên tiếp là chiến thắng
def wins(state, player):
    win_state = [
        # Các dòng [XXX] hoặc [OOO] liên tiếp
        [state[0][0], state[0][1], state[0][2]],
        [state[1][0], state[1][1], state[1][2]],
        [state[2][0], state[2][1], state[2][2]],
        [state[3][0], state[3][1], state[3][2]],
        [state[0][1], state[0][2], state[0][3]],
        [state[1][1], state[1][2], state[1][3]],
        [state[2][1], state[2][2], state[2][3]],
        [state[3][1], state[3][2], state[3][3]],

        # Các cột [XXX] hoặc [OOO] liên tiếp
        [state[0][0], state[1][0], state[2][0]],
        [state[0][1], state[1][1], state[2][1]],
        [state[0][2], state[1][2], state[2][2]],
        [state[0][3], state[1][3], state[2][3]],
        [state[1][0], state[2][0], state[3][0]],
        [state[1][1], state[2][1], state[3][1]],
        [state[1][2], state[2][2], state[3][2]],
        [state[1][3], state[2][3], state[3][3]],

        # Các đường chéo [XXX] hoặc [OOO] liên tiếp
        [state[0][0], state[1][1], state[2][2]],
        [state[1][1], state[2][2], state[3][3]],
        [state[0][3], state[1][2], state[2][1]],
        [state[1][2], state[2][1], state[3][0]],
        [state[1][0], state[2][1], state[3][2]],


    ]

    #Nếu player/AI đánh liên tiếp 3 ô [XXX] hoặc [OOO] sẻ chiến thắng (return True)
    if [player, player, player] in win_state:
        return True
    else:
        return False

#Ham trả về kết quả là AI thắng hay người chơi thắng
def game_over(state):
    return wins(state, HUMAN) or wins(state, COMP)

#Hàm kiểm tra các ô trống trên bàn cờ. Tạo 1 mảng cell để lưu trữ các vị trí ô trống,
#nếu ô nào chưa được người chơi hoặc AI đánh thì sẽ thêm vào cell để sử dụng cho các nước đi sau
def empty_cells(state):
    cells = []
    for x, row in enumerate(state):
        for y, cell in enumerate(row):
            if cell == 0:
                cells.append([x, y]) #Lưu dưới dạng toạ độ
    return cells

#Hàm kiểm tra các nước đi có sẵn từ empty_cells, sử dụng mảng cell của hàm empty_cells để kiểm tra
def valid_move(x, y):
    if [x, y] in empty_cells(board):
        return True
    else:
        return False

#Hàm đánh dấu các nước đi của người chơi/AI
def set_move(x, y, player):
    if valid_move(x, y):
        board[x][y] = player
        return True
    else:
        return False

#Ham Minimax
def minimax(state, depth, player, alpha, beta):
   #Khởi tạo giá trị của COMP và HUMAN, nếu player là máy thì best sẽ khởi tạo là [-1, -1, -infinity], nếu là máy thì sẽ khởi tạo là [-1, -1, +infinity]
    if player == COMP:
        best = [-1, -1, -infinity] 
    else:
        best = [-1, -1, +infinity]
#Nếu độ sâu (depth) là 0 hoặc kết thúc trò chơi thì hàm evaluate sẽ đánh giá trạng thái hiện tại và điểm số tương ứng với trạng thái đó.
    if depth == 0 or game_over(state):
        score = evaluate(state)
        return [-1, -1, score]
#Duyệt các ô trống trên bàng cờ và đánh dấu các nước đi của player
    for cell in empty_cells(state):
        x, y = cell[0], cell[1]
        state[x][y] = player
   #Gọi đệ quy để tìm kiếm các nước đi tối ưu
        score = minimax(state, depth - 1, -player, alpha, beta)
        state[x][y] = 0 #Đặt lại vị trí đó là ô trống
        score[0], score[1] = x, y #Cập nhật tọa độ của nước đi tốt nhất hiện tại

        if player == COMP: #Kiểm tra lượt đi là người hay máy, nếu là máy thì cập nhật nước đi tối ưu nhất
            if score[2] > best[2]:
                best = score
    #Cập nhật giá trị alpha, là giá trị tốt nhất mà máy có thể đảm bảo
            alpha = max(alpha, best[2])
        else:
            if score[2] < best[2]:
                best = score
    #Cập nhật giá trị beta, là giá trị tốt nhất người chơi) có thể đảm bảo.
            beta = min(beta, best[2])
    #Nếu alpha >= beta thi thoát khỏi vòng lặp, điều này tương với việc cắt tỉa cây để giảm bớt các giá trị không còn phù hợp để tối ưu hoá code
        if beta <= alpha:
            break
    return best
    

#Xoá màn hình Console
def clean():
    os.system('cls' if os.name == 'nt' else 'clear')
#In bàn cờ ra màn hình console
def render(state, c_choice, h_choice):
    chars = {
        -1: h_choice,
        +1: c_choice,
        0: ' '
    }
    str_line = '-----------------'
    print('\n' + str_line)
    for row in state:
        for cell in row:
            symbol = chars[cell]
            print(f'| {symbol} ', end='')
        print('|\n' + str_line)

#Ham may danh
def ai_turn(c_choice, h_choice):
    depth = len(empty_cells(board)) #Tính độ sâu tối đa mà minmax có thể tìm kiếm được
    if depth == 0 or game_over(board):
        return
#Xoá màn hình và in ra lượt đi của máy tính
    clean()  
    print('Computer turn [%s]' % c_choice)
    render(board, c_choice, h_choice)
#Nếu bàn cờ còn 16 ô trống thì máy tính sẽ chọn ngẫu nhiên 1 ô trống để đi,
#Nếu bàn cờ đã có các ô được lựa chọn thì máy tính sẽ dùng thuật toán minimax để tìm đường đi tối ưu nhất
    if depth == 16:
        x = choice([0, 1, 2, 3])
        y = choice([0, 1, 2, 3])
    else:
        move = minimax(board, depth, COMP, -infinity, infinity)
        x, y = move[0], move[1]

    set_move(x, y, COMP) #Đánh dầu nước đi của máy trên bàn cờ
    time.sleep(1)

#Hàm đánh dấu người chơi đánh
def human_turn(c_choice, h_choice):
    depth = len(empty_cells(board))
    if depth == 0 or game_over(board):
        return

    move = -1
    #Khởi tạo 1 dic để người chơi nhập vào vị trí của nước đi
    moves = {
        1: [0, 0], 2: [0, 1], 3: [0, 2], 4: [0, 3],
        5: [1, 0], 6: [1, 1], 7: [1, 2], 8: [1, 3],
        9: [2, 0], 10: [2, 1], 11: [2, 2], 12: [2, 3],
        13: [3, 0], 14: [3, 1], 15: [3, 2], 16: [3, 3]
    }

    clean()
    print(f'Human turn [%s]' % h_choice)
    render(board, c_choice, h_choice)
#Kiếm tra các ô trên bàn cờ 4x4 đã được đánh dấu chưa
    while move < 1 or move > 16:
        try:
            move = int(input('Use numpad (1..16): '))
            if move < 1 or move > 16:
                print('Bad move')
            else:
                coord = moves[move]
                if set_move(coord[0], coord[1], HUMAN):
                    time.sleep(1)
                else:
                    print("Invalid move. Try again.")
                    move = -1
        except (EOFError, KeyboardInterrupt):
            print('Bye')
            exit()
        except (KeyError, ValueError):
            print('Bad choice')

#Ham chinh              
def main():
    
    clean()
    h_choice = ''  
    c_choice = ''  
    first = ''  
#thao tác chơi cờ và các thông báo
    while h_choice != 'O' and h_choice != 'X':
        try:
            h_choice = input('Choose X or O\nChosen: ').upper()
        except (EOFError, KeyboardInterrupt):
            print('Bye')
            exit()
        except (KeyError, ValueError):
            print('Bad choice')

    if h_choice == 'X':
        c_choice = 'O'
    else:
        c_choice = 'X'

    clean()
    while first != 'Y' and first != 'N':
        try:
            first = input('First to start?[y/n]: ').upper()
        except (EOFError, KeyboardInterrupt):
            print('Bye')
            exit()
        except (KeyError, ValueError):
            print('Bad choice')

    while len(empty_cells(board)) > 0 and not game_over(board):
        if first == 'N':
            ai_turn(c_choice, h_choice)
            first = ''

        human_turn(c_choice, h_choice)
        ai_turn(c_choice, h_choice)
    

    if wins(board, HUMAN):
        clean()
        print(f'Human turn [%s]' % h_choice)
        render(board, c_choice, h_choice)
        print('YOU WIN!')
    elif wins(board, COMP):
        clean()
        print(f'Computer turn [%s]' % c_choice)
        render(board, c_choice, h_choice)
        print('YOU LOSE!')
    else:
        clean()
        render(board, c_choice, h_choice)
        print('DRAW!')

    exit()


if __name__ == '__main__':
    main()
    
    
