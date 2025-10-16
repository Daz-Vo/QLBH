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
            this.picAnh.BackColor = System.Drawing.Color.LightGray;
            this.picAnh.Location = new System.Drawing.Point(10, 10);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(179, 160);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 0;
            this.picAnh.TabStop = false;
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(10, 175);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(179, 25);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên sản phẩm";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.Red;
            this.lblGia.Location = new System.Drawing.Point(9, 198);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(180, 20);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "0 ₫";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Gray;
            this.lblSoLuong.Location = new System.Drawing.Point(10, 220);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(90, 20);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Còn: 0";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(10, 248);
            this.txtSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(40, 20);
            this.txtSoLuong.TabIndex = 4;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThemGioHang
            // 
            this.btnThemGioHang.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemGioHang.FlatAppearance.BorderSize = 0;
            this.btnThemGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGioHang.ForeColor = System.Drawing.Color.White;
            this.btnThemGioHang.Location = new System.Drawing.Point(58, 245);
            this.btnThemGioHang.Name = "btnThemGioHang";
            this.btnThemGioHang.Size = new System.Drawing.Size(47, 25);
            this.btnThemGioHang.TabIndex = 5;
            this.btnThemGioHang.Text = "Thêm";
            this.btnThemGioHang.UseVisualStyleBackColor = false;
            this.btnThemGioHang.Click += new System.EventHandler(this.btnThemGioHang_Click);
            // 
            // btnMuaNgay
            // 
            this.btnMuaNgay.BackColor = System.Drawing.Color.Red;
            this.btnMuaNgay.FlatAppearance.BorderSize = 0;
            this.btnMuaNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuaNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuaNgay.ForeColor = System.Drawing.Color.White;
            this.btnMuaNgay.Location = new System.Drawing.Point(114, 245);
            this.btnMuaNgay.Name = "btnMuaNgay";
            this.btnMuaNgay.Size = new System.Drawing.Size(75, 25);
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
            this.Controls.Add(this.btnMuaNgay);
            this.Controls.Add(this.btnThemGioHang);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.picAnh);
            this.Name = "SanPhamItem";
            this.Size = new System.Drawing.Size(197, 280);
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