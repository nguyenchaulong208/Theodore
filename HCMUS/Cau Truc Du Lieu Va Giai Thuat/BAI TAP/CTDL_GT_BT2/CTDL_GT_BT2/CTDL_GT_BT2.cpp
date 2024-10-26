// CTDL_GT_BT2.cpp : This file contains the 'main' function. Program execution begins and ends there.
// ---------------------------------------
// Lab Danh sach lien ket don
//HO VA TEN: NGUYEN CHAU LONG
//MSSV: 22880089
#include <iostream>
#include <string>
using namespace std;
struct Node
{
    int data;
    Node* pNext;
};
//Yeu cau 1: Khoi tao 1 Node
Node *CreateNode(int k)
{
    Node* p = new Node();
    p->data = k;
    p->pNext = NULL;
    return p;
}
// Yeu cau 2: Them so nguyen k vao dau DSLK don
void InsertFirst(Node *&pHead, int k)
{
    Node* p = CreateNode(k);
    if (pHead == NULL)
    {
        pHead = p;
    }
    else
    {
        p->pNext = pHead;
        pHead = p;
    }
    

}

//Yeu cau 3: Them so nguyen k vao cuoi DSLK don
Node* findLast(Node* pHead)
{
    Node* p = pHead;
    while (p->pNext !=NULL)
    {
        p = p->pNext;
    }
    return p;
}
void InsertLast(Node*& pHead, int k)
{
    Node* p = CreateNode(k);
    Node* pTail;
    if (pHead == NULL)
    {
        pHead = p;

    }
    else
    {
        pTail = findLast(pHead);
        pTail->pNext = p;
    }

}

//Yeu cau 4: in toan bo DSLK don
void printNode(Node* pHead)
{
    Node* p = pHead;
    while (p != NULL)
    {
        cout << p->data <<"\n";
        p = p->pNext;
    }
}

//Yeu cau 5: Tim kiem so nguyen k trong DSLK don. Neu co tra ve True, nguoc lai tra ve False
bool SearchList(Node* pHead, int k)
{
    Node* p = pHead;
    while (p != NULL)
    {
        if (p->data == k)
        {
            return true;
        }
        p = p->pNext;
    }
    return false;
    
    
       
}

//Yeu cau 6: Hoan thanh ham main() theo yeu cau
int main()
{
    int k;
    int key;
    int end;
    int Search;
    string result;
    
    Node* pHead = NULL;

    cout << "- Nhap so [1] de them Node vao dau danh sach: \n";
    cout << "- Nhap so [2] de them Node vao cuoi danh sach: \n";
    cout << "- Nhap [-1] de ngung thao tac nhap Node: \n";
    cout << "---------------\n";
    cin >> key;
    if (key == 1) 
    {
        do
        {
            cout << "Nhap gia tri cua Node: ";
            cin >> k;

            if (k != -1)
            {
                InsertFirst(pHead, k);
            }
        } while (k != -1);
    }
    if (key == 2)
    {
        do
        {
            cout << "Nhap gia tri cua Node: ";
            cin >> k;

            if (k != -1)
            {
                InsertLast(pHead, k);
            }
        } while (k != -1);
    }

    //In toan bo so nguyen trong DSLK din
    cout << "\n Danh sach lien ket la: \n";
    
        printNode(pHead);
    
    //Nhap vao so nguyen k va kiem tra k co trong DSLK don khong
    cout << "\n Nhap vao gia tri can tiem kiem: ";
    cin >> Search;
    if (SearchList(pHead, Search))
    {
        cout << "True\n";
    }
    else
    {
        cout << "False\n";
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
