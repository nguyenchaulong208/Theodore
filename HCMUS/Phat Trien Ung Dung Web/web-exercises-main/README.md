# Web-Exercises

## Hướng dẫn sử dụng

- **Cài đặt Node.js và npm**  
  Tải về từ trang chủ: [Node.js Download](https://nodejs.org/en/download/prebuilt-installer)

- **Cài đặt npx**

```bash
  npm install -g npx
```

- **Cài đặt các thư viện cần thiết cho từng bài tập**
  ```bash
  cd Thu_muc_bai_tap
  npm install
  ```
- **Đối với các bài tập có sử dụng CSDL Postgres**
- Cài đặt CSDL Postgres:[Postgresql Download] https://www.postgresql.org/download/
- Cài đặt công cụ quản trị CSDL DBeaver: [DBeaver Download]https://dbeaver.io/download/
- Sử dụng DBeaver kết nối đến CSDL Postgres và tạo 1 CSDL mới
- Cập nhật thông tin kết nối đến cơ sở dữ liệu trong tập tin `config/config.json` như sau:

```json
"development": {
  "username": "postgres_username",
  "password": "postgres_pasword",
  "database": "postgres_database",
  "host": "127.0.0.1",
  "dialect": "postgres",
  "port": 5432
}
```

- Chạy các lệnh tạo các bảng dữ liệu và dữ liệu mẫu

```bash
  cd Thu_muc_bai_tap
  node db
  npx sequelize-cli db:seed:all
```

## Yêu cầu bài tập

**1. Bootstrap-Ecommerce-Template**  
 Tạo template web tĩnh cho trang EShop.

**2. DOM-Exercise**

- **Index.html**: Thêm sự kiện Click cho button, hiển thị thông tin MSSV và Họ tên trong cửa sổ thông báo alert và trong thẻ `div#message`.
- **Ex01, Ex02**: Thay đổi icon khi người dùng di chuột vào (`mouseover`) hoặc ra khỏi (`mouseout`) (sử dụng các hình `icon-active` và `icon` trong thư mục images).
- **Ex03**: Cho phép chọn/bỏ chọn tất cả các checkbox trên trang.
- **Ex04**: Thêm chức năng ẩn/hiện mật khẩu và xác thực `Password` với `Confirm Password`.
- **Ex05**: Lọc và chỉ hiển thị các mục trong danh sách chứa từ khóa mà người dùng nhập.
- **Ex06**: Thêm một mục vào danh sách theo nội dung người dùng nhập.
- **Ex07**: Xóa một mục khỏi danh sách, có hỏi xác nhận trước khi xóa.
- **Ex08**: Chọn và thay đổi nội dung của một mục trong danh sách.
- **Ex09**: Lưu trạng thái của danh sách vào `localStorage`. Xóa tất cả các mục trong danh sách, có hỏi xác nhận trước khi xóa.
- **Ex10**: Lấy dữ liệu từ `reqres.in` và hiển thị trên trang, bao gồm chức năng phân trang.

**3. Express-Handlebars-Exercise**  
Xây dựng một ứng dụng web đơn giản bằng Express, chuyển template web tĩnh thành web động, với dữ liệu từ `data.js`.

- **Task 1: Inspiring Quotes**  
  Hiển thị danh sách cảm xúc; khi người dùng chọn cảm xúc, hiển thị ảnh quote tương ứng (mặc định hiển thị `default.jpg`).

- **Task 2: Jars Saving**  
  Cho phép người dùng nhập số tiền lương và hiển thị số tiền tương ứng phân bổ vào các “jars”.

- **Task 3: TV Sales**  
  Hiển thị danh sách `categories` và `products`. Cho phép người dùng chọn một `category` và hiển thị các sản phẩm thuộc danh mục đó (mặc định hiển thị tất cả sản phẩm).

- **Task 4: Zodiac Characteristics**  
  Hiển thị danh sách các cung hoàng đạo (zodiac); cho phép người dùng chọn và xem thông tin chi tiết của từng cung hoàng đạo.

**4. Sequelize-Postgres-Exercise**  
Xây dựng ứng dụng web động kết nối với cơ sở dữ liệu PostgreSQL với các chức năng chính:

- Hiển thị danh sách các `categories`
- Hiển thị danh sách các `tags`
- Lựa chọn một `category` để hiển thị `blogs` thuộc danh mục đó (mặc định hiển thị tất cả `blogs`)
- Lựa chọn một `tag` để hiển thị `blogs` liên quan (mặc định hiển thị tất cả `blogs`)
- Phân trang danh sách `blogs`, với mỗi trang hiển thị tối đa 2 `blogs`
- Xem chi tiết một `blog`
- Tìm kiếm `blogs` theo từ khóa trong title, summary, hoặc description

**5. CRUD-Exercise**  
Xây dựng một ứng dụng web quản lý tài khoản người dùng với các chức năng chính:

- Thêm người dùng mới
- Cập nhật thông tin người dùng
- Xóa người dùng
- Tìm kiếm người dùng
- Phân trang danh sách người dùng

**6. Authenticate-Exercise**
Xây dựng một ứng dụng web có các chức năng chính:

- Đăng ký tài khoản
- Đăng nhập
- Nhớ mật khẩu sau khi đăng nhập thành công
- Đăng xuất
- Phân quyền chỉ cho phép người dùng xem dashboard và thông tin tài khoản khi đã đăng nhập
  Các chức năng khác:
- Cập nhật thông tin tài khoản, cho phép upload hình đại diện
- Thay đổi mật khẩu
- Quên mật khẩu (gửi qua email)
