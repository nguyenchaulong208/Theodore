class Vehicle:
#Constructor
    def __init__(self, name, mileage, capacity):
        self.name = name
        
        self.mileage = mileage
        self.capacity = capacity
class Bus(Vehicle):
    def ticket_price(self):
        price = (self.capacity * 100)*1.1
        return price
Bus1 = Bus("VinBus",10,50)
print("Name: ",Bus1.name,"\nMileage: ", Bus1.mileage, "\nCapacity: ", Bus1.ticket_price())