#Topic 7: List Exercise
'''
 Exercise 3: Turn every item of a list into its square
Given a list of numbers. write a program to turn every item of a list into its square
 '''

listInput = []
n = int(input("Nhap so phan tu cua list: "))
for i in range(n):
    numInput = int(input("Nhap so: "))
    listInput.append(numInput)
print("List da nhap: ", listInput)
listOutput = []
for i in listInput:
    listOutput.append(i*i)
print("List da tinh binh phuong: ", listOutput)