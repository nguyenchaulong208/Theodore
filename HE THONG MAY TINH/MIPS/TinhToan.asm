.data
tb1: .asciiz "Nhap vao so a: "
tb2: .asciiz "Nhap vao so b: "
tb3: .asciiz "Tinh tong: "
tb4: .asciiz "Tinh hieu: "
tb5: .asciiz "Tinh tich: "
tb6: .asciiz "Tinh thuong: "






.text
#Xuat thong bao nhap A
li $v0,4
la $a0,tb1
syscall

#nhap vao so a.
li $v0,5
syscall
#Luu so a
add $s0,$v0,$0 # ho?c dùng l?nh move $s0,$v0


#xu?t thông báo nhap b

li $v0,4
la $a0,tb2
syscall
#nhap vao so b.
li $v0,5
syscall
#l?u b vào thanh ghi l?u tr?
add $s1,$v0,$0

#Tinh tong
add $s2,$s0,$s1
#Xuat thông báo tính t?ng
li $v0,4
la $a0,tb3
syscall

#Xu?t k?t qu? tính t?ng
li $v0,1
add $a0, $s2,$0
syscall