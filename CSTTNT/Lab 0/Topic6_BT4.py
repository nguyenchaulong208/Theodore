#Topic 6: Data Structure Exercise
'''
Exercise 5: Create a Python set such that it shows the element from both lists in a pair
'''
#list 1
n = int(input("Nhap so phan tu cua list 1: "))
listInput1 = []
for i in range(n):
    numInput = int(input("Nhap so: "))
    listInput1.append(numInput)
#list 2
m = int(input("Nhap so phan tu cua list 2: "))
listInput2 = []
for i in range(m):
    numInput = int(input("Nhap so: "))
    listInput2.append(numInput)

resultList = zip(listInput1, listInput2)
print(set(resultList))

#     #Gop list 1 va list 2 thanh 1 list
# result = []
# for i in listInput1:
#         result.append(i)
# for j in listInput2:
#         result.append(j)
    
# # listInput = listInput1 + listInput2
# print("List da gop: ", result)
