#Topic 3: Loop Exercise
#Exercise 3: Calculate the sum of all numbers from 1 to a given number
 #Write a program to accept a number from a user and calculate the sum of all numbers from 1 to a given number
phepCong = 0
soLan = int(input("Nhap so lan lap lai: "))
for i in range(soLan + 1):
    phepCong = phepCong + i
    print(i, "||", phepCong)
print("Ket qua phep cong la: ", phepCong)

  
        


