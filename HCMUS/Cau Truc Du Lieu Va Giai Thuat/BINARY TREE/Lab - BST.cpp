/*Viết chương trình C++ cài đặt cấu trúc dữ liệu cây nhị phân tìm kiếm
  Họ và tên SV:
  MSSV:  
*/
#include <iostream>

using namespace std;

struct NODE {
    int key;
    NODE *pLeft;
    NODE *pRight;
};

/* Yêu cầu 1. Khởi tạo một NODE từ một số nguyên k chuẩn bị thêm vào cây nhị phân tìm kiếm*/
NODE* createNode(int k) {
    NODE* p = new NODE();

    /*Sinh viên tự hoàn thành đoạn code này*/
	...

    return p;
}

/* Yêu cầu 2. Viết hàm thêm số nguyên k vào vào cây nhị phân tìm kiếm */
void insertNode(NODE* &pRoot, int k) {
    Node* p = createNode(k);	//Tạo NODE p từ số nguyên k
	
	/*Sinh viên tự hoàn thành đoạn code này*/
	...
}

/* Yêu cầu 3. Viết hàm duyệt trước NLR */
void NLR(NODE* pRoot) {
    /*Sinh viên tự hoàn thành đoạn code này*/
	...
}

/* Yêu cầu 4. Viết hàm duyệt giữa LNR */
void LNR(NODE* pRoot) {
    /*Sinh viên tự hoàn thành đoạn code này*/
	...
}

/* Yêu cầu 5. Viết hàm duyệt sau LRN */
void LRN(NODE* pRoot) {
    /*Sinh viên tự hoàn thành đoạn code này*/
	...
}

/* Yêu cầu 6. Viết hàm tìm kiếm số nguyên k trong cây nhị phân tìm kiếm. 
Nếu có trả về true. Ngược lại trả về false. */
bool searchData(NODE *pRoot, int k) {
    bool result = false;

	/*Sinh viên tự hoàn thành đoạn code này*/
	...

	return result;
}

/* Yêu cầu 6. Hoàn thành hàm main() theo yêu cầu */
int main() {
    Node* pRoot = NULL;
	int k;
	do
	{
		cout << "Nhap gia tri cua Node (Nhap -1 de ngung thao tac): ";
		cin >> k;		
		if (k != -1)
		{
			/*Thêm k vào cây nhị phân tìm kiếm - Sinh viên tự hoàn thành đoạn code này*/
			...	
		}		
	} while (input != -1);

    /*In toàn bộ số nguyên trong cây theo phép duyệt trước - Sinh viên tự hoàn thành đoạn code này*/
    cout << "NLR: ";
	...

    /*In toàn bộ số nguyên trong cây theo phép duyệt giữa - Sinh viên tự hoàn thành đoạn code này*/
    cout << "LNR: ";
	...

    /*In toàn bộ số nguyên trong cây theo phép duyệt sau - Sinh viên tự hoàn thành đoạn code này*/
    cout << "LRN: ";
	...

    /*Nhập vào số nguyên k và kiểm tra k có trong cây hay không - Sinh viên tự hoàn thành đoạn code này*/	
	...

    return 0;
}

