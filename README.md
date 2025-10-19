//Tải dự án về
B1: tải dự án về

//cấu hình Database mẫu
B2: vào SSM (SQL)
- Phải chuột vào foder "Databases"
- Chọn "Restore Database..."
- Chọn "Device" file QLBH.Bak
- Ok

//kết nối code dự án với Database
B3:
- vao toàn bộ file App.config đổi "data source=Daz_Vo\SQLEXPRESS" thành máy mình (có 3 file giống nhau)
- tương tự đổi data source ở file "DatabaseHelper.cs" (trong QuanLyBanHang.UI)

B4: Chạy dự án
