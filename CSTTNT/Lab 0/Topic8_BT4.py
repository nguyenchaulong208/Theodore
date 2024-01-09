#Topic 8: Dictionary Exercise
#Exercise 6: Delete a list of keys from a dictionary
dictionary1 = {
    "Name": "Theodore",
    "Age": 25,
    "Salary": 10000,
    "City": "Ho Chi Minh",
    "Country": "Viet Nam"
}
print(dictionary1)

#Xoa phan tu trong dictionary
del dictionary1["Name"]
print(dictionary1)
dictionary1.pop("Age")
print(dictionary1)

