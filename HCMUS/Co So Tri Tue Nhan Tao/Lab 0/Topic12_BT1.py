#Topic 12: OOP Exercise
'''
OOP Exercise 1: Create a Class with instance attributes
Write a Python program to create a Vehicle class with max_speed and mileage instance attributes.
'''
class Car:
    brand = "Toyota"
    max_speed = 200
    mileage = 10
modelX = Car()
print("Brand: ",modelX.brand,"\nMax Speed: ", modelX.max_speed,"\nMileage: ", modelX.mileage)