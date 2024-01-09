#Exercise 9: Calculate the date 4 months from the current date
import datetime
from dateutil.relativedelta import relativedelta
current_date = datetime.date.today()
print("Current Date: ",current_date)
four_months = current_date + relativedelta(months=4)
print(four_months)