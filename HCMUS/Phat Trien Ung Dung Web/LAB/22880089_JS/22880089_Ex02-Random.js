
    function randomSV(min, max) {
      // Phát sinh số ngẫu nhiên trong khoảng [min, max]
      return (Math.random() * (max - min) + min).toFixed(2);  // Sử dụng toFixed(2) để định dạng kết quả với 2 chữ số thập phân
    }
  
  module.exports = randomSV; // Export hàm random để sử dụng ở các file khác