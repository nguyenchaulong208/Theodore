#Topic 9: Set Exercise
'''
Exercise 5: Remove items from the set at once
Write a Python program to remove items 10, 20, 30 from the following set at once.
set1 = {10, 20, 30, 40, 50}
'''
set1 = {10, 20, 30, 40, 50}
#1
set1.remove(10)
set1.remove(20)
set1.remove(30)

print(set1)
#2
set1.difference_update({10, 20, 30})
print(set1)