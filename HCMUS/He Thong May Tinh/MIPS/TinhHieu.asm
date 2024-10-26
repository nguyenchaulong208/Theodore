.data
	tb1: .asciiz "Nhap vao so a: "
	tb2: .asciiz "Nhap vao so b: "
	tb3: .asciiz "Tinh hieu: "
.text
	#Nhap vao so a
	
	li $v0,4
	la $a0,tb1
	syscall

	li $v0,5
	syscall
	
	add $s0,$v0,$0

	#Nhap vao so b
	
	li $v0,4
	la $a0,tb2
	syscall
	
	li $v0,5
	syscall

	add $s1,$v0,$0

	#Tinh hieu

	sub $s3,$s0,$s1

	li $v0,4
	la $a0,tb3
	syscall

	li $v0,1
	sub $a0, $s3,$0
	syscall

	