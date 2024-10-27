#Topic 4: Functions Exercise
 #Exercise 4: Create a function with a default argument
  #Write a program to create a function show_employee() using the following conditions.
   #It should accept the employee’s name and salary and display both.
   #If the salary is missing in the function call then assign default value 9000 to salary
def showEmployee(name, salary = 9000):
    print("Name: ",name,"\nSalary: ",salary)

showEmployee("Theodore", 10000)
showEmployee("Jade")
Name = input("Nhap ten: ")
Salary = int(input("Nhap luong: "))
showEmployee(Name, Salary)

Name = input("Nhap ten: ")
showEmployee(Name)


