%include "io.inc"
extern _getch
extern _scanf
section .data
    tb1 db "Nhap n: ",0
    tb2 db "a[%d]: ",0
    tb3 db 13,10,"3. Mang vua nhap la: ", 0
    tb db 13,10,"-----------------",0
    tb4 db 13,10,"4. So lon nhat la: %d ",0
    tb5 db 13,10,"5. Trung binh mang la: %d ",0
    fn1 db "%d",0
    fn2 db "%d ",0
    
    section .bss
    j resd 1
    n resd 1
    array resd 100
    check resd 1
section .text
global CMAIN
CMAIN:
    ;write your code here
    ;nhap so luong phan tu mang
        ;xuat thong bao nhap so luong phan tu
    push tb1
    call _printf
    add esp, 4
        ;nhap phan tu mang
    push n
    push fn1
    call _scanf
    add esp, 8 ;push 2 phan tu thi xoa 2 lan
    ;nhap mang
        ;load dia chi mang vao thanh ghi ebx
    mov ebx, array
        ;khoi tao bien i
    mov esi, 0
        ;khoi tao vong lap de nhap mang
LAP.NHAP:
         ;thong bao phan tu mang
    push esi
    push tb2
    call _printf
    add esp, 8
         ;nhap a[i]
    push ebx
    push fn1
    call _scanf
    add esp, 8
        ;tang dia chi mang
    add ebx, 4
        ;tang i
    inc esi
        ;dieu kien vong lap
    cmp esi, [n]
    jl LAP.NHAP ;jl: be hon [n] => jump den LAP.NHAP

;------ 
    push tb
    call _printf
    add esp, 4
;------                 
    ;xuat mang
        ;xuat thong bao mang vua nhap
    push tb3
    call _printf
    add esp, 4
        ;load dia chi mang vao thanh ghi ebx
    mov ebx, array
        ;khoi tao bien i
    mov esi, 0
LAP.XUAT:
        ;xuat thong bao phan tu mang
    push dword [ebx]
    push fn2
    call _printf
    add esp, 8
        ;tang dia chi mang
    add ebx, 4
        ;tang i
    inc esi
        ;dieu kien vong lap
    cmp esi, [n]
    jl LAP.XUAT ;jl: be hon [n] => jump den LAP.NHAP
    

    ;tinh toan mang
        ;kiem tra so nguyen to
            ;thuc hien phep chia
     
            ;load mang vao eax de tinh toan
     mov ebx,array
            ;khoi tao bien i
     mov esi, 0
            ;chuyen gia tri mang vao thanh ghi
     mov ecx, [array]
            ;khoi tao gia tri cho thanh ghi edx
     mov edx, 0
     mov edx, [check]
     mov [check], edx
            ;tao vong lap de tinh toan
LAP.XULY:
    cmp esi, [n]
    je rs_true
            ; tang dia chi mang
    add ebx, 4
    
    mov eax, [array + esi*4]
    add [check], eax
    
    cmp eax,ecx
    jg xuly
    inc esi
    jmp LAP.XULY
    
xuly:
    mov ecx,eax
    inc esi    
    jmp LAP.XULY   
    
     
rs_true:
   
   push ecx
   push tb4
   call _printf
   add esp,8
   
   

    mov eax,[check]
    mov ebx,[n]
    xor edx,edx
    
    div ebx
    push eax
    push tb5
    call _printf
    add esp,8    
   
   
End:
    call _getch     
                
                
    
    
    xor eax, eax
    ret