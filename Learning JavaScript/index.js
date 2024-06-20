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
let firstName = 'Theodore';

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
document.getElementById('mySubmit').onclick = function () {
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
//-----------------------------------------------
//5. Type Conversion
/*
 - Type conversion : chuyển đổi kiểu dữ liệu
 - String() : chuyển đổi sang kiểu chuỗi
 - Number() : chuyển đổi sang kiểu số
 - Boolean() : chuyển đổi sang kiểu boolean
 --------------------------------
 - parseInt() : chuyển đổi sang kiểu số nguyên
 - parseFloat() : chuyển đổi sang kiểu số thực
 --------------------------------
 - toString() : chuyển đổi sang kiểu chuỗi
 - toFixed() : làm tròn số
 --------------------------------

 */
//Ví dụ:
//    let age1 = prompt("How old are you?");
age1 = 20;
console.log('first age: ', age1);
console.log('type of age1: ', typeof age1);
age1 = String(age1);
console.log('type of age1: ', typeof age1);

//-----------------------------------------------

//6. Constants
/*
    - Constants : hằng số
    - const : khai báo hằng số
    - hằng số không thể thay đổi giá trị
    --------------------------------
    - const PI = 3.14;
    - PI = 3.14159; => error
    --------------------------------
    */
//Ví dụ:
//    const PI = 3.14;
//    console.log(PI);
//    PI = 3.14159;
//     console.log(PI);
// => error
// const PI = 3.14;
// let radius;
// let circumference;

// radius = window.prompt('Enter radius');
// radius = Number(radius);
// circumference = 2 * PI * radius;
// console.log('Circumference: ', circumference);

//Cach viet theo kieu professional

const PI = 3.14;
let radius;
let circumference;
// PI = 100; //=> error
document.getElementById('myConstants').onclick = function () {
    radius = document.getElementById('constants').value;
    radius = Number(radius);
    circumference = 2 * PI * radius;
    document.getElementById('resultContants').textContent = `Circumference: ${circumference}`;
}
//textContent : gán giá trị cho thẻ text trong html

//-----------------------------------------------
//7. Counter Program
/*
    - Counter Program : chương trình đếm
    - sử dụng biến để lưu trữ giá trị đếm
    - sử dụng toán tử ++ để tăng giá trị đếm
    --------------------------------
    */
//Ví dụ:
const decreaseBtn = document.getElementById('decreaseBtn');
const increaseBtn = document.getElementById('increaseBtn');
const resetBtn = document.getElementById('resetBtn');
let count = 0;
increaseBtn.onclick = function () {
    count++;
    resultCounter.textContent = count;
}
decreaseBtn.onclick = function () {
    count--;
    resultCounter.textContent = count;
}
resetBtn.onclick = function () {
    count = 0;
    resultCounter.textContent = count;
}
//-----------------------------------------------
//8. Math Object
/*
Math = built-in object that prides a collection and properties and methods
- Math Object : đối tượng toán học
- Math.PI : số PI
- Math.round() : làm tròn số
- Math.ceil() : làm tròn lên
- Math.floor() : làm tròn xuống
- Math.sqrt() : căn bậc 2
- Math.abs() : giá trị tuyệt đối
- Math.pow() : lũy thừa
- Math.min() : tìm số nhỏ nhất
- Math.max() : tìm số lớn nhất
- Math.random() : số ngẫu nhiên
--------------------------------
*/
//Ví dụ:
// console.log(`Math.PI: ${Math.PI}`);
// console.log(`Math.E: ${Math.E}`);
// console.log(`Math.round(4.7): ${Math.round(4.7)}`);
// console.log(`Math.ceil(4.4): ${Math.ceil(4.4)}`);
// console.log(`Math.floor(4.7): ${Math.floor(4.7)}`);
// console.log(`Math.sqrt(16): ${Math.sqrt(16)}`);
// console.log(`Math.abs(-4): ${Math.abs(-4)}`);
// console.log(`Math.pow(2, 3): ${Math.pow(2, 3)}`);
// console.log(`Math.min(0, -3, 5): ${Math.min(0, -3, 5)}`);
// console.log(`Math.max(0, -3, 5): ${Math.max(0, -3, 5)}`);
// console.log(`Math.random(): ${Math.random()}`);

var num = 4;
var num2 = 4.5;
var num3 = 4.2;
var num4 = -4;
document.getElementById('pi').textContent = `Math.PI: ${Math.PI}`;
document.getElementById('round').textContent = `Math.round of ${num2}: ${Math.round(num2)}`;
document.getElementById('ceil').textContent = `Math.ceil of ${num3}: ${Math.ceil(num3)}`;
document.getElementById('floor').textContent = `Math.floor of ${num3}: ${Math.floor(num3)}`;
document.getElementById('sqrt').textContent = `Math.sqrt of ${num}: ${Math.sqrt(num)}`;
document.getElementById('abs').textContent = `Math.abs of ${num4}: ${Math.abs(num4)}`;
document.getElementById('pow').textContent = `Math.pow of ${num}: ${Math.pow(num, 3)}`;
document.getElementById('min').textContent = `Math.min of 0, -3, 5: ${Math.min(0, -3, 5)}`;
document.getElementById('max').textContent = `Math.max of 0, -3, 5: ${Math.max(0, -3, 5)}`;
document.getElementById('random').textContent = `Math.random: ${Math.random()}`;
//-----------------------------------------------
//8. Random Number Generator
/*
    - Random Number Generator : tạo số ngẫu nhiên
    - Math.random() : tạo số ngẫu nhiên từ 0 đến 1
    - Math.floor(Math.random() * 10) : tạo số ngẫu nhiên từ 0 đến 9
    - Math.floor(Math.random() * 10 + 1) : tạo số ngẫu nhiên từ 1 đến 10
    --------------------------------
    */
//Ví dụ:
var randomNum = Math.random();
const min = 50;
const max = 100;
document.getElementById('randomNum').textContent = `Random number: ${randomNum}`;
document.getElementById('randomNum0-6').textContent = `Random number from 0 to 5: ${Math.floor(Math.random() * 6)}`;
document.getElementById('randomNumMin-max').textContent = `Random number from ${min} to ${max}: ${Math.floor(Math.random() * (max - min)) + min}`;
//-----------------------------------------------
//9. If...Else Statement
/*
 if a condition is true, execute some code
 if not, do something else
*/
//Ví dụ:
let ageIf = 10;
if (ageIf >= 18) {
    document.getElementById('ifElse').textContent = 'You are an adult';
}
else {
    document.getElementById('ifElse').textContent = 'You are a child';
}

//-----------------------------------------------
//10. Checked Properties
/*
    - Checked Properties : thuộc tính kiểm tra
    - checked : kiểm tra xem checkbox hoặc radio button có được chọn hay không
    --------------------------------
    */
//Ví dụ:
const myCheck = document.getElementById('myCheck'); //Lấy thẻ input có id là myCheck
const visaBtn = document.getElementById('visaBtn'); //Lấy thẻ button có id là visaBtn
const masterBtn = document.getElementById('masterBtn'); //Lấy thẻ button có id là masterBtn
const paypalBtn = document.getElementById('paypalBtn'); //Lấy thẻ có id là paypalBtn
const submitBtn = document.getElementById('submitBtn'); //Lấy thẻ có id là submitBtn
const resultCheck = document.getElementById('resultCheck'); //Lấy thẻ có id là resultCheck
const paymentResult = document.getElementById('paymentResult'); //Lấy thẻ có id là paymentResult

submitBtn.onclick = function () {

    if (myCheck.checked) {
        subResult.textContent = 'Your are subscribed';

    }
    else {
        subResult.textContent = 'Your are not subscribed';
    }
    if (visaBtn.checked) {
        paymentResult.textContent = 'You are paying with Visa';
    }
    else if (masterBtn.checked) {
        paymentResult.textContent = 'You are paying with Master';
    }
    else if (paypalBtn.checked) {
        paymentResult.textContent = 'You are paying with Paypal';
    }
    else {
        paymentResult.textContent = 'You have not chosen any payment method';
    }
}

//-----------------------------------------------
//11. Termary Operator
/*
    - Termary Operator : toán tử 3 ngôi
    - condition ? expr1 : expr2
    - nếu condition là true thì expr1 được thực thi
    - nếu condition là false thì expr2 được thực thi
    --------------------------------
    */
//Ví dụ:
let ageTermary = 20;
let resultTermary = ageTermary >= 18 ? 'You are an adult' : 'You are a child';//Nếu age >= 18 thì result = 'You are an adult' ngược lại result = 'You are a child'
document.getElementById('termary').textContent = resultTermary;
//Cach viet day du
if (ageTermary >= 18) {
    document.getElementById('termary2').textContent = 'You are an adult';
}
else {
    document.getElementById('termary2').textContent = 'You are a child';
}

//-----------------------------------------------
//12. Switch Statement
/*
    - Switch Statement : câu lệnh switch, tương tự if...else. 
    - sử dụng khi có nhiều trường hợp cần xử lý
    - switch(expression){
        case value1:
            //code
            break;
        case value2:
            //code
            break;
        default:
            //code
            break;
    }
    --------------------------------
    */
//Ví dụ:
let day = 4;

switch (day) {
    case 1:
        document.getElementById('switch').textContent = 'Monday';
        break;
    case 2:
        document.getElementById('switch').textContent = 'Tuesday';
        break;
    case 3:
        document.getElementById('switch').textContent = 'Wednesday';
        break;
    case 4:
        document.getElementById('switch').textContent = 'Thursday';
        break;
    case 5:
        document.getElementById('switch').textContent = 'Friday';
        break;
    case 6:
        document.getElementById('switch').textContent = 'Saturday';
        break;
    case 7:
        document.getElementById('switch').textContent = 'Sunday';
        break;
    default:
        document.getElementById('switch').textContent = 'Invalid day';
        break;
}
//break dung de ket thuc 1 case, nếu không dùng break thì sẽ thực thi tiếp các case phía sau dù đã thỏa mãn điều kiện
//ví dụ khác:
let testScore = 92;
let letterGrade;
switch (true) {
    case testScore >= 90:
        letterGrade = 'A';
        break;
    case testScore >= 80:
        letterGrade = 'B';
        break;
    case testScore >= 70:
        letterGrade = 'C';
        break;
    case testScore >= 60:
        letterGrade = 'D';
        break;
    default:
        letterGrade = 'F';
        break;
}
document.getElementById('switch2').textContent = `Your grade is: ${letterGrade}`;

//-----------------------------------------------
//13. String Methods
/*
    - String Methods : cho phép bạn thao tác và làm việc với văn bản
    - length : độ dài chuỗi
    - toUpperCase() : chuyển chuỗi thành chữ in hoa
    - toLowerCase() : chuyển chuỗi thành chữ in thường
    - charAt() : lấy ký tự ở vị trí x
    - indexOf() : tìm vị trí của ký tự đầu tiên
    - lastIndexOf() : tìm vị trí của ký tự cuối cùng
    - slice() : cắt chuỗi
    - substring() : cắt chuỗi
    - substr() : cắt chuỗi
    - replace() : thay thế chuỗi
    - split() : tách chuỗi
    - trim() : xóa khoảng trắng 2 đầu chuỗi
    - concat() : nối chuỗi
    - includes() : kiểm tra chuỗi có chứa chuỗi khác không
    - startsWith() : kiểm tra chuỗi có bắt đầu bằng chuỗi khác không
    - endsWith() : kiểm tra chuỗi có kết thúc bằng chuỗi khác không
    - repeat() : lặp lại chuỗi
    - match() : tìm chuỗi
    - search() : tìm chuỗi
    - localeCompare() : so sánh chuỗi
    - toString() : chuyển đổi sang chuỗi
    - valueOf() : trả về giá trị nguyên thủy của chuỗi
    - replaceAll() : thay thế tất cả chuỗi
    - padStart() : thêm chuỗi vào đầu chuỗi
    - padEnd() : thêm chuỗi vào cuối chuỗi

    

    --------------------------------
    */

//Ví dụ:
let str = 'BroCode';
document.getElementById('length').textContent = `Length: ${str.length}`;
document.getElementById('toUpperCase').textContent = `toUpperCase: ${str.toUpperCase()}`;
document.getElementById('toLowerCase').textContent = `toLowerCase: ${str.toLowerCase()}`;
document.getElementById('charAt').textContent = `charAt: ${str.charAt(3)}`;
document.getElementById('indexOf').textContent = `indexOf: ${str.indexOf('o')}`;
document.getElementById('lastIndexOf').textContent = `lastIndexOf: ${str.lastIndexOf('o')}`;
document.getElementById('slice').textContent = `slice: ${str.slice(1, 3)}`;
document.getElementById('substring').textContent = `substring: ${str.substring(1, 3)}`;
document.getElementById('substr').textContent = `substr: ${str.substr(1, 3)}`;
document.getElementById('replace').textContent = `replace: ${str.replace('Bro', 'Sis')}`;
document.getElementById('split').textContent = `split: ${str.split('o')}`;
document.getElementById('trim').textContent = `trim: ${str.trim()}`;
document.getElementById('concat').textContent = `concat: ${str.concat(' is awesome')}`;
document.getElementById('includes').textContent = `includes: ${str.includes('Bro')}`;
document.getElementById('startsWith').textContent = `startsWith: ${str.startsWith('Bro')}`;
document.getElementById('endsWith').textContent = `endsWith: ${str.endsWith('Code')}`;
document.getElementById('repeat').textContent = `repeat: ${str.repeat(3)}`;
document.getElementById('match').textContent = `match: ${str.match('o')}`;
document.getElementById('search').textContent = `search: ${str.search('o')}`;
document.getElementById('localeCompare').textContent = `localeCompare: ${str.localeCompare('BroCode')}`;
document.getElementById('valueOf').textContent = `valueOf: ${str.valueOf()}`;
document.getElementById('replaceAll').textContent = `replaceAll: ${str.replaceAll('o', 'a')}`;
document.getElementById('padStart').textContent = `padStart: ${str.padStart(10, '0')}`;
document.getElementById('padEnd').textContent = `padEnd: ${str.padEnd(10, '0')}`;


