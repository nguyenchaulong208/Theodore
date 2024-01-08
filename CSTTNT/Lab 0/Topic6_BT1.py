#Topic 6: Data Structure Exercise
'''
 Exercise 1: Create a list by picking an odd-index items from the first list and even index items from the second
    Given two lists, l1 and l2, write a program to create a third list l3 by picking an odd-index element from the list l1 and even index elements from the list l2.
'''
def listItems(list1, list2):
    result = []
    for i in range(len(list1)):
        if i % 2 != 0:
            result.append(list1[i])
    for j in range(len(list2)):
        if j % 2 == 0:
            result.append(list2[j])
    print("Ket qua la: ",result)
listItems([3, 6, 9, 12, 15, 18, 21], [4, 8, 12, 16, 20, 24, 28])
#List tu nhap
listInput1 = []

n = int(input("Nhap so phan tu cua list 1: "))
for i in range(n):
    numInput = int(input("Nhap so: "))
    listInput1.append(numInput)

listInput2 = []
m = int(input("Nhap so phan tu cua list 2: "))
for i in range(m):
    numInput = int(input("Nhap so: "))
    listInput2.append(numInput)

listItems(listInput1, listInput2)
