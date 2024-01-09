#Topic 11: Date and Time Exercise
#Exercise 8: Convert the following datetime into a string
import datetime
date_time = datetime.datetime(2018, 7, 26, 12, 0, 0)
# date_timeStr =  date_time.strftime("%Y-%m-%d %H:%M:%S")
date_timeStr = str(date_time)
print(date_timeStr)