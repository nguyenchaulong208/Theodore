const { slowRandom } = require('./22880089_Ex04-SlowRandom');  // Import hàm slowRandom từ Ex04-SlowRandom
const students = require('./22880089_Ex01-Main');  // Import danh sách sinh viên từ Ex01-Main

// Hàm phát sinh điểm ngẫu nhiên cho tất cả sinh viên
function generate(students, callback) {
  let count = 0;  // Đếm số lần hoàn thành phát sinh điểm

  // Sử dụng Promise.all để đợi tất cả điểm được phát sinh
  const promises = [];

  for (let i = 0; i < students.length; i++) {
    let student = students[i];
    for (let j = 0; j < student.courses.length; j++) {  // Sửa từ subjects thành courses
      let course = student.courses[j];  // Sửa từ subjects thành courses

      // Tạo Promise cho từng môn học và thêm vào mảng promises
      const promise = new Promise((resolve) => {
        slowRandom(5, 10, function(score) {
          course.grade = score;  // Cập nhật điểm môn học (sửa grade)
          resolve();
        });
      });
      promises.push(promise);
    }
  }

  // Sau khi tất cả các Promise đã hoàn thành, gọi callback
  Promise.all(promises).then(() => {
    callback();
  });
}

// Hàm tính điểm trung bình cho mỗi sinh viên
function average(students) {
  for (let i = 0; i < students.length; i++) {
    let student = students[i];
    let totalScore = 0;
    let courseCount = student.courses.length;  // Sửa từ subjects thành courses

    // Tính tổng điểm của sinh viên
    for (let j = 0; j < student.courses.length; j++) {  // Sửa từ subjects thành courses
      let course = student.courses[j];  // Sửa từ subjects thành courses
      totalScore += parseFloat(course.grade);  // Chuyển điểm sang số thực và tính tổng
    }

    // Tính điểm trung bình và thêm vào đối tượng sinh viên
    student.average = (totalScore / courseCount).toFixed(2);
  }
}

// Hàm định dạng điểm của mỗi sinh viên với 2 chữ số thập phân
function normalize(students) {
  for (let i = 0; i < students.length; i++) {
    let student = students[i];
    for (let j = 0; j < student.courses.length; j++) {  // Sửa từ subjects thành courses
      let course = student.courses[j];  // Sửa từ subjects thành courses
      course.grade = parseFloat(course.grade).toFixed(2);  // Định dạng điểm
    }
  }
}

// Hàm thực thi tất cả các bước: generate, average, normalize và hiển thị kết quả
function execute() {
  // Kiểm tra lại xem students có dữ liệu không trước khi thực thi
  if (students.length === 0) {
    console.log('No students data found.');
    return;
  }

  generate(students, function() {
    average(students);
    normalize(students);
    
    // Hiển thị kết quả sinh viên sau khi xử lý
    console.log('Processed student data:', JSON.stringify(students, null, 2));
  });
}

// Gọi hàm execute để thực hiện tất cả các bước: generate, average, normalize và hiển thị kết quả
execute();
