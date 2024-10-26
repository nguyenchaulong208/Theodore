#Topic 5: String Exercise
 #Exercise 1B: Create a string made of the middle three characters
   #Write a program to create a new string made of the middle three characters of an input string.
def middleChar(input_str):
    lengthStr = int(len(input_str)/2)
    result = input_str[lengthStr-1:lengthStr+2]
    print("Ket qua la: ",result)

middleChar("Python")
middleChar("JavaScript")
middleChar("Intelligence Artificielle")
intStr = str(input("Nhap chuoi: "))
middleChar(intStr)
