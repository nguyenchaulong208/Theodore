#Topic 4: Functions Exercise
 #Exercise 3: Return multiple values from a function
    #Write a program to create function calculation() such that it can accept two variables and calculate addition and subtraction.
    #Also, it must return both addition and subtraction in a single return call.

def calculation(a,b):

    # phepCong = a + b
    # phepTru = a - b
    # return phepCong, phepTru
    return a + b, a - b

res = calculation(40,10)
print(res)
res1 = calculation(20,10)
print(res1)