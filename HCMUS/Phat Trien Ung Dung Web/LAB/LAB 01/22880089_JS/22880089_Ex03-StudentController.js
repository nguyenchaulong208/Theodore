// Ex03-StudentController.js
const random = require('./22880089_Ex02-Random');  // Import hàm random để sinh điểm ngẫu nhiên

function generate(students) {
  // Phát sinh điểm ngẫu nhiên cho tất cả các môn học của sinh viên
  for (var i = 0; i < students.length; i++) {
      var student = students[i];  // Lấy sinh viên tại chỉ số i
      for (var j = 0; j < student.courses.length; j++) {
          var course = student.courses[j];  // Lấy môn học tại chỉ số j của sinh viên
          course.grade = random(0, 10);  // Gọi hàm phát sinh điểm ngẫu nhiên cho môn học
      }
  }
}

function average(students) {
  // Tính điểm trung bình cho mỗi sinh viên
  for (var i = 0; i < students.length; i++) {
      var student = students[i];  // Lấy sinh viên tại chỉ số i
      var totalGrade = 0;
      for (var j = 0; j < student.courses.length; j++) {
          var course = student.courses[j];  // Lấy môn học tại chỉ số j của sinh viên
          totalGrade += parseFloat(course.grade);  // Cộng dồn điểm
      }
      student.averageGrade = (totalGrade / student.courses.length).toFixed(2);  // Tính trung bình và định dạng với 2 chữ số thập phân
  }
}

function normalize(students) {
  // Định dạng điểm của sinh viên thành số thực có 2 chữ số thập phân
  for (var i = 0; i < students.length; i++) {
      var student = students[i];  // Lấy sinh viên tại chỉ số i
      for (var j = 0; j < student.courses.length; j++) {
          var course = student.courses[j];  // Lấy môn học tại chỉ số j của sinh viên
          course.grade = parseFloat(course.grade).toFixed(2);  // Định dạng điểm với 2 chữ số thập phân
      }
  }
}

// Chạy chương trình chính
if (require.main === module) {
    const students = require('./22880089_Ex01-Main');  // Import danh sách sinh viên từ Ex01-Main

    // 1. Phát sinh điểm ngẫu nhiên cho tất cả sinh viên
    generate(students);

    // 2. Tính điểm trung bình cho mỗi sinh viên
    average(students);

    // 3. Định dạng điểm của sinh viên thành số thực có 2 chữ số thập phân
    normalize(students);

    // Hiển thị thông tin của tất cả sinh viên sau khi xử lý
    console.log(JSON.stringify(students, null, 2));
}

module.exports = { generate, average, normalize };  // Export các hàm để sử dụng ở file khác
