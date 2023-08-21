#include <iostream>
#include <conio.h>
#include <stdio.h>

using namespace std;

struct NODE {
	int key;
	NODE* pLeft;
	NODE* pRight;
};

/* Yêu cầu 1. Khởi tạo một NODE từ một số nguyên k chuẩn bị thêm vào cây nhị phân tìm kiếm*/
NODE* createNode(int k) {
	NODE* p = new NODE();
	p->key = k;
	p->pLeft = NULL;
	p->pRight = NULL;
	return p;
}

/* Yêu cầu 2. Viết hàm thêm số nguyên k vào vào cây nhị phân tìm kiếm */
void insertNode(NODE*& pRoot, int k) {
	if (pRoot == NULL) {
		NODE* pNew = createNode(k);
		pRoot = pNew;
		return;
	}

	if (k == pRoot->key) {
		cout << "Gia tri da ton tai";
		return;
	}

	if (k < pRoot->key) {
		insertNode(pRoot->pLeft, k);
	}
	else {
		insertNode(pRoot->pRight, k);
	}
}

/* Yêu cầu 3. Viết hàm duyệt trước NLR */
void NLR(NODE* pRoot) {
	if (pRoot == NULL) return;

	cout << " " << pRoot->key;
	NLR(pRoot->pLeft);
	NLR(pRoot->pRight);
}

/* Yêu cầu 4. Viết hàm duyệt giữa LNR */
void LNR(NODE* pRoot) {
	if (pRoot == NULL) return;

	LNR(pRoot->pLeft);
	cout << " " << pRoot->key;
	LNR(pRoot->pRight);
}

/* Yêu cầu 5. Viết hàm duyệt sau LRN */
void LRN(NODE* pRoot) {
	if (pRoot == NULL) return;

	LRN(pRoot->pLeft);
	LRN(pRoot->pRight);
	cout << " " << pRoot->key;
}

/* Yêu cầu 6. Viết hàm tìm kiếm số nguyên k trong cây nhị phân tìm kiếm.
Nếu có trả về true. Ngược lại trả về false. */
bool searchData(NODE* pRoot, int k) {
	if (pRoot == NULL)
		return false;

	if (pRoot->key == k) {
		return true;
	}

	if (pRoot->key < k) {
		return searchData(pRoot->pRight, k);
	}
	else {
		return searchData(pRoot->pLeft, k);
	}

	return false;
}

void PressAKeyToContinue() {
	printf("\nPress a key to continue...");
	int c = _getch();

	if (c == 0 || c == 224)
		c = _getch();
}

/* Yêu cầu 6. Hoàn thành hàm main() theo yêu cầu */

int main() {
	NODE* pRoot = NULL;
	int input = 0;

	// nhap gia tri cho cay
	do
	{
		cout << "Nhap gia tri cua Node (Nhap -1 de ngung thao tac): ";
		cin >> input;

		if (input != -1)
		{
			insertNode(pRoot, input);
		}
	} while (input != -1);

	/*In toàn bộ số nguyên trong cây theo phép duyệt trước - Sinh viên tự hoàn thành đoạn code này*/
	cout << "\nNode - Left - Right:";
	NLR(pRoot);

	/*In toàn bộ số nguyên trong cây theo phép duyệt giữa - Sinh viên tự hoàn thành đoạn code này*/
	cout << "\nLeft - Node - Right:";
	LNR(pRoot);

	/*In toàn bộ số nguyên trong cây theo phép duyệt sau - Sinh viên tự hoàn thành đoạn code này*/
	cout << "\nLeft - Right - Node:";
	LRN(pRoot);

	/*Nhập vào số nguyên k và kiểm tra k có trong cây hay không - Sinh viên tự hoàn thành đoạn code này*/
	int k = 0;
	cout << "\nNhap gia tri k can tim: ";
	cin >> k;

	if (searchData(pRoot, k))
		cout << "\n" << k << " co trong cay.";
	else
		cout << "\n" << k << " khong co trong cay.";

	PressAKeyToContinue();
}