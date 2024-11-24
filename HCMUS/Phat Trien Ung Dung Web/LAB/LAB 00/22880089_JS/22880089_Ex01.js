
//Khai bao bien và kieu du lieu:
var age = 18;	// Number
var name = "Jane";	// String
var name = {first: "Jane", last: "Doe"};	// Object
var truth = false;	// Boolean
var sheets = ("HTML", "CSS", "JS");	// Array
var a; typeof a;	// Undefined
var a = null; typeof a;	// Null
// Cau true dieu khien:
// If - Else

if ((age > 14) && (age < 19) ) { status = "Eligible"; }
else { status = "Not eligibler"; }

// Switch
switch (new Date().getDayf()) {
    case 6:
        text = "Saturday";
        break;
    case 0:
        text = "Sunday";
        break;
    default:
        Text = "Whatever";
}
// Vong lap:
// For
var sum = 0;
for (var i = 0; i < a.length; i++) {
sum += a[i];
}

 
// While
var i = 1;
while (i < 100) {
i *= 2;
console.log(i + ", ");
}
//Do While
var i = 1;
do {
i *= 2;
console.log(i + ", ");
} while (i < 100);
// Khai bao ham:
function addNumber(a, b) {
return a + b;
}
x = addNumber(5, 6);
// Doi tuong:
var student = {
    firstName: "John",
    lastName: "Doe",
    age: 18,
    height: 170,
    fullName: function() {
        return this.firstName + " " + this.lastName;
    }
};
student.age = 18;
student[age]++;
name = student.fullName();
// Sap xep mang:
var points = (40, 100, 1, 5, 25, 10); 
    points.sort(function(a, b){return a - b}); 
