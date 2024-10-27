#Topic 3: Loop Exercise
'''
Write a program to display only those numbers from a list that satisfy the following conditions
 The number must be divisible by five
 If the number is greater than 150, then skip it and move to the next number
 If the number is greater than 500, then stop the loop
'''
numList = []
n = int(input("Nhap so phan tu cua list: "))
for i in range(n):
    numInput = int(input("Nhap so: "))
    numList.append(numInput)
for numIn in numList:
    
    if numIn > 500:
        break
    elif numIn > 150:
        continue
    elif numIn % 5 == 0:
        print(numIn)
        
        
