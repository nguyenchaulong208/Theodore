#Topic 7: List Exercise
 #Exercise 1: Reverse a list in Python


listInput = []
n = int(input("Nhap so phan tu cua list: "))
for i in range(n):
    numInput = int(input("Nhap so: "))
    listInput.append(numInput)
listInput.reverse()
print("List da nhap: ", listInput)
print("List da dao nguoc: ",listInput)

