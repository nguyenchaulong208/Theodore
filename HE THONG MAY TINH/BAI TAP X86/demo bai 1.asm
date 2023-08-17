%include "io.inc"

extern _scanf
extern _printf
extern _getch
section .data
    tb1 db "Nhap vao so nguyen a: ",0
    tb2 db "so %d la so nguyen to",0
    tb3 db "so %d khong la so nguyen to",0
    fmt db "%d",0
    
   
    


section .bss
    a resd 1
    
    

section .text
global CMAIN
CMAIN:
   
    ;write your code here
    
    
    ;xuat thong bao tb1
    
    push tb1
    call _printf
    add esp,4
    
    ;nhap so a
    
    push a
    push fmt
    call _scanf
    add esp,8
    
    ;kiem tra so nguyen to
    mov eax, [a]
    cmp eax,0 
    jle khong
    cmp eax,1 
    je khong
     ;thuc hien phep chia
     mov eax,[a]
     mov ebx, 2
     xor edx, edx  
     div ebx    
     
 
  
     
        
    ;kiem tra phep chia
    
    
    mov ebx, 2 ;gan 2 vao thanh ghi ebx => nhay den vong lap
    jmp KTSONGUYENTO
    
    
    
    

;vong lap

KTSONGUYENTO:  
    ;kiem tra phan du
     
     mov eax, [a]
     ;mov ebx, 2
     xor edx,edx
     div ebx
     
     cmp edx, 0
     je khong
     
     cmp edx, 0
     jne nguyento
     inc ebx ;tang ebx len 1
     
     jmp KTSONGUYENTO 
     
     
     
    
nguyento:
   push dword [a]
   push tb2
   call _printf
   add esp,4
   jmp End_case

khong:
    push dword [a]
    push tb3
    call _printf
    add esp,4

End_case:
    call _getch

    xor eax, eax
    ret
    