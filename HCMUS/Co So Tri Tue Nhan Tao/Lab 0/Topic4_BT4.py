#Topic 4: Functions Exercise
 #Exercise 6: Create a recursive function
    #Write a program to create a recursive function to calculate the sum of numbers from 0 to 10
    #A recursive function is a function that calls itself again and again

def tinhTong(num): #Voi param la 10 thi num = 10 <=> se tinh tong tu 10 den 0
    if num > 0: 
        return num + tinhTong(num - 1)
    else: # dieu kien dung cua de quy
        return 0
param = tinhTong(10) 
print(param)
