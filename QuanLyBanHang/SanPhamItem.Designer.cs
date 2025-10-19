namespace QuanLyBanHang
{
    partial class SanPhamItem
    {
        // ... (phần Dispose và Components giữ nguyên)

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemGioHang = new System.Windows.Forms.Button();
            this.btnMuaNgay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // picAnh
            // 
            this.picAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.picAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAnh.Location = new System.Drawing.Point(12, 12);
            this.picAnh.MaximumSize = new System.Drawing.Size(196, 196);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(196, 196);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            this.picAnh.Click += new System.EventHandler(this.picAnh_Click);
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTen.Location = new System.Drawing.Point(12, 210);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(196, 21);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên sản phẩm";
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblGia.Location = new System.Drawing.Point(12, 223);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(196, 28);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "0 VNĐ";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSoLuong.Location = new System.Drawing.Point(12, 254);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(130, 22);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Còn: 0";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(148, 254);
            this.txtSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(60, 23);
            this.txtSoLuong.TabIndex = 4;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemGioHang
            // 
            this.btnThemGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnThemGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemGioHang.FlatAppearance.BorderSize = 0;
            this.btnThemGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGioHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGioHang.ForeColor = System.Drawing.Color.White;
            this.btnThemGioHang.Location = new System.Drawing.Point(12, 282);
            this.btnThemGioHang.Name = "btnThemGioHang";
            this.btnThemGioHang.Size = new System.Drawing.Size(95, 32);
            this.btnThemGioHang.TabIndex = 5;
            this.btnThemGioHang.Text = "Thêm";
            this.btnThemGioHang.UseVisualStyleBackColor = false;
            this.btnThemGioHang.Click += new System.EventHandler(this.btnThemGioHang_Click);
            // 
            // btnMuaNgay
            // 
            this.btnMuaNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnMuaNgay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuaNgay.FlatAppearance.BorderSize = 0;
            this.btnMuaNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuaNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaNgay.ForeColor = System.Drawing.Color.White;
            this.btnMuaNgay.Location = new System.Drawing.Point(113, 282);
            this.btnMuaNgay.Name = "btnMuaNgay";
            this.btnMuaNgay.Size = new System.Drawing.Size(95, 32);
            this.btnMuaNgay.TabIndex = 6;
            this.btnMuaNgay.Text = "Mua Ngay";
            this.btnMuaNgay.UseVisualStyleBackColor = false;
            this.btnMuaNgay.Click += new System.EventHandler(this.btnMuaNgay_Click);
            // 
            // SanPhamItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.btnMuaNgay);
            this.Controls.Add(this.btnThemGioHang);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.picAnh);
            this.Name = "SanPhamItem";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(220, 327);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSoLuong;

        // Khai báo controls mới
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.Button btnThemGioHang;
        private System.Windows.Forms.Button btnMuaNgay;
    }
}