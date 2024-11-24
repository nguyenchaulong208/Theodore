// Khai báo mảng students với các đối tượng student
var students = [
    {
        firstName: "John",
        lastName: "Doe",
        age: 18,
        height: 170,
        fullName: function () {
            return this.firstName + " " + this.lastName;
        }
    },
    {
        firstName: "Anna",
        lastName: "Smith",
        age: 20,
        height: 165,
        fullName: function () {
            return this.firstName + " " + this.lastName;
        }
    },
    {
        firstName: "Peter",
        lastName: "Johnson",
        age: 19,
        height: 180,
        fullName: function () {
            return this.firstName + " " + this.lastName;
        }
    }
];

// Sắp xếp mảng students tăng dần theo tuổi
students.sort(function (a, b) {
    return a.age - b.age;
});

// Xuất kết quả sau khi sắp xếp
console.log("Danh sách student sau khi sắp xếp theo tuổi tăng dần:");
students.forEach(function (student) {
    console.log(student.fullName() + " - Tuổi: " + student.age + ", Chiều cao: " + student.height + " cm");
});
