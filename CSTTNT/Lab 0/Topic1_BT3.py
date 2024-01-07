#Topic 1. Basic Exercise for Beginners
'''
Exercise 5: Check if the first and last number of a list is the same
'''
n = int(input("Nhap so phan tu cua list: "))
listA = []
for i in range(n):
    listA.append(int(input("Nhap vao gia tri cua listA: ")))
print("Kiem tra gia tri dau va cuoi cua listA da nhap: ")
def checkNumber(listA):
    if listA[0] == listA[n-1]:
        return True
    else:
        return False
print(checkNumber(listA))