#Topic 12: OOP Exercise
'''
OOP Exercise 4: Class Inheritance
Given:
Create a Bus class that inherits from the Vehicle class. Give the capacity argument of Bus.seating_capacity() a default value of 50.
'''
class Vehicle:
#Constructor
    def __init__(self, name, max_speed, mileage):
        self.name = name
        self.max_speed = max_speed
        self.mileage = mileage
class Bus(Vehicle):
    def seating_capacity(self, capacity=50):
        return capacity
Bus1 = Bus("VinBus", 200, 10)
print("Name: ",Bus1.name,"\nMax Speed: ", Bus1.max_speed,"\nMileage: ", Bus1.mileage, "\nCapacity: ", Bus1.seating_capacity())