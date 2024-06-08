//1. JavaScript tutorial for beginners 
//syntax cơ bản của javascript

// console.log('Hello, world!'); //Hiển thị thông báo trên console
// console.log('Hello, world!'); //Hiển thị thông báo trên console
// window.alert('Hello, world!'); //Hiển thị thông báo trên trình duyệt
 //Comment trong javascript dùng // hoặc /* */ 

//-----------------------------------------------
 //Tạo 1 thẻ <h1> trong và gán giá trị cho nó
 document.getElementById('myH1').textContent = 'This is my h1 tag';
 /*
    - document : đại diện cho trang web
    - document.getElementById('myH1') : lấy thẻ có id là myH1
    - textContent : gán giá trị cho thẻ
 */
//tương tự với thẻ <p>
document.getElementById('myP').textContent = 'This is my paragraph';
//-----------------------------------------------

//2. VARIABLE
//variable là biến, dùng để lưu trữ giá trị
/*
khai báo biến: VD: var name = 'John';
    - var : khai báo biến
    - name : tên biến
    - 'John' : giá trị của biến
    --------------------------------
    sự khác nhau giữa var, let, const
    - var : biến có thể thay đổi giá trị và có thể khai báo nhiều lần trong cùng 1 scope (phạm vi)
    - let : biến có thể thay đổi giá trị nhưng không thể khai báo nhiều lần trong cùng 1 scope (phạm vi)
    - const : biến không thể thay đổi giá trị và không thể khai báo nhiều lần trong cùng 1 scope (phạm vi)
    --------------------------------
    dấu `` : template string
    ví dụ: `Hello, ${name}`
    so sánh dấu '' và ``
    - '' : dùng để bao quanh chuỗi
    - `` : dùng để bao quanh chuỗi và chèn biến vào chuỗi bằng ${}
    --------------------------------
    string : chuỗi
    number : số
    boolean : true/false
    --------------------------------

*/
//VD: Khai bao biến
// var name = 'John';
// let age = 25;
// var num1 = 10;
// var num2 = 20;
// const isMale = true;
// console.log(name, age, isMale);
// //VD: template string
// console.log(`Hello, ${name}`);
// console.log(`Tong cua ${num1} va ${num2} la: ${num1 + num2}`);
let firstName ='Theodore';

console.log(`Your name is ${firstName}, type is ${typeof firstName} and length is ${firstName.length} characters`);

// ví dụ về biến
let fullName = 'Theodore Nguyen';
let age = 25;
let student = false;

document.getElementById('name').textContent = `Your name is ${fullName}`;
document.getElementById('age').textContent = `Your age is ${age}`;
document.getElementById('isStudent').textContent = `Is student: ${student}`;

//-----------------------------------------------

//3. Arithmetic Operators
/*
    - Cộng : +
    - Trừ : -
    - Nhân : *
    - Chia : /
    - Chia lấy dư : %
    - Tăng 1 : ++
    - Giảm 1 : --
    - lũy thừa : **
    - độ ưu tiên của toán tử : (), **, *, /, %, +, -

    
*/
//Ví dụ:
let result = 1 + 2 * 3 + 4 ** 2;
console.log(result);

//-----------------------------------------------
//4. Accepting User Input
/*
    EASY WAY TO ACCEPT USER INPUT
    - prompt : hiển thị hộp thoại cho người dùng nhập dữ liệu
    - alert : hiển thị hộp thoại thông báo
    - confirm : hiển thị hộp thoại xác nhận
    => tác dụng của 3 hàm trên là hiển thị hộp thoại
    PROFESSIONAL WAY TO ACCEPT USER INPUT
    - sử dụng DOM để lấy dữ liệu từ người dùng
    - sử dụng event để lấy dữ liệu từ người dùng
    - sử dụng form để lấy dữ liệu từ người dùng
    --------------------------------
    syntax easy way:
    - var name = prompt('Enter your name');
    - alert('Hello, ' + name);
    - var isSure = confirm('Are you sure?');
    - console.log(isSure);
    --------------------------------
    syntax professional way:
    - var name = document.getElementById('name').value;
    - var name = document.getElementById('name').textContent;
    - var name = document.getElementById('name').innerText;
    --------------------------------
    syntax form:
    - <form>
        <input type="text" id="name">
        <button onclick="submit()">Submit</button>
      </form>
    - function submit(){
        var name = document.getElementById('name').value;
        console.log(name);
      }
    --------------------------------
*/
// // ví dụ về easy way:
// let username;
// username = window.prompt('What is your name?');
//Ví dụ về professional way

let userName;
document.getElementById('mySubmit').onclick = function(){
    userName = document.getElementById('myText').value;
    document.getElementById('text').textContent = `Hello, ${userName}`;
}
    /*
    - document.getElementById('mySubmit') : lấy thẻ có id là mySubmit
    - onclick : sự kiện click vào thẻ
    - function() : hàm xử lý sự kiện
    - document.getElementById('myText').value : lấy giá trị của thẻ input có id là myText
    - document.getElementById('text').textContent : gán giá trị cho thẻ có id là text
    */