#B�i t?p 1. Vi?t ch??ng tr�nh nh?p s? nguy�n n. Ki?m tra n c� l� s? nguy�n t? hay kh�ng ?
.data
	chuoi: .asciiz "Nhap vao so nguyen n: "
	kq: .asciiz "n la so nguyen to"
	kq1: .asciiz "n khong la so nguyen to"



.text

	#Nh?p s? nguy�n n
	li $v0,4
	la $a0,chuoi
	syscall	

	li $v0,5
	syscall

	add $s0,$v0,$0

