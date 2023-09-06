/*Viết chương trình C++ cài đặt cấu trúc dữ liệu cây nhị phân tìm kiếm
  Họ và tên SV: Nguyễn Châu Long
  MSSV: 22880089
*/

#include <iostream>

using namespace std;
struct NODE {
    int key;
    NODE* pLeft;
    NODE* pRight;
};
/* Yêu cầu 1. Khởi tạo một NODE từ một số nguyên k chuẩn bị thêm vào cây nhị phân tìm kiếm*/
NODE* createNode(int k) {
    NODE* p = new NODE();

    /*Sinh viên tự hoàn thành đoạn code này*/
    p->key = k;
    p->pLeft = NULL;
    p->pRight = NULL;

        return p;
}
/* Yêu cầu 2. Viết hàm thêm số nguyên k vào vào cây nhị phân tìm kiếm */
void insertNode(NODE*& pRoot, int k) {
    NODE* p = createNode(k);	//Tạo NODE p từ số nguyên k

    /*Sinh viên tự hoàn thành đoạn code này*/
    if (pRoot == NULL)
    {
        pRoot = p;
    }
    else if (k < pRoot -> key)
    {
        insertNode(pRoot->pLeft, k);
    }
    else if (k > pRoot->key)
    {
        insertNode(pRoot->pRight, k);
    }
    
}
/* Yêu cầu 3. Viết hàm duyệt trước NLR */
void NLR(NODE* pRoot) 
{
    /*Sinh viên tự hoàn thành đoạn code này*/
    if (pRoot == NULL)
    {
        return;
    }
    cout << (pRoot->key)<< " ";
    NLR(pRoot->pLeft);
    NLR(pRoot->pRight);
   
}
/*Yêu cầu 4. Viết hàm duyệt giữa LNR */
void LNR(NODE * pRoot) 
{
    /*Sinh viên tự hoàn thành đoạn code này*/
    if (pRoot == NULL)
    {
        return;
    }
    LNR(pRoot->pLeft);
    cout << (pRoot->key) <<" ";
    LNR(pRoot->pRight);
    
}

/* Yêu cầu 5. Viết hàm duyệt sau LRN */
void LRN(NODE* pRoot) 
{
    /*Sinh viên tự hoàn thành đoạn code này*/
    if (pRoot == NULL)
    {
        return;
    }
    LRN(pRoot->pLeft);
    LRN(pRoot->pRight);
    cout <<(pRoot->key) << " ";
}

/* Yêu cầu 6. Viết hàm tìm kiếm số nguyên k trong cây nhị phân tìm kiếm.
Nếu có trả về true. Ngược lại trả về false. */
bool searchData(NODE* pRoot, int k) 
{
    bool result = false;

    /*Sinh viên tự hoàn thành đoạn code này*/
    if (pRoot == NULL) 
    {
        return NULL;
    }
    if (pRoot->key == k)
    {
        return true;
    }
    else if (k < pRoot->key)
    {
        return searchData(pRoot->pLeft,k);

    }
    else if (k > pRoot->key)
    {
        return searchData(pRoot->pRight, k);

    }   

        return result;
}

/* Yêu cầu 6. Hoàn thành hàm main() theo yêu cầu */

int main()
{
    NODE* pRoot = NULL;
    int k;
    int input;
    int keySearch;

    do
    {
        cout << "Nhap gia tri cua Node (Nhap -1 de ngung thao tac): ";
        cin >> k;
        input = k;
        if (k != -1)
        {
            /*Thêm k vào cây nhị phân tìm kiếm - Sinh viên tự hoàn thành đoạn code này*/
            insertNode(pRoot, k);
            
        }
        
    } while (input != -1);

    /*In toàn bộ số nguyên trong cây theo phép duyệt trước - Sinh viên tự hoàn thành đoạn code này*/
        cout << "\nNLR: ";
        NLR(pRoot);

        /*In toàn bộ số nguyên trong cây theo phép duyệt giữa - Sinh viên tự hoàn thành đoạn code này*/
        cout << "\nLNR: ";
        LNR(pRoot);

        /*In toàn bộ số nguyên trong cây theo phép duyệt sau - Sinh viên tự hoàn thành đoạn code này*/
        cout << "\nLRN: ";
        LRN(pRoot);

        /*Nhập vào số nguyên k và kiểm tra k có trong cây hay không - Sinh viên tự hoàn thành đoạn code này*/
        cout << "\n \nNhap vao gia tri can tim kiem trong Node: ";
        cin >> keySearch;
        if (searchData(pRoot, keySearch))
        {
            cout << "\nKet qua tim kiem: True\n";
        }
        else
        {
            cout << "\nKet qua tim kiem: False\n";
        }
        return 0;

      
    
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
