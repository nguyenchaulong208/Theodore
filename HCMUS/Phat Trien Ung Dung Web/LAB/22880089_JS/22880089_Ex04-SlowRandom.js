function slowRandom(min, max, callback) {
  setTimeout(() => {
    const randomValue = (Math.random() * (max - min) + min).toFixed(2);  // Phát sinh giá trị ngẫu nhiên
    callback(randomValue);  // Trả về giá trị qua callback sau 1 giây
  }, 1000);  // Thời gian chờ là 1 giây
}
module.exports = { slowRandom };