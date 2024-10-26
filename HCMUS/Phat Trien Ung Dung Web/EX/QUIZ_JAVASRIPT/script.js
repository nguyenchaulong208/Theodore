var points =[1,21,5,2];
points.sort();
console.log(points); // [1, 2, 21, 5]
var str1 = "Hello";
var str2 = "Viet Nam";
var str3 = str1 + str2;
console.log(str3); // HelloViet Nam
//var str4 = str1.join(str2);
//console.log("3" + str4); // Error
console.log("2"+ str1.concat(str2)); // HelloViet Nam
console.log("-----------------");
var fruits = ["banana","organe","lemon","apple","mango"];
var citrus = fruits.slice(3);
console.log(citrus); // ["apple", "mango"]
console.log(fruits); // 
console.log("-----------------");
var number = [45,4,9,16,25];
number.filter(myFunction);
function myFunction(value,index,array){
    return value > 18;
}
console.log(number); // [45, 25]
console.log("-----------------");
var x = 0.2 + 0.1;
console.log(x); // 0.30000000000000004
console.log("-----------------");
var a = null;
if(a == null){
    console.log("a is null");
}
else{
    console.log(-1);
}
console.log("-----------------");
var cars = ["BMW","Volvo","BWM"];
console.log(cars[4]);
console.log("-----------------");
x = 5;
console.log(x);
console.log("-----------------");
var fruits = ["Banana","Orange","Apple","Mango"];
delete fruits[0];
console.log(fruits.length);
console.log(fruits[0]);

console.log("-----------------");
var fruits = ["banana","organe","lemon","apple","mango"];
var citrus = fruits.splice(3);
console.log(citrus); // ["apple", "mango"]
console.log(fruits); // ["banana", "organe", "lemon"]