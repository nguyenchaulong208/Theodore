'''
OOP Exercise 3: Create a child class Bus that will inherit all of the variables and methods of the Vehicle class
'''
class Vehicle:
#Constructor
    def __init__(self, name, max_speed, mileage):
        self.name = name
        self.max_speed = max_speed
        self.mileage = mileage

class Bus(Vehicle):
    pass
Bus1 = Bus("VinBus", 200, 10)
print("Name: ",Bus1.name,"\nMax Speed: ", Bus1.max_speed,"\nMileage: ", Bus1.mileage)
