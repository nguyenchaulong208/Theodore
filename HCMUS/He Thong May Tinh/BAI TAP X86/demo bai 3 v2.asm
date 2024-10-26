%include "io.inc"
extern _getch
extern _printf
extern _scanf
section .data
    tb db "Nhap vao so nguyen a: ",0
    tb1 db "so %d la so chinh phuong",0
    tb2 db "so %d khong la so chinh phuong",0
    fmt db "%d",0
    check db "check %d",0
section .bss
    a resd 1
    i resd 1
    
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
    mov ecx, [a]
    mov dword [i], 2
    cmp ecx, 0
    je true
    cmp ecx, 1
    je true
    
LAP:
    cmp dword [i], ecx
    je false
    
    mov eax,[i]
    mul dword [i]

    cmp eax,ecx
    
    je true
    inc dword [i]
    jmp LAP
    
    

true:
    push ecx
    push tb1
    call _printf
    add esp,4
    jmp end
false:
    push ecx
    push tb2
    call _printf
    add esp,4
end:
    call _getch 
    
    xor eax, eax
    ret