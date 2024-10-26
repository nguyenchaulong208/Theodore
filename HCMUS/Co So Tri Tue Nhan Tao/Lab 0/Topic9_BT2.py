#Topic 9: Set Exercise
'''
Exercise 3: Get Only unique items from two sets
Write a Python program to return a new set with unique items from both sets by removing duplicates.
set1 = {10, 20, 30, 40, 50}
set2 = {30, 40, 50, 60, 70}
'''
set1 = {10, 20, 30, 40, 50}
set2 = {30, 40, 50, 60, 70}
#1
result = set1 | set2
print(result)
#2
result = set1.union(set2)
print(result)
