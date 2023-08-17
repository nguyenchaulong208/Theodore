#Bài t?p 1. Vi?t ch??ng trình nh?p s? nguyên n. Ki?m tra n có là s? nguyên t? hay không ?
.data
	chuoi: .asciiz "Nhap vao so nguyen n: "
	kq: .asciiz "n la so nguyen to"
	kq1: .asciiz "n khong la so nguyen to"



.text

	#Nh?p s? nguyên n
	li $v0,4
	la $a0,chuoi
	syscall	

	li $v0,5
	syscall

	add $s0,$v0,$0

