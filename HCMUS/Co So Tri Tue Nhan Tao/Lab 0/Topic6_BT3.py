#Topic 6: Data Structure Exercise
'''
Exercise 4: Count the occurrence of each element from a list
Write a program to iterate a given list and count the occurrence of each element and create a dictionary to show the count of each element.
'''
n = int(input("Nhap so phan tu cua list: "))
listInput = []
for i in range(n):
    numInput = int(input("Nhap so: "))
    listInput.append(numInput)
    sLuong = dict()
print("List da nhap: ", listInput)
 
#Dem so lan xuat hien cua tung phan tu trong list
for item in listInput:
    if item in sLuong:
        sLuong[item] += 1
    else:
        sLuong[item] = 1
print("So lan xuat hien cua ",i," la: ",sLuong)

# #Dem tung phan tu trong list
# for i in listInput:
#     sLuong = listInput.count(i)
#     print("So lan xuat hien cua ",i," la: ",sLuong)