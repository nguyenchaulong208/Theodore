#Topic 7: List Exercise
'''
Exercise 5: Iterate both lists simultaneously
Given a two Python list. Write a program to iterate both lists simultaneously and display items from list1 in original order and items from list2 in reverse order.
'''

#list 1
listInput1 = []
n = int(input("Nhap so phan tu cua list 1: "))
for i in range(n):
    numInput = int(input("Nhap so: "))
    listInput1.append(numInput)
#list 2
listInput2 = []
m = int(input("Nhap so phan tu cua list 2: "))
for i in range(m):
    numInput = int(input("Nhap so: "))
    listInput2.append(numInput)
#Dao nguoc list 2
listInput2.reverse()
for i, j in zip(listInput1, listInput2):
    print(i, " ", j)