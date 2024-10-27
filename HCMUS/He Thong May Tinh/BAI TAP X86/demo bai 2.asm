%include "io.inc"
extern _scanf
extern _printf
extern _getch
section .data
    tb db "Nhap vao so nguyen a: ",0
    tb1 db "so a la so hoan thien",0
    tb2 db "so a khong la so hoan thien",0
    fmt db "%d",0
    check db "check %d",0
section .bss
    a resd 1
    kq resd 1
    tong resd 1
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
    
    ;khoi tao vong lap
    mov dword [i], 1 ;cho i = 1

   
    
     
    
kiemtra:
     
     mov edx,0 ;gán edx = 0
     mov eax,[a]
     mov ebx,[i]  
     div ebx
     ;kiem tra uoc so
     cmp edx,0
     jne xuly
     add dword[tong],ebx ;Tong cac uoc chung
     
     

     ;kiem tra so hoan thien
    
    mov ecx,[tong]
    cmp ecx, [a]
    je true
    jmp false
    
    
    
xuly:
    inc dword [i]
    jmp kiemtra  

true:
    push tb1
    call _printf
    add esp,4
    jmp endif
false:
    push tb2
    call _printf
    add esp, 8   

endif:
    call _getch   
    
    
    xor eax, eax
    ret