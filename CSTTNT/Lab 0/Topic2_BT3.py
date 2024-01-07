#Topic 2: Input and Output Exercise
#Exercise 5: Accept a list of 5 float numbers as an input from the user

listFloat = []
length = 5
for i in range(length):
    listFloat.append(float(input("Nhap vao gia tri cua listFloat: ")))
print("ListFloat da nhap la: ", listFloat)