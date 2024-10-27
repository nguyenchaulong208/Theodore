%include "io.inc"
extern _scanf
extern _printf
extern _getch
section .data
    tb db "Nhap vao so nguyen a: ",0
    tb1 db "so %d la so hoan thien",0
    tb2 db "so %d khong la so hoan thien",0
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
    ;mov dword [i], 1 ;cho i = 1
    mov dword [tong], 0
    mov ebx, 1
    
     
    
kiemtra:
     
     
     ;gán edx = 0
     mov eax,[a]
     cmp ebx,eax
     je xuat
     xor edx, edx
     div ebx
     ;mov eax,ecx
     ;kiem tra uoc so
     cmp edx,0
     je xuly
     inc ebx
     
     jmp kiemtra
     
     ;mov ecx, [tong]
     ;cmp ecx, [a]
     
     
    
xuly:
     mov eax,[tong]
     add eax, ebx
     mov [tong],eax
     inc ebx
     jmp kiemtra
     
 xuat:
    mov eax,[a]
    mov ebx,[tong]
    cmp eax,ebx
    je rs_true
    cmp eax,ebx
    jge rs_false
    
     
rs_true:
    push dword [a]
    push tb1
    call _printf
    add esp,4
    jmp endif
rs_false:
    push dword [a]
    push tb2
    call _printf
    add esp,4
    jmp endif
   
endif:
   call _getch
   xor eax, eax
    ret