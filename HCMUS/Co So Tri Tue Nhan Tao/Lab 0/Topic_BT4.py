#Topic 10: Tuple Exercise
'''
Exercise 6: Copy specific elements from one tuple to a new tuple
Write a program to copy elements 44 and 55 from the following tuple into a new tuple.
tuple1 = (11, 22, 33, 44, 55, 66)
'''
tuple1 = (11, 22, 33, 44, 55, 66)
#1
tuple2 = tuple1[3:5]
print(tuple2)
#2
tuple3 = tuple1[3:-1]
print(tuple3)