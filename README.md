```markdown
# 🛒 QUẢN LÝ BÁN HÀNG (QLBH)

> **Mô tả:** Hệ thống quản lý bán hàng được xây dựng trên nền tảng **C# WinForms**, sử dụng kiến trúc 3 lớp (3-Layer Architecture) và cơ sở dữ liệu **SQL Server**.

![Language](https://img.shields.io/badge/Language-C%23-blue)
![Platform](https://img.shields.io/badge/Platform-.NET-purple)
![Database](https://img.shields.io/badge/Database-SQL%20Server-red)

## 📂 Cấu trúc Dự án

Dự án được tổ chức theo mô hình 3 lớp để đảm bảo tính bảo trì và mở rộng:

* **QuanLyBanHang.DAL**: Data Access Layer (Truy xuất dữ liệu).
* **QuanLyBanHang.BUS**: Business Logic Layer (Xử lý nghiệp vụ).
* **QuanLyBanHang** (UI): Giao diện người dùng chính.
* **SQLQuery_QLBH.sql**: Script khởi tạo cơ sở dữ liệu.

---

## 🚀 Hướng dẫn Cài đặt & Thiết lập

Làm theo các bước sau để chạy dự án trên máy của bạn:

### Bước 1: Tải dự án
Clone repository này về máy hoặc tải xuống dưới dạng file ZIP và giải nén.

```bash
git clone [https://github.com/Daz-Vo/QLBH.git](https://github.com/Daz-Vo/QLBH.git)

```

### Bước 2: Khởi tạo Cơ sở dữ liệu (Database)

1. Mở **SQL Server Management Studio (SSMS)**.
2. Mở file `SQLQuery_QLBH.sql` (nằm trong thư mục gốc của dự án).
3. Nhấn **Execute (F5)** để chạy lệnh tạo Database và dữ liệu mẫu.

### Bước 3: Cấu hình Kết nối

Bạn cần cập nhật chuỗi kết nối (Connection String) để trỏ đúng về SQL Server trên máy bạn.

**1. Cập nhật file `App.config`:**
Tìm tất cả các file `App.config` trong solution và thay đổi đoạn `data source`:

```xml
data source=TEN_MAY_CUA_BAN\SQLEXPRESS;initial catalog=QLBH;integrated security=True

```

*(Thay `TEN_MAY_CUA_BAN\SQLEXPRESS` bằng tên Server Name của bạn).*

**2. Cập nhật file `DatabaseHelper.cs`:**

* Truy cập vào thư mục `QuanLyBanHang` (UI).
* Tìm file `DatabaseHelper.cs`.
* Sửa biến `connectionString` tương tự như trên.

---

## 📖 Hướng dẫn Sử dụng

### 1. Đăng ký & Đăng nhập

* Chạy dự án (nhấn Start trong Visual Studio).
* Tại màn hình đăng nhập, chọn **Đăng ký** để tạo tài khoản mới.
* Tiến hành đăng nhập với tài khoản vừa tạo.

### 2. Thiết lập Quyền Admin (Quan trọng)

Mặc định khi đăng ký mới, tài khoản sẽ là **User thường**. Để truy cập các tính năng quản lý (Admin), bạn cần cấp quyền thủ công trong Database:

1. Mở **SSMS**, tìm đến bảng `Users` trong database `QLBH`.
2. Tìm dòng chứa tài khoản bạn vừa tạo.
3. Sửa cột **`authority`**:
* `0`: **User thường** (Chỉ có thể mua hàng).
* `1`: **Admin** (Quản lý sản phẩm, đơn hàng, thống kê...).


4. Lưu lại và đăng nhập lại vào phần mềm.

---

## 🛠 Công nghệ sử dụng

* **IDE**: Visual Studio.
* **Ngôn ngữ**: C# (.NET Framework).
* **CSDL**: Microsoft SQL Server.

---


