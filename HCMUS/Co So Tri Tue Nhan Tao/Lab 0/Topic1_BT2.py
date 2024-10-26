#Topic 1. Basic Exercise for Beginners
'''
Exercise 2: Print the sum of the current number and the previous number
'''

soTrc = 0
soHienTai = 0
for i in range(10):
    
    soHienTai = soTrc + i
    print(i, "||", soTrc, "||", soHienTai )
    soTrc = i
