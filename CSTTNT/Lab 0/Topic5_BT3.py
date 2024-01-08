#Topic 5: String Exercise
 #Exercise 7: String characters balance Test

def checkString(str1, str2):
    for i in str1:
        if i in str2:
            continue
        else:
            return False
    return True
strInput1 = str(input("Nhap chuoi 1: "))
strInput2 = str(input("Nhap chuoi 2: "))
print(checkString(strInput1, strInput2))