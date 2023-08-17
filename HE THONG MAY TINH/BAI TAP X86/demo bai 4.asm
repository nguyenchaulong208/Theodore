%include "io.inc"
extern _getch
extern _printf
extern _scanf
section .data
    tb db "Nhap vao so nguyen a: ",0
    tb1 db "so %d la so doi xung",0
    tb2 db "so %d khong la so doi xung",0
    fmt db "%d",0
    
section .bss
    a resd 1
    i resd 1
    f resd 1
    phandu resd 1
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
    ;khoi tao gia tri
    
    
    mov dword [i], 10
    
   
    mov eax,[a]
   
    mov ecx,0
LAP:
    
    cmp eax,0
    je check
    xor edx,edx
    div dword [i]
    mov [f],edx ;luu phan du vao f tu thanh ghi edx
    mov ebx, eax ;luu ket qua phep chia
    mov eax, ecx
    mul dword [i]
    mov edx,[f] ;luu phan du vao lai edx
    add eax, edx ;dao so a
    mov ecx, eax 
    mov eax, ebx
    
    jmp LAP
    
check:   
    cmp dword [a],ecx ;so sanh so a va so dao
    je true
    jmp false


true:
    push dword [a]
    push tb1
    call _printf
    add esp,4
    jmp end
false:
    push dword [a]
    push tb2
    call _printf
    add esp,4
    
end:
   
    
    call _getch

          
    xor eax, eax
    ret