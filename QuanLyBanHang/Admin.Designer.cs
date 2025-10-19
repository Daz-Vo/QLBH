using System.Windows.Forms;

namespace QuanLyBanHang
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        // PHẦN 1: Khai báo và khởi tạo - Copy toàn bộ phần này
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabQuanLyTaiKhoan = new System.Windows.Forms.TabPage();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTim_SDT = new System.Windows.Forms.TextBox();
            this.txtPhone_Number = new System.Windows.Forms.TextBox();
            this.txtFull_Name = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.clfull_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clusername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clphone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabQuanLySanPham = new System.Windows.Forms.TabPage();
            this.pbImage_url = new System.Windows.Forms.PictureBox();
            this.txtMauSP = new System.Windows.Forms.ComboBox();
            this.txtSoLuongSP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGiaSP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMoTaSP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaVachSP = new System.Windows.Forms.TextBox();
            this.txtLinkAnhSP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemCapNhatSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.clbarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcategory_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clproduct_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clstock_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image_url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabQuanLyDonHang = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvOrder_Items = new System.Windows.Forms.DataGridView();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.cbTrangThaiDH = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btnCapNhatDH = new System.Windows.Forms.Button();
            this.btnXoaDH = new System.Windows.Forms.Button();
            this.btnLoadALL = new System.Windows.Forms.Button();
            this.btnTimDH = new System.Windows.Forms.Button();
            this.txtTimDH = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.dgvDSDH = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipping_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageReport = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.rpBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabQuanLyTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.tabQuanLySanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage_url)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabQuanLyDonHang.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDH)).BeginInit();
            this.tabPageReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQuanLyTaiKhoan
            // 
            this.tabQuanLyTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tabQuanLyTaiKhoan.Controls.Add(this.btnXoa);
            this.tabQuanLyTaiKhoan.Controls.Add(this.label8);
            this.tabQuanLyTaiKhoan.Controls.Add(this.btnTimKiem);
            this.tabQuanLyTaiKhoan.Controls.Add(this.btnThemLuu);
            this.tabQuanLyTaiKhoan.Controls.Add(this.label1);
            this.tabQuanLyTaiKhoan.Controls.Add(this.txtAddress);
            this.tabQuanLyTaiKhoan.Controls.Add(this.txtEmail);
            this.tabQuanLyTaiKhoan.Controls.Add(this.txtTim_SDT);
            this.tabQuanLyTaiKhoan.Controls.Add(this.txtPhone_Number);
            this.tabQuanLyTaiKhoan.Controls.Add(this.txtFull_Name);
            this.tabQuanLyTaiKhoan.Controls.Add(this.txtPassWord);
            this.tabQuanLyTaiKhoan.Controls.Add(this.txtUserName);
            this.tabQuanLyTaiKhoan.Controls.Add(this.label7);
            this.tabQuanLyTaiKhoan.Controls.Add(this.label9);
            this.tabQuanLyTaiKhoan.Controls.Add(this.label6);
            this.tabQuanLyTaiKhoan.Controls.Add(this.label5);
            this.tabQuanLyTaiKhoan.Controls.Add(this.label4);
            this.tabQuanLyTaiKhoan.Controls.Add(this.label3);
            this.tabQuanLyTaiKhoan.Controls.Add(this.label2);
            this.tabQuanLyTaiKhoan.Controls.Add(this.dgvTaiKhoan);
            this.tabQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuanLyTaiKhoan.Location = new System.Drawing.Point(4, 34);
            this.tabQuanLyTaiKhoan.Name = "tabQuanLyTaiKhoan";
            this.tabQuanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(15);
            this.tabQuanLyTaiKhoan.Size = new System.Drawing.Size(1212, 623);
            this.tabQuanLyTaiKhoan.TabIndex = 2;
            this.tabQuanLyTaiKhoan.Text = "👥 Quản lý tài khoản";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1094, 565);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 42);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "🗑 Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label8.Location = new System.Drawing.Point(570, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "🔍 TÌM TÀI KHOẢN";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(1090, 58);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 38);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemLuu
            // 
            this.btnThemLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemLuu.FlatAppearance.BorderSize = 0;
            this.btnThemLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemLuu.ForeColor = System.Drawing.Color.White;
            this.btnThemLuu.Location = new System.Drawing.Point(949, 565);
            this.btnThemLuu.Name = "btnThemLuu";
            this.btnThemLuu.Size = new System.Drawing.Size(135, 42);
            this.btnThemLuu.TabIndex = 1;
            this.btnThemLuu.Text = "💾 Thêm/Lưu";
            this.btnThemLuu.UseVisualStyleBackColor = false;
            this.btnThemLuu.Click += new System.EventHandler(this.btnThemLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(570, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "📋 THÔNG TIN TÀI KHOẢN";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.Location = new System.Drawing.Point(714, 510);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(476, 27);
            this.txtAddress.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEmail.Location = new System.Drawing.Point(714, 468);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(476, 27);
            this.txtEmail.TabIndex = 17;
            // 
            // txtTim_SDT
            // 
            this.txtTim_SDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTim_SDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTim_SDT.Location = new System.Drawing.Point(574, 61);
            this.txtTim_SDT.Name = "txtTim_SDT";
            this.txtTim_SDT.Size = new System.Drawing.Size(505, 27);
            this.txtTim_SDT.TabIndex = 16;
            // 
            // txtPhone_Number
            // 
            this.txtPhone_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone_Number.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPhone_Number.Location = new System.Drawing.Point(714, 426);
            this.txtPhone_Number.Name = "txtPhone_Number";
            this.txtPhone_Number.Size = new System.Drawing.Size(476, 27);
            this.txtPhone_Number.TabIndex = 16;
            // 
            // txtFull_Name
            // 
            this.txtFull_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFull_Name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFull_Name.Location = new System.Drawing.Point(714, 384);
            this.txtFull_Name.Name = "txtFull_Name";
            this.txtFull_Name.Size = new System.Drawing.Size(476, 27);
            this.txtFull_Name.TabIndex = 15;
            // 
            // txtPassWord
            // 
            this.txtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassWord.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassWord.Location = new System.Drawing.Point(714, 342);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(476, 27);
            this.txtPassWord.TabIndex = 14;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUserName.Location = new System.Drawing.Point(714, 298);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(476, 27);
            this.txtUserName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(574, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "📍 Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label9.Location = new System.Drawing.Point(574, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 19);
            this.label9.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label6.Location = new System.Drawing.Point(574, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "✉ Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(574, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "📞 Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(574, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "👤 Họ tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(574, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "🔒 Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(574, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "🔑 Tên đăng nhập:";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaiKhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvTaiKhoan.ColumnHeadersHeight = 50;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clfull_name,
            this.clusername,
            this.clpassword,
            this.clphone_number});
            this.dgvTaiKhoan.EnableHeadersVisualStyles = false;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvTaiKhoan.Location = new System.Drawing.Point(18, 3);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.RowHeadersVisible = false;
            this.dgvTaiKhoan.RowTemplate.Height = 40;
            this.dgvTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(550, 604);
            this.dgvTaiKhoan.TabIndex = 1;
            // 
            // clfull_name
            // 
            this.clfull_name.DataPropertyName = "full_name";
            this.clfull_name.HeaderText = "HỌ TÊN";
            this.clfull_name.Name = "clfull_name";
            this.clfull_name.ReadOnly = true;
            this.clfull_name.Width = 155;
            // 
            // clusername
            // 
            this.clusername.DataPropertyName = "username";
            this.clusername.HeaderText = "TÀI KHOẢN";
            this.clusername.Name = "clusername";
            this.clusername.ReadOnly = true;
            this.clusername.Width = 125;
            // 
            // clpassword
            // 
            this.clpassword.DataPropertyName = "password";
            this.clpassword.HeaderText = "MẬT KHẨU";
            this.clpassword.Name = "clpassword";
            this.clpassword.ReadOnly = true;
            this.clpassword.Width = 120;
            // 
            // clphone_number
            // 
            this.clphone_number.DataPropertyName = "phone_number";
            this.clphone_number.HeaderText = "SỐ ĐIỆN THOẠI";
            this.clphone_number.Name = "clphone_number";
            this.clphone_number.ReadOnly = true;
            this.clphone_number.Width = 130;
            // 
            // tabQuanLySanPham
            // 
            this.tabQuanLySanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tabQuanLySanPham.Controls.Add(this.pbImage_url);
            this.tabQuanLySanPham.Controls.Add(this.txtMauSP);
            this.tabQuanLySanPham.Controls.Add(this.txtSoLuongSP);
            this.tabQuanLySanPham.Controls.Add(this.label14);
            this.tabQuanLySanPham.Controls.Add(this.txtGiaSP);
            this.tabQuanLySanPham.Controls.Add(this.label13);
            this.tabQuanLySanPham.Controls.Add(this.txtMoTaSP);
            this.tabQuanLySanPham.Controls.Add(this.label12);
            this.tabQuanLySanPham.Controls.Add(this.txtMaVachSP);
            this.tabQuanLySanPham.Controls.Add(this.txtLinkAnhSP);
            this.tabQuanLySanPham.Controls.Add(this.label17);
            this.tabQuanLySanPham.Controls.Add(this.txtTenSP);
            this.tabQuanLySanPham.Controls.Add(this.label16);
            this.tabQuanLySanPham.Controls.Add(this.label15);
            this.tabQuanLySanPham.Controls.Add(this.label11);
            this.tabQuanLySanPham.Controls.Add(this.btnTimSP);
            this.tabQuanLySanPham.Controls.Add(this.txtTimSP);
            this.tabQuanLySanPham.Controls.Add(this.label10);
            this.tabQuanLySanPham.Controls.Add(this.btnThemCapNhatSP);
            this.tabQuanLySanPham.Controls.Add(this.btnXoaSP);
            this.tabQuanLySanPham.Controls.Add(this.dgvDSSP);
            this.tabQuanLySanPham.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuanLySanPham.Location = new System.Drawing.Point(4, 34);
            this.tabQuanLySanPham.Name = "tabQuanLySanPham";
            this.tabQuanLySanPham.Padding = new System.Windows.Forms.Padding(15);
            this.tabQuanLySanPham.Size = new System.Drawing.Size(1212, 623);
            this.tabQuanLySanPham.TabIndex = 0;
            this.tabQuanLySanPham.Text = "📦 Quản lý sản phẩm";
            // 
            // pbImage_url
            // 
            this.pbImage_url.BackColor = System.Drawing.Color.White;
            this.pbImage_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage_url.InitialImage = null;
            this.pbImage_url.Location = new System.Drawing.Point(1054, 424);
            this.pbImage_url.Name = "pbImage_url";
            this.pbImage_url.Size = new System.Drawing.Size(140, 130);
            this.pbImage_url.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage_url.TabIndex = 28;
            this.pbImage_url.TabStop = false;
            // 
            // txtMauSP
            // 
            this.txtMauSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMauSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMauSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMauSP.FormattingEnabled = true;
            this.txtMauSP.Items.AddRange(new object[] {
            "Điện thoại",
            "Tai nghe",
            "Linh kiện"});
            this.txtMauSP.Location = new System.Drawing.Point(155, 548);
            this.txtMauSP.Name = "txtMauSP";
            this.txtMauSP.Size = new System.Drawing.Size(150, 28);
            this.txtMauSP.TabIndex = 27;
            // 
            // txtSoLuongSP
            // 
            this.txtSoLuongSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSoLuongSP.Location = new System.Drawing.Point(405, 548);
            this.txtSoLuongSP.Name = "txtSoLuongSP";
            this.txtSoLuongSP.Size = new System.Drawing.Size(90, 27);
            this.txtSoLuongSP.TabIndex = 26;
            this.txtSoLuongSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label14.Location = new System.Drawing.Point(320, 552);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 19);
            this.label14.TabIndex = 25;
            this.label14.Text = "Số lượng:";
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGiaSP.Location = new System.Drawing.Point(405, 583);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(150, 27);
            this.txtGiaSP.TabIndex = 26;
            this.txtGiaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label13.Location = new System.Drawing.Point(325, 587);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "💰 Giá:";
            // 
            // txtMoTaSP
            // 
            this.txtMoTaSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTaSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMoTaSP.Location = new System.Drawing.Point(762, 473);
            this.txtMoTaSP.Multiline = true;
            this.txtMoTaSP.Name = "txtMoTaSP";
            this.txtMoTaSP.Size = new System.Drawing.Size(286, 143);
            this.txtMoTaSP.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label12.Location = new System.Drawing.Point(758, 451);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "📝 Mô tả:";
            // 
            // txtMaVachSP
            // 
            this.txtMaVachSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaVachSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaVachSP.Location = new System.Drawing.Point(115, 583);
            this.txtMaVachSP.Name = "txtMaVachSP";
            this.txtMaVachSP.Size = new System.Drawing.Size(170, 27);
            this.txtMaVachSP.TabIndex = 26;
            // 
            // txtLinkAnhSP
            // 
            this.txtLinkAnhSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLinkAnhSP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLinkAnhSP.Location = new System.Drawing.Point(115, 511);
            this.txtLinkAnhSP.Name = "txtLinkAnhSP";
            this.txtLinkAnhSP.Size = new System.Drawing.Size(625, 25);
            this.txtLinkAnhSP.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label17.Location = new System.Drawing.Point(20, 587);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 19);
            this.label17.TabIndex = 25;
            this.label17.Text = "🏷 Mã vạch:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenSP.Location = new System.Drawing.Point(115, 473);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(625, 27);
            this.txtTenSP.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label16.Location = new System.Drawing.Point(20, 514);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 19);
            this.label16.TabIndex = 25;
            this.label16.Text = "🖼 Link ảnh:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label15.Location = new System.Drawing.Point(20, 552);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 19);
            this.label15.TabIndex = 25;
            this.label15.Text = "📂 Loại sản phẩm:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label11.Location = new System.Drawing.Point(20, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "🏷 Tên SP:";
            // 
            // btnTimSP
            // 
            this.btnTimSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnTimSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimSP.FlatAppearance.BorderSize = 0;
            this.btnTimSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimSP.ForeColor = System.Drawing.Color.White;
            this.btnTimSP.Location = new System.Drawing.Point(620, 432);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(100, 38);
            this.btnTimSP.TabIndex = 24;
            this.btnTimSP.Text = "🔍 Tìm";
            this.btnTimSP.UseVisualStyleBackColor = false;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // txtTimSP
            // 
            this.txtTimSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimSP.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTimSP.Location = new System.Drawing.Point(308, 436);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(302, 27);
            this.txtTimSP.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label10.Location = new System.Drawing.Point(20, 439);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "🔍 TÌM SẢN PHẨM BẰNG MÃ VẠCH";
            // 
            // btnThemCapNhatSP
            // 
            this.btnThemCapNhatSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnThemCapNhatSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCapNhatSP.FlatAppearance.BorderSize = 0;
            this.btnThemCapNhatSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCapNhatSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThemCapNhatSP.ForeColor = System.Drawing.Color.White;
            this.btnThemCapNhatSP.Location = new System.Drawing.Point(585, 568);
            this.btnThemCapNhatSP.Name = "btnThemCapNhatSP";
            this.btnThemCapNhatSP.Size = new System.Drawing.Size(155, 42);
            this.btnThemCapNhatSP.TabIndex = 3;
            this.btnThemCapNhatSP.Text = "💾 Thêm/Cập nhật";
            this.btnThemCapNhatSP.UseVisualStyleBackColor = false;
            this.btnThemCapNhatSP.Click += new System.EventHandler(this.btnThemCapNhatSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaSP.FlatAppearance.BorderSize = 0;
            this.btnXoaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaSP.ForeColor = System.Drawing.Color.White;
            this.btnXoaSP.Location = new System.Drawing.Point(1094, 566);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(100, 42);
            this.btnXoaSP.TabIndex = 3;
            this.btnXoaSP.Text = "🗑 Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = false;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.AllowUserToAddRows = false;
            this.dgvDSSP.AllowUserToDeleteRows = false;
            this.dgvDSSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvDSSP.ColumnHeadersHeight = 50;
            this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clbarcode,
            this.clcategory_id,
            this.clproduct_name,
            this.cldescription,
            this.clprice,
            this.clstock_quantity,
            this.image_url});
            this.dgvDSSP.EnableHeadersVisualStyles = false;
            this.dgvDSSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvDSSP.Location = new System.Drawing.Point(17, 3);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.ReadOnly = true;
            this.dgvDSSP.RowHeadersVisible = false;
            this.dgvDSSP.RowTemplate.Height = 40;
            this.dgvDSSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSP.ShowCellErrors = false;
            this.dgvDSSP.Size = new System.Drawing.Size(1192, 405);
            this.dgvDSSP.TabIndex = 2;
            // 
            // clbarcode
            // 
            this.clbarcode.DataPropertyName = "barcode";
            this.clbarcode.HeaderText = "MÃ VẠCH";
            this.clbarcode.Name = "clbarcode";
            this.clbarcode.ReadOnly = true;
            this.clbarcode.Width = 110;
            // 
            // clcategory_id
            // 
            this.clcategory_id.DataPropertyName = "category_id";
            this.clcategory_id.HeaderText = "LOẠI SP";
            this.clcategory_id.Name = "clcategory_id";
            this.clcategory_id.ReadOnly = true;
            this.clcategory_id.Width = 90;
            // 
            // clproduct_name
            // 
            this.clproduct_name.DataPropertyName = "product_name";
            this.clproduct_name.HeaderText = "TÊN SẢN PHẨM";
            this.clproduct_name.Name = "clproduct_name";
            this.clproduct_name.ReadOnly = true;
            this.clproduct_name.Width = 220;
            // 
            // cldescription
            // 
            this.cldescription.DataPropertyName = "description";
            this.cldescription.HeaderText = "MÔ TẢ";
            this.cldescription.Name = "cldescription";
            this.cldescription.ReadOnly = true;
            this.cldescription.Width = 350;
            // 
            // clprice
            // 
            this.clprice.DataPropertyName = "price";
            this.clprice.HeaderText = "GIÁ THÀNH";
            this.clprice.Name = "clprice";
            this.clprice.ReadOnly = true;
            this.clprice.Width = 130;
            // 
            // clstock_quantity
            // 
            this.clstock_quantity.DataPropertyName = "stock_quantity";
            this.clstock_quantity.HeaderText = "SỐ LƯỢNG";
            this.clstock_quantity.Name = "clstock_quantity";
            this.clstock_quantity.ReadOnly = true;
            this.clstock_quantity.Width = 90;
            // 
            // image_url
            // 
            this.image_url.DataPropertyName = "image_url";
            this.image_url.HeaderText = "LINK HÌNH ẢNH";
            this.image_url.Name = "image_url";
            this.image_url.ReadOnly = true;
            this.image_url.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image_url.Width = 180;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabQuanLySanPham);
            this.tabControl1.Controls.Add(this.tabQuanLyDonHang);
            this.tabControl1.Controls.Add(this.tabQuanLyTaiKhoan);
            this.tabControl1.Controls.Add(this.tabPageReport);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1220, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabQuanLyDonHang
            // 
            this.tabQuanLyDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tabQuanLyDonHang.Controls.Add(this.panel1);
            this.tabQuanLyDonHang.Controls.Add(this.btnLoadALL);
            this.tabQuanLyDonHang.Controls.Add(this.btnTimDH);
            this.tabQuanLyDonHang.Controls.Add(this.txtTimDH);
            this.tabQuanLyDonHang.Controls.Add(this.label26);
            this.tabQuanLyDonHang.Controls.Add(this.dgvDSDH);
            this.tabQuanLyDonHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQuanLyDonHang.Location = new System.Drawing.Point(4, 34);
            this.tabQuanLyDonHang.Name = "tabQuanLyDonHang";
            this.tabQuanLyDonHang.Padding = new System.Windows.Forms.Padding(15);
            this.tabQuanLyDonHang.Size = new System.Drawing.Size(1212, 623);
            this.tabQuanLyDonHang.TabIndex = 1;
            this.tabQuanLyDonHang.Text = "🛒 Quản lý đơn hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtMaDH);
            this.panel1.Controls.Add(this.cbTrangThaiDH);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.btnCapNhatDH);
            this.panel1.Controls.Add(this.btnXoaDH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(15, 451);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1182, 157);
            this.panel1.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label21.Location = new System.Drawing.Point(13, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 19);
            this.label21.TabIndex = 60;
            this.label21.Text = "📦 Chi tiết đơn hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvOrder_Items);
            this.panel2.Location = new System.Drawing.Point(13, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 126);
            this.panel2.TabIndex = 59;
            // 
            // dgvOrder_Items
            // 
            this.dgvOrder_Items.AllowUserToAddRows = false;
            this.dgvOrder_Items.AllowUserToDeleteRows = false;
            this.dgvOrder_Items.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrder_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrder_Items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrder_Items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder_Items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvOrder_Items.ColumnHeadersHeight = 32;
            this.dgvOrder_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSP,
            this.colSoLuong,
            this.colGia,
            this.colThanhTien});
            this.dgvOrder_Items.EnableHeadersVisualStyles = false;
            this.dgvOrder_Items.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvOrder_Items.Location = new System.Drawing.Point(2, 2);
            this.dgvOrder_Items.Name = "dgvOrder_Items";
            this.dgvOrder_Items.ReadOnly = true;
            this.dgvOrder_Items.RowHeadersVisible = false;
            this.dgvOrder_Items.RowTemplate.Height = 28;
            this.dgvOrder_Items.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrder_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder_Items.Size = new System.Drawing.Size(524, 115);
            this.dgvOrder_Items.TabIndex = 0;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colTenSP.DefaultCellStyle = dataGridViewCellStyle28;
            this.colTenSP.HeaderText = "Tên Sản Phẩm";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            this.colTenSP.Width = 230;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle29;
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            this.colSoLuong.Width = 45;
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "GiaDonVi";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle30.Format = "N0";
            this.colGia.DefaultCellStyle = dataGridViewCellStyle30;
            this.colGia.HeaderText = "Giá Đơn Vị";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            this.colGia.Width = 110;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle31.Format = "N0";
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle31;
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 135;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label20.Location = new System.Drawing.Point(674, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(127, 19);
            this.label20.TabIndex = 57;
            this.label20.Text = "Cần cập nhật / xóa:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label19.Location = new System.Drawing.Point(674, 88);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 19);
            this.label19.TabIndex = 55;
            this.label19.Text = "Mã đơn hàng:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label18.Location = new System.Drawing.Point(674, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(343, 20);
            this.label18.TabIndex = 53;
            this.label18.Text = "⚙ CẬP NHẬT TRẠNG THÁI / XÓA ĐƠN HÀNG";
            // 
            // txtMaDH
            // 
            this.txtMaDH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDH.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaDH.Location = new System.Drawing.Point(784, 86);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(130, 27);
            this.txtMaDH.TabIndex = 54;
            // 
            // cbTrangThaiDH
            // 
            this.cbTrangThaiDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThaiDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTrangThaiDH.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbTrangThaiDH.FormattingEnabled = true;
            this.cbTrangThaiDH.Items.AddRange(new object[] {
            "Đang đóng hàng",
            "Đang trên đường vận chuyển",
            "Đang giao hàng"});
            this.cbTrangThaiDH.Location = new System.Drawing.Point(941, 85);
            this.cbTrangThaiDH.Name = "cbTrangThaiDH";
            this.cbTrangThaiDH.Size = new System.Drawing.Size(220, 28);
            this.cbTrangThaiDH.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label23.Location = new System.Drawing.Point(937, 63);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(136, 19);
            this.label23.TabIndex = 38;
            this.label23.Text = "Trạng thái đơn hàng:";
            // 
            // btnCapNhatDH
            // 
            this.btnCapNhatDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnCapNhatDH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatDH.FlatAppearance.BorderSize = 0;
            this.btnCapNhatDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatDH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCapNhatDH.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatDH.Location = new System.Drawing.Point(1061, 118);
            this.btnCapNhatDH.Name = "btnCapNhatDH";
            this.btnCapNhatDH.Size = new System.Drawing.Size(100, 35);
            this.btnCapNhatDH.TabIndex = 30;
            this.btnCapNhatDH.Text = "✓ Cập nhật";
            this.btnCapNhatDH.UseVisualStyleBackColor = false;
            this.btnCapNhatDH.Click += new System.EventHandler(this.btnCapNhatDH_Click);
            // 
            // btnXoaDH
            // 
            this.btnXoaDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnXoaDH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDH.FlatAppearance.BorderSize = 0;
            this.btnXoaDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoaDH.ForeColor = System.Drawing.Color.White;
            this.btnXoaDH.Location = new System.Drawing.Point(955, 119);
            this.btnXoaDH.Name = "btnXoaDH";
            this.btnXoaDH.Size = new System.Drawing.Size(100, 35);
            this.btnXoaDH.TabIndex = 29;
            this.btnXoaDH.Text = "🗑 Xóa";
            this.btnXoaDH.UseVisualStyleBackColor = false;
            this.btnXoaDH.Click += new System.EventHandler(this.btnXoaDH_Click);
            // 
            // btnLoadALL
            // 
            this.btnLoadALL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLoadALL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadALL.FlatAppearance.BorderSize = 0;
            this.btnLoadALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadALL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadALL.ForeColor = System.Drawing.Color.White;
            this.btnLoadALL.Location = new System.Drawing.Point(1105, 8);
            this.btnLoadALL.Name = "btnLoadALL";
            this.btnLoadALL.Size = new System.Drawing.Size(90, 35);
            this.btnLoadALL.TabIndex = 52;
            this.btnLoadALL.Text = "🔄 Tải lại";
            this.btnLoadALL.UseVisualStyleBackColor = false;
            this.btnLoadALL.Click += new System.EventHandler(this.btnLoadALL_Click);
            // 
            // btnTimDH
            // 
            this.btnTimDH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnTimDH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimDH.FlatAppearance.BorderSize = 0;
            this.btnTimDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimDH.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTimDH.ForeColor = System.Drawing.Color.White;
            this.btnTimDH.Location = new System.Drawing.Point(1005, 8);
            this.btnTimDH.Name = "btnTimDH";
            this.btnTimDH.Size = new System.Drawing.Size(90, 35);
            this.btnTimDH.TabIndex = 51;
            this.btnTimDH.Text = "🔍 Tìm";
            this.btnTimDH.UseVisualStyleBackColor = false;
            this.btnTimDH.Click += new System.EventHandler(this.btnTimDH_Click);
            // 
            // txtTimDH
            // 
            this.txtTimDH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimDH.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTimDH.Location = new System.Drawing.Point(630, 12);
            this.txtTimDH.Name = "txtTimDH";
            this.txtTimDH.Size = new System.Drawing.Size(365, 27);
            this.txtTimDH.TabIndex = 50;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label26.Location = new System.Drawing.Point(20, 14);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(590, 25);
            this.label26.TabIndex = 49;
            this.label26.Text = "🔍 TÌM ĐƠN HÀNG THEO SỐ ĐIỆN THOẠI HOẶC MÃ ĐƠN HÀNG";
            // 
            // dgvDSDH
            // 
            this.dgvDSDH.AllowUserToAddRows = false;
            this.dgvDSDH.AllowUserToDeleteRows = false;
            this.dgvDSDH.AllowUserToResizeColumns = false;
            this.dgvDSDH.AllowUserToResizeRows = false;
            this.dgvDSDH.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSDH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSDH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSDH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSDH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvDSDH.ColumnHeadersHeight = 50;
            this.dgvDSDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.order_date,
            this.full_name,
            this.phone_number,
            this.shipping_address,
            this.total_amount,
            this.order_status});
            this.dgvDSDH.EnableHeadersVisualStyles = false;
            this.dgvDSDH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvDSDH.Location = new System.Drawing.Point(18, 49);
            this.dgvDSDH.Name = "dgvDSDH";
            this.dgvDSDH.ReadOnly = true;
            this.dgvDSDH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSDH.RowHeadersVisible = false;
            this.dgvDSDH.RowTemplate.Height = 38;
            this.dgvDSDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSDH.Size = new System.Drawing.Size(1191, 396);
            this.dgvDSDH.TabIndex = 0;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "MÃ ĐH";
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Width = 85;
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            this.order_date.HeaderText = "NGÀY ĐẶT";
            this.order_date.Name = "order_date";
            this.order_date.ReadOnly = true;
            this.order_date.Width = 140;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "KHÁCH HÀNG";
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            this.full_name.Width = 200;
            // 
            // phone_number
            // 
            this.phone_number.DataPropertyName = "phone_number";
            this.phone_number.HeaderText = "SỐ ĐIỆN THOẠI";
            this.phone_number.Name = "phone_number";
            this.phone_number.ReadOnly = true;
            this.phone_number.Width = 120;
            // 
            // shipping_address
            // 
            this.shipping_address.DataPropertyName = "shipping_address";
            this.shipping_address.HeaderText = "ĐỊA CHỈ GIAO HÀNG";
            this.shipping_address.Name = "shipping_address";
            this.shipping_address.ReadOnly = true;
            this.shipping_address.Width = 280;
            // 
            // total_amount
            // 
            this.total_amount.DataPropertyName = "total_amount";
            this.total_amount.HeaderText = "TỔNG TIỀN";
            this.total_amount.Name = "total_amount";
            this.total_amount.ReadOnly = true;
            this.total_amount.Width = 130;
            // 
            // order_status
            // 
            this.order_status.DataPropertyName = "order_status";
            this.order_status.HeaderText = "TRẠNG THÁI";
            this.order_status.Name = "order_status";
            this.order_status.ReadOnly = true;
            this.order_status.Width = 215;
            // 
            // tabPageReport
            // 
            this.tabPageReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.tabPageReport.Controls.Add(this.button1);
            this.tabPageReport.Controls.Add(this.label22);
            this.tabPageReport.Controls.Add(this.txtOrderId);
            this.tabPageReport.Controls.Add(this.rpBill);
            this.tabPageReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageReport.Location = new System.Drawing.Point(4, 34);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(15);
            this.tabPageReport.Size = new System.Drawing.Size(1212, 623);
            this.tabPageReport.TabIndex = 3;
            this.tabPageReport.Text = "📃 Xuất Bill";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(674, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "🔍 Tìm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label22.Location = new System.Drawing.Point(342, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(151, 30);
            this.label22.TabIndex = 2;
            this.label22.Text = "Mã đơn hàng:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtOrderId.Location = new System.Drawing.Point(499, 10);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(165, 27);
            this.txtOrderId.TabIndex = 1;
            // 
            // rpBill
            // 
            this.rpBill.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.BillReport.rdlc";
            this.rpBill.Location = new System.Drawing.Point(257, 47);
            this.rpBill.Name = "rpBill";
            this.rpBill.ServerReport.BearerToken = null;
            this.rpBill.Size = new System.Drawing.Size(701, 581);
            this.rpBill.TabIndex = 0;
            this.rpBill.Load += new System.EventHandler(this.rpBill_Load);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1253, 685);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🏪 Admin - Quản lý bán hàng";
            this.tabQuanLyTaiKhoan.ResumeLayout(false);
            this.tabQuanLyTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.tabQuanLySanPham.ResumeLayout(false);
            this.tabQuanLySanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage_url)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabQuanLyDonHang.ResumeLayout(false);
            this.tabQuanLyDonHang.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDH)).EndInit();
            this.tabPageReport.ResumeLayout(false);
            this.tabPageReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabQuanLyTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone_Number;
        private System.Windows.Forms.TextBox txtFull_Name;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.TabPage tabQuanLySanPham;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTim_SDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemLuu;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoLuongSP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtGiaSP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMoTaSP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txtMauSP;
        private System.Windows.Forms.TextBox txtMaVachSP;
        private System.Windows.Forms.TextBox txtLinkAnhSP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnThemCapNhatSP;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clbarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcategory_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clproduct_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clstock_quantity;
        private System.Windows.Forms.DataGridViewLinkColumn image_url;
        private System.Windows.Forms.PictureBox pbImage_url;
        private System.Windows.Forms.TabPage tabQuanLyDonHang;
        private System.Windows.Forms.Button btnTimDH;
        private System.Windows.Forms.TextBox txtTimDH;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbTrangThaiDH;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnCapNhatDH;
        private System.Windows.Forms.Button btnXoaDH;
        private System.Windows.Forms.DataGridView dgvDSDH;
        private System.Windows.Forms.Button btnLoadALL;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipping_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn order_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn clfull_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clusername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn clphone_number;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private TabPage tabPageReport;
        private Microsoft.Reporting.WinForms.ReportViewer rpBill;
        private Button button1;
        private Label label22;
        private TextBox txtOrderId;
        private Label label21;
        private Panel panel2;
        private DataGridView dgvOrder_Items;
        private DataGridViewTextBoxColumn colTenSP;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colThanhTien;
    }
}