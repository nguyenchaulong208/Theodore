#Topic 11: Date and Time Exercise
#Exercise 4: Print a date in a the following format
import datetime
date_time = datetime.datetime.now()
date_time = date_time.strftime("%A-%d-%b-%Y")
print("Current date: ",date_time)
