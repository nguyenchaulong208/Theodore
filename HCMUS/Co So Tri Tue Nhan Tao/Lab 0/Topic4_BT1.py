#Topic 4: Functions Exercise
 #Exercise 2: Create a function with variable length of arguments
def func1(*args):
    for i in args:
        print(i)
print("\nfunc1:")
func1(20,40,60)
print("\nfunc1:")
func1(80,100)
print("\nfunc1:")
func1(120,140,160,180,200)

        