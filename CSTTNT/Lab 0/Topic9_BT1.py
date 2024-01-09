#Topic 9: Set Exercise
'''
Exercise 2: Return a new set of identical items from two sets
set1 = {10, 20, 30, 40, 50}
set2 = {30, 40, 50, 60, 70}
'''
set1 = {10, 20, 30, 40, 50}
set2 = {30, 40, 50, 60, 70}
#1
result = set1.intersection(set2)
print(result)
#2
result = set1 & set2
print(result)

#-----------------END-----------------