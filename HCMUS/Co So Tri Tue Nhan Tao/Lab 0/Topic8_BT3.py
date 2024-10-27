#Topic 8: Dictionary Exercise
'''
Exercise 4: Initialize dictionary with default values
In Python, we can initialize the keys with the same values.
'''
employees = ['Kelly', 'Emma']
defaults = {"designation": 'Developer', "salary": 8000}
result = dict.fromkeys(employees, defaults)
print(result)
#Them phan tu vao dictionary
result["Theodore"] = {"designation": 'Data Scientist', "salary": 10000}
print(result)

#-----------------END-----------------
creatDictionary = {

}
#Them phan tu vao dictionary
creatDictionary["Theodore"] = {"designation": 'Data Scientist', "salary": 10000}
creatDictionary["Kelly"] = {"designation": 'Developer', "salary": 8000}
creatDictionary["Emma"] = {"designation": 'Developer', "salary": 8000}
print(creatDictionary)