#Topic 6: Data Structure Exercise
'''
Exercise 2: Remove and add item in a list
Write a program to remove the item present at index 4 and add it to the 2nd position and at the end of the list.
'''

def removeItem(listInput):
    listInput.pop(4)
    print("Ket qua khi remove tai index 4: ", listInput)
    listInput.insert(2, listInput[4])
    print("Ket qua khi them vao vi tri thu 2: ", listInput)
    listInput.append(listInput[4])
    print("Ket qua khi them vi tri cuoi: ", listInput)

removeItem([54, 44, 27, 79, 91, 41])
#List tu nhap
listInput = []
n = int(input("Nhap so phan tu cua list: "))
if n < 5:
    print("So phan tu cua list phai lon hon 6: ")
    n = int(input("Nhap so phan tu cua list: "))
    for i in range(n):
        numInput = int(input("Nhap so: "))
        listInput.append(numInput)

removeItem(listInput)