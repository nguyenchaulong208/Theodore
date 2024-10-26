#Topic 5: String Exercise
#Exercise 2: Append new string in the middle of a given string
 #Given two strings, s1 and s2. Write a program to create a new string s3 by appending s2 in the middle of s1.

def appendString(str1, str2):
    lengthStr1 = int(len(str1)/2)
    middleStr1 = str1[:lengthStr1]
    middleStr1 += str2
    middleStr1 += str1[lengthStr1:]
    print("Ket qua la: ",middleStr1)

appendString("Ault", "Kelly")
strInput1 = str(input("Nhap chuoi 1: "))
strInput2 = str(input("Nhap chuoi 2: "))
appendString(strInput1, strInput2)