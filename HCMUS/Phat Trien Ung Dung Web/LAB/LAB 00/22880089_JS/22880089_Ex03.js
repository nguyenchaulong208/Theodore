function printFibonacci(n) {
    let fib = [0, 1]; // Khởi tạo hai số đầu tiên của dãy Fibonacci

    for (let i = 2; i < n; i++) {
        fib.push(fib[i - 1] + fib[i - 2]); // Tính số Fibonacci tiếp theo
    }

    console.log(fib.join(', ')); // In ra các số Fibonacci
}

printFibonacci(30); // In 30 số đầu tiên
