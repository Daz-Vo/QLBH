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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvOrder_Items = new System.Windows.Forms.DataGridView();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage_url)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDH)).BeginInit();
            this.tabPageReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnXoa);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnTimKiem);
            this.tabPage3.Controls.Add(this.btnThemLuu);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtAddress);
            this.tabPage3.Controls.Add(this.txtEmail);
            this.tabPage3.Controls.Add(this.txtTim_SDT);
            this.tabPage3.Controls.Add(this.txtPhone_Number);
            this.tabPage3.Controls.Add(this.txtFull_Name);
            this.tabPage3.Controls.Add(this.txtPassWord);
            this.tabPage3.Controls.Add(this.txtUserName);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dgvTaiKhoan);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1212, 633);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Danh sách tài khoản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1121, 592);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 38);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "TÌM TÀI KHOẢN";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(1111, 84);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(72, 26);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemLuu
            // 
            this.btnThemLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLuu.Location = new System.Drawing.Point(877, 502);
            this.btnThemLuu.Name = "btnThemLuu";
            this.btnThemLuu.Size = new System.Drawing.Size(115, 38);
            this.btnThemLuu.TabIndex = 1;
            this.btnThemLuu.Text = "Thêm/Lưu";
            this.btnThemLuu.UseVisualStyleBackColor = true;
            this.btnThemLuu.Click += new System.EventHandler(this.btnThemLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(696, 439);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(487, 26);
            this.txtAddress.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(696, 407);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(487, 26);
            this.txtEmail.TabIndex = 17;
            // 
            // txtTim_SDT
            // 
            this.txtTim_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim_SDT.Location = new System.Drawing.Point(682, 84);
            this.txtTim_SDT.Name = "txtTim_SDT";
            this.txtTim_SDT.Size = new System.Drawing.Size(423, 26);
            this.txtTim_SDT.TabIndex = 16;
            // 
            // txtPhone_Number
            // 
            this.txtPhone_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone_Number.Location = new System.Drawing.Point(696, 375);
            this.txtPhone_Number.Name = "txtPhone_Number";
            this.txtPhone_Number.Size = new System.Drawing.Size(487, 26);
            this.txtPhone_Number.TabIndex = 16;
            // 
            // txtFull_Name
            // 
            this.txtFull_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFull_Name.Location = new System.Drawing.Point(696, 343);
            this.txtFull_Name.Name = "txtFull_Name";
            this.txtFull_Name.Size = new System.Drawing.Size(487, 26);
            this.txtFull_Name.TabIndex = 15;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.Location = new System.Drawing.Point(696, 311);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(487, 26);
            this.txtPassWord.TabIndex = 14;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(696, 279);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(487, 26);
            this.txtUserName.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(574, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nhập SDT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(571, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(571, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Đăng nhập";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeight = 50;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clfull_name,
            this.clusername,
            this.clpassword,
            this.clphone_number});
            this.dgvTaiKhoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 3);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(537, 626);
            this.dgvTaiKhoan.TabIndex = 1;
            // 
            // clfull_name
            // 
            this.clfull_name.DataPropertyName = "full_name";
            this.clfull_name.HeaderText = "HỌ TÊN";
            this.clfull_name.Name = "clfull_name";
            this.clfull_name.Width = 170;
            // 
            // clusername
            // 
            this.clusername.DataPropertyName = "username";
            this.clusername.HeaderText = "TÊN ĐĂNG NHẬP";
            this.clusername.Name = "clusername";
            // 
            // clpassword
            // 
            this.clpassword.DataPropertyName = "password";
            this.clpassword.HeaderText = "MẬT KHẨU";
            this.clpassword.Name = "clpassword";
            this.clpassword.Width = 130;
            // 
            // clphone_number
            // 
            this.clphone_number.DataPropertyName = "phone_number";
            this.clphone_number.HeaderText = "SỐ ĐIỆN THOẠI";
            this.clphone_number.Name = "clphone_number";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbImage_url);
            this.tabPage1.Controls.Add(this.txtMauSP);
            this.tabPage1.Controls.Add(this.txtSoLuongSP);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtGiaSP);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtMoTaSP);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtMaVachSP);
            this.tabPage1.Controls.Add(this.txtLinkAnhSP);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.txtTenSP);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnTimSP);
            this.tabPage1.Controls.Add(this.txtTimSP);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnThemCapNhatSP);
            this.tabPage1.Controls.Add(this.btnXoaSP);
            this.tabPage1.Controls.Add(this.dgvDSSP);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1212, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách sản phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbImage_url
            // 
            this.pbImage_url.InitialImage = null;
            this.pbImage_url.Location = new System.Drawing.Point(850, 467);
            this.pbImage_url.Name = "pbImage_url";
            this.pbImage_url.Size = new System.Drawing.Size(127, 145);
            this.pbImage_url.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage_url.TabIndex = 28;
            this.pbImage_url.TabStop = false;
            // 
            // txtMauSP
            // 
            this.txtMauSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMauSP.FormattingEnabled = true;
            this.txtMauSP.Items.AddRange(new object[] {
            "Điện thoại",
            "Tai Nghe"});
            this.txtMauSP.Location = new System.Drawing.Point(431, 584);
            this.txtMauSP.Name = "txtMauSP";
            this.txtMauSP.Size = new System.Drawing.Size(121, 28);
            this.txtMauSP.TabIndex = 27;
            // 
            // txtSoLuongSP
            // 
            this.txtSoLuongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongSP.Location = new System.Drawing.Point(763, 523);
            this.txtSoLuongSP.Name = "txtSoLuongSP";
            this.txtSoLuongSP.Size = new System.Drawing.Size(64, 26);
            this.txtSoLuongSP.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(685, 529);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Số lượng";
            // 
            // txtGiaSP
            // 
            this.txtGiaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSP.Location = new System.Drawing.Point(470, 523);
            this.txtGiaSP.Name = "txtGiaSP";
            this.txtGiaSP.Size = new System.Drawing.Size(174, 26);
            this.txtGiaSP.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(385, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Giá thành";
            // 
            // txtMoTaSP
            // 
            this.txtMoTaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTaSP.Location = new System.Drawing.Point(149, 552);
            this.txtMoTaSP.Name = "txtMoTaSP";
            this.txtMoTaSP.Size = new System.Drawing.Size(678, 26);
            this.txtMoTaSP.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 555);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Mô tả sản phẩm";
            // 
            // txtMaVachSP
            // 
            this.txtMaVachSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVachSP.Location = new System.Drawing.Point(663, 584);
            this.txtMaVachSP.Name = "txtMaVachSP";
            this.txtMaVachSP.Size = new System.Drawing.Size(164, 26);
            this.txtMaVachSP.TabIndex = 26;
            // 
            // txtLinkAnhSP
            // 
            this.txtLinkAnhSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinkAnhSP.Location = new System.Drawing.Point(90, 581);
            this.txtLinkAnhSP.Name = "txtLinkAnhSP";
            this.txtLinkAnhSP.Size = new System.Drawing.Size(176, 26);
            this.txtLinkAnhSP.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(589, 587);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "Mã vạch";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(136, 523);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(209, 26);
            this.txtTenSP.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(15, 584);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "Link ảnh";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(311, 587);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Mẫu sản phẩm";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 526);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Tên sản phẩm";
            // 
            // btnTimSP
            // 
            this.btnTimSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSP.Location = new System.Drawing.Point(755, 467);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(72, 31);
            this.btnTimSP.TabIndex = 24;
            this.btnTimSP.Text = "Tìm";
            this.btnTimSP.UseVisualStyleBackColor = true;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // txtTimSP
            // 
            this.txtTimSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSP.Location = new System.Drawing.Point(369, 469);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(380, 26);
            this.txtTimSP.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "TÌM SẢN PHẨM BẰNG MÃ VẠCH";
            // 
            // btnThemCapNhatSP
            // 
            this.btnThemCapNhatSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCapNhatSP.Location = new System.Drawing.Point(1018, 472);
            this.btnThemCapNhatSP.Name = "btnThemCapNhatSP";
            this.btnThemCapNhatSP.Size = new System.Drawing.Size(138, 38);
            this.btnThemCapNhatSP.TabIndex = 3;
            this.btnThemCapNhatSP.Text = "Thêm / Cập Nhật";
            this.btnThemCapNhatSP.UseVisualStyleBackColor = true;
            this.btnThemCapNhatSP.Click += new System.EventHandler(this.btnThemCapNhatSP_Click);
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnXoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSP.Location = new System.Drawing.Point(1121, 592);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(88, 38);
            this.btnXoaSP.TabIndex = 3;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            this.btnXoaSP.Click += new System.EventHandler(this.btnXoaSP_Click);
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clbarcode,
            this.clcategory_id,
            this.clproduct_name,
            this.cldescription,
            this.clprice,
            this.clstock_quantity,
            this.image_url});
            this.dgvDSSP.Location = new System.Drawing.Point(0, 0);
            this.dgvDSSP.Name = "dgvDSSP";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSSP.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDSSP.ShowCellErrors = false;
            this.dgvDSSP.Size = new System.Drawing.Size(1212, 442);
            this.dgvDSSP.TabIndex = 2;
            // 
            // clbarcode
            // 
            this.clbarcode.DataPropertyName = "barcode";
            this.clbarcode.HeaderText = "MÃ VẠCH";
            this.clbarcode.Name = "clbarcode";
            // 
            // clcategory_id
            // 
            this.clcategory_id.DataPropertyName = "category_id";
            this.clcategory_id.HeaderText = "MẫU SẢN PHẨM";
            this.clcategory_id.Name = "clcategory_id";
            // 
            // clproduct_name
            // 
            this.clproduct_name.DataPropertyName = "product_name";
            this.clproduct_name.HeaderText = "TÊN SẢN PHẨM";
            this.clproduct_name.Name = "clproduct_name";
            this.clproduct_name.Width = 200;
            // 
            // cldescription
            // 
            this.cldescription.DataPropertyName = "description";
            this.cldescription.HeaderText = "MÔ TẢ";
            this.cldescription.Name = "cldescription";
            this.cldescription.Width = 400;
            // 
            // clprice
            // 
            this.clprice.DataPropertyName = "price";
            this.clprice.HeaderText = "GIÁ THÀNH";
            this.clprice.Name = "clprice";
            this.clprice.Width = 150;
            // 
            // clstock_quantity
            // 
            this.clstock_quantity.DataPropertyName = "stock_quantity";
            this.clstock_quantity.HeaderText = "SỐ LƯỢNG";
            this.clstock_quantity.Name = "clstock_quantity";
            // 
            // image_url
            // 
            this.image_url.DataPropertyName = "image_url";
            this.image_url.HeaderText = "LINK HÌNH ẢNH";
            this.image_url.Name = "image_url";
            this.image_url.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image_url.Width = 120;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPageReport);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1220, 661);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.btnLoadALL);
            this.tabPage2.Controls.Add(this.btnTimDH);
            this.tabPage2.Controls.Add(this.txtTimDH);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.dgvDSDH);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1212, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách đơn hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtMaDH);
            this.panel1.Controls.Add(this.cbTrangThaiDH);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.btnCapNhatDH);
            this.panel1.Controls.Add(this.btnXoaDH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 117);
            this.panel1.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(400, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 17);
            this.label21.TabIndex = 58;
            this.label21.Text = "CT đơn hàng:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(4, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(142, 20);
            this.label20.TabIndex = 57;
            this.label20.Text = "cần cập nhật / xóa:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOrder_Items);
            this.panel2.Location = new System.Drawing.Point(510, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 100);
            this.panel2.TabIndex = 56;
            // 
            // dgvOrder_Items
            // 
            this.dgvOrder_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSP,
            this.colSoLuong,
            this.colGia,
            this.colThanhTien});
            this.dgvOrder_Items.EnableHeadersVisualStyles = false;
            this.dgvOrder_Items.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder_Items.Name = "dgvOrder_Items";
            this.dgvOrder_Items.RowHeadersVisible = false;
            this.dgvOrder_Items.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvOrder_Items.Size = new System.Drawing.Size(524, 100);
            this.dgvOrder_Items.TabIndex = 0;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenSP.DefaultCellStyle = dataGridViewCellStyle17;
            this.colTenSP.HeaderText = "Tên Sản Phẩm";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Width = 220;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSoLuong.DefaultCellStyle = dataGridViewCellStyle18;
            this.colSoLuong.HeaderText = "SL";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 50;
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "GiaDonVi";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N0";
            this.colGia.DefaultCellStyle = dataGridViewCellStyle19;
            this.colGia.HeaderText = "Giá Đơn Vị";
            this.colGia.Name = "colGia";
            this.colGia.Width = 120;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N0";
            this.colThanhTien.DefaultCellStyle = dataGridViewCellStyle20;
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Width = 130;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(4, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 20);
            this.label19.TabIndex = 55;
            this.label19.Text = "Mã đơn hàng";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(319, 17);
            this.label18.TabIndex = 53;
            this.label18.Text = "CẬP NHẬT TRẠNG THÁI / XÓA ĐƠN HÀNG";
            // 
            // txtMaDH
            // 
            this.txtMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDH.Location = new System.Drawing.Point(8, 79);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(138, 26);
            this.txtMaDH.TabIndex = 54;
            // 
            // cbTrangThaiDH
            // 
            this.cbTrangThaiDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThaiDH.FormattingEnabled = true;
            this.cbTrangThaiDH.Items.AddRange(new object[] {
            "Đang đóng hàng",
            "Đang trên đường vận chuyển",
            "Đang giao hàng"});
            this.cbTrangThaiDH.Location = new System.Drawing.Point(200, 77);
            this.cbTrangThaiDH.Name = "cbTrangThaiDH";
            this.cbTrangThaiDH.Size = new System.Drawing.Size(176, 28);
            this.cbTrangThaiDH.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(196, 54);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(180, 20);
            this.label23.TabIndex = 38;
            this.label23.Text = "trạng thái đơn hàng mới:";
            // 
            // btnCapNhatDH
            // 
            this.btnCapNhatDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatDH.Location = new System.Drawing.Point(1079, 27);
            this.btnCapNhatDH.Name = "btnCapNhatDH";
            this.btnCapNhatDH.Size = new System.Drawing.Size(86, 38);
            this.btnCapNhatDH.TabIndex = 30;
            this.btnCapNhatDH.Text = "Cập Nhật";
            this.btnCapNhatDH.UseVisualStyleBackColor = true;
            this.btnCapNhatDH.Click += new System.EventHandler(this.btnCapNhatDH_Click);
            // 
            // btnXoaDH
            // 
            this.btnXoaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDH.Location = new System.Drawing.Point(1118, 79);
            this.btnXoaDH.Name = "btnXoaDH";
            this.btnXoaDH.Size = new System.Drawing.Size(88, 38);
            this.btnXoaDH.TabIndex = 29;
            this.btnXoaDH.Text = "Xóa";
            this.btnXoaDH.UseVisualStyleBackColor = true;
            this.btnXoaDH.Click += new System.EventHandler(this.btnXoaDH_Click);
            // 
            // btnLoadALL
            // 
            this.btnLoadALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadALL.Location = new System.Drawing.Point(1137, 3);
            this.btnLoadALL.Name = "btnLoadALL";
            this.btnLoadALL.Size = new System.Drawing.Size(72, 31);
            this.btnLoadALL.TabIndex = 52;
            this.btnLoadALL.Text = "LoadALL";
            this.btnLoadALL.UseVisualStyleBackColor = true;
            this.btnLoadALL.Click += new System.EventHandler(this.btnLoadALL_Click);
            // 
            // btnTimDH
            // 
            this.btnTimDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimDH.Location = new System.Drawing.Point(915, 4);
            this.btnTimDH.Name = "btnTimDH";
            this.btnTimDH.Size = new System.Drawing.Size(72, 31);
            this.btnTimDH.TabIndex = 51;
            this.btnTimDH.Text = "Tìm";
            this.btnTimDH.UseVisualStyleBackColor = true;
            this.btnTimDH.Click += new System.EventHandler(this.btnTimDH_Click);
            // 
            // txtTimDH
            // 
            this.txtTimDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimDH.Location = new System.Drawing.Point(613, 6);
            this.txtTimDH.Name = "txtTimDH";
            this.txtTimDH.Size = new System.Drawing.Size(296, 26);
            this.txtTimDH.TabIndex = 50;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 8);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(453, 17);
            this.label26.TabIndex = 49;
            this.label26.Text = "TÌM ĐƠN HÀNG THEO SỐ ĐIỆN THOẠI HOẶC MÃ ĐƠN HÀNG";
            // 
            // dgvDSDH
            // 
            this.dgvDSDH.AllowUserToResizeColumns = false;
            this.dgvDSDH.AllowUserToResizeRows = false;
            this.dgvDSDH.ColumnHeadersHeight = 50;
            this.dgvDSDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.order_date,
            this.full_name,
            this.phone_number,
            this.shipping_address,
            this.total_amount,
            this.order_status});
            this.dgvDSDH.Location = new System.Drawing.Point(0, 38);
            this.dgvDSDH.Name = "dgvDSDH";
            this.dgvDSDH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvDSDH.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvDSDH.Size = new System.Drawing.Size(1212, 466);
            this.dgvDSDH.TabIndex = 0;
            // 
            // order_id
            // 
            this.order_id.DataPropertyName = "order_id";
            this.order_id.HeaderText = "MÃ ĐƠN HÀNG";
            this.order_id.Name = "order_id";
            // 
            // order_date
            // 
            this.order_date.DataPropertyName = "order_date";
            this.order_date.HeaderText = "NGÀY ĐẶT HÀNG";
            this.order_date.Name = "order_date";
            this.order_date.Width = 150;
            // 
            // full_name
            // 
            this.full_name.DataPropertyName = "full_name";
            this.full_name.HeaderText = "KHÁCH HÀNG";
            this.full_name.Name = "full_name";
            this.full_name.Width = 230;
            // 
            // phone_number
            // 
            this.phone_number.DataPropertyName = "phone_number";
            this.phone_number.HeaderText = "SỐ ĐIỆN THOẠI";
            this.phone_number.Name = "phone_number";
            // 
            // shipping_address
            // 
            this.shipping_address.DataPropertyName = "shipping_address";
            this.shipping_address.HeaderText = "ĐỊA CHỈ GIAO HÀNG";
            this.shipping_address.Name = "shipping_address";
            this.shipping_address.Width = 300;
            // 
            // total_amount
            // 
            this.total_amount.DataPropertyName = "total_amount";
            this.total_amount.HeaderText = "TỔNG TIỀN HÀNG";
            this.total_amount.Name = "total_amount";
            this.total_amount.Width = 150;
            // 
            // order_status
            // 
            this.order_status.DataPropertyName = "order_status";
            this.order_status.HeaderText = "TRẠNG THÁI ĐƠN HÀNG";
            this.order_status.Name = "order_status";
            this.order_status.Width = 150;
            // 
            // tabPageReport
            // 
            this.tabPageReport.Controls.Add(this.button1);
            this.tabPageReport.Controls.Add(this.label22);
            this.tabPageReport.Controls.Add(this.txtOrderId);
            this.tabPageReport.Controls.Add(this.rpBill);
            this.tabPageReport.Location = new System.Drawing.Point(4, 24);
            this.tabPageReport.Name = "tabPageReport";
            this.tabPageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReport.Size = new System.Drawing.Size(1212, 633);
            this.tabPageReport.TabIndex = 3;
            this.tabPageReport.Text = "Report";
            this.tabPageReport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(4, 9);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 15);
            this.label22.TabIndex = 2;
            this.label22.Text = "Mã đơn hàng:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(105, 6);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(166, 21);
            this.txtOrderId.TabIndex = 1;
            // 
            // rpBill
            // 
            this.rpBill.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.BillReport.rdlc";
            this.rpBill.Location = new System.Drawing.Point(3, 33);
            this.rpBill.Name = "rpBill";
            this.rpBill.ServerReport.BearerToken = null;
            this.rpBill.Size = new System.Drawing.Size(1206, 594);
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
            this.ClientSize = new System.Drawing.Size(1236, 696);
            this.Controls.Add(this.tabControl1);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage_url)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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

        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvOrder_Items;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private Label label21;
        private TabPage tabPageReport;
        private Microsoft.Reporting.WinForms.ReportViewer rpBill;
        private DataGridViewTextBoxColumn colTenSP;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private Button button1;
        private Label label22;
        private TextBox txtOrderId;
    }
}