%include "io.inc"
extern _getch
extern _printf
extern _scanf
section .data
    tb db "Nhap vao so nguyen a: ",0
    tb1 db "so a la so chinh phuong",0
    tb2 db "so a khong la so chinh phuong",0
    fmt db "%d",0
    check db "check %d",0
section .bss
    a resd 1
    i resd 1
    kq resd 1
section .text
global CMAIN
CMAIN:
    ;write your code here
    ;xuat thong bao nhap a
    push tb
    call _printf
    add esp, 4
    ;nhap vao so a
    push a
    push fmt
    call _scanf
    add esp, 8
    ;kiem tra so chinh phuong
    
    mov dword [i], 1
LAP:
    mov edx, 0
    mov eax,[i]
    mul dword [i]

    cmp eax,[a]
    jne xuly
    je true
    
    
    
xuly:
    inc dword [i]
    jmp LAP
true:
    push tb1
    call _printf
    add esp,4
    jmp end
false:
    push tb2
    call _printf
    add esp,4
end:
    call _getch 
    
    xor eax, eax
    ret