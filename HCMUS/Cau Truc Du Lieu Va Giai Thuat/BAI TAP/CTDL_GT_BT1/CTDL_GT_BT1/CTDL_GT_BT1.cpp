// CTDL_GT_BT1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
using namespace std;
struct NHANVIEN 
{
    string tenNV;
    int namSinh;
    float heSoluong;
    int luongCoban;
};

struct NODE
{
    NODE* pNext;
    NHANVIEN data;
};
NODE* pHead = NULL;
void NHAP()
{
    
    NODE* p = new NODE;
    p->pNext = pHead;
    pHead = p;
    cout << "Nhap du lieu: \n";
    cout << "Ten nhan vien: ";
    cin >> p->data.tenNV;
    cout << "Nam sinh cua nhan vien: ";
    cin >> p->data.namSinh;
    cout << "He so luong cua nhan vien: ";
    cin >> p->data.heSoluong;
    cout << "Luong co ban cua nhan vien: ";
    cin >> p->data.luongCoban;
    
    
}
//int TINHLUONG(NODE* p)
//{
//    
//
//
//    int luong; 
//  luong = p->data.luongCoban * p->data.heSoluong;
//  return luong;
//    }


void XUATDULIEU()
{
    
    NODE* p = pHead;
    
    while (p != NULL)
    {
      
    
        int luong = p->data.luongCoban * p->data.heSoluong;
        
        if (p->data.namSinh == 2000 && luong == 1000)
        {
            cout << "Nhung nhan vien co nam sinh 2000 va luong 10.000.000 bao gom: " << luong;

        }
        p = p->pNext;
    }
}



void main()
{
    
    cout << "BAI TAP 1:\n \n";
    NHAP();
    XUATDULIEU();
    
    
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
