#Topic 11: Date and Time Exercise
# Exercise 1: Print current date and time in Python
import datetime
date_time = datetime.datetime.now()
print("Current date and time: ",date_time)
print("Current date and time: ",date_time.strftime("%Y-%m-%d %H:%M:%S"))
