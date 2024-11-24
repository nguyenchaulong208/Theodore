// Định nghĩa mảng danh sách sinh viên
let students = [
    {
        studentId: "SV001",  // Mã số sinh viên
        fullName: "Nguyễn Văn A",  // Họ tên sinh viên
        courses: [  // Mảng môn học
            { courseName: "Toán", grade: 0 },  // Môn Toán, điểm 0
            { courseName: "Lý", grade: 0 },    // Môn Lý, điểm 0
            { courseName: "Hóa", grade: 0 }    // Môn Hóa, điểm 0
        ]
    },
    {
        studentId: "SV002",
        fullName: "Trần Thị B",
        courses: [
            { courseName: "Toán", grade: 0 },
            { courseName: "Lý", grade: 0 },
            { courseName: "Hóa", grade: 0 }
        ]
    },
    {
        studentId: "SV003",
        fullName: "Lê Minh C",
        courses: [
            { courseName: "Toán", grade: 0 },
            { courseName: "Lý", grade: 0 },
            { courseName: "Hóa", grade: 0 }
        ]
    }
];

// Sử dụng JSON.stringify để xuất thông tin ra màn hình
// console.log(JSON.stringify(students, null, 2));  // null, 2 để in ra với định dạng đẹp

module.exports = students;
