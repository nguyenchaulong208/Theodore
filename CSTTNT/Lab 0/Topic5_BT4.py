#Topic 5: String Exercise
 #Exercise 8: Find all occurrences of a substring in a given string by ignoring the case
  #Write a program to find all occurrences of “USA” in a given string ignoring the case.

def findSubString(str, subStr):
    str = str.upper()
    subStr = subStr.upper()
    check = 0
    check = str.count(subStr)
    print("So lan xuat hien cua chuoi con la: ",check)
strInput = str(input("Nhap chuoi: "))
subStrInput = str(input("Nhap chuoi con: "))
findSubString(strInput, subStrInput)