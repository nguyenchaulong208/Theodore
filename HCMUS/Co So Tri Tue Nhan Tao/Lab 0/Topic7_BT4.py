#Topic 7: List Exercise
'''
Exercise 9: Replace list’s item with new value if found
You have given a Python list. Write a program to find value 20 in the list, and if it is present, replace it with 200. Only update the first occurrence of an item.
'''
listInput = list1 = [5, 10, 15, 20, 25, 50, 20]
print("List da nhap: ", listInput)
print("Vi tri cua phan tu 20 trong list: ",listInput.index(20))
listInput[listInput.index(20)] = 200
print("List sau khi thay doi: ",listInput)