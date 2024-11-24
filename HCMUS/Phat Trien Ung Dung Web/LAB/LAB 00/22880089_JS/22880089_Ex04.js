function average(array) {
    if (array.length === 0) return 0;

    const sum = array.reduce((acc, num) => acc + num, 0);
    return sum / array.length; 
}

console.log(average([0]));
console.log(average([1, 2,3]));
console.log(average([1, 2,3,4]));
console.log(average([1,4,4,4,1]));
console.log(average([-12,-13, 512,1337]));