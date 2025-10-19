using System.Windows.Forms;

namespace QuanLyBanHang
{
    partial class fHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnDatHang = new System.Windows.Forms.Button();
            this.panelGioHang = new System.Windows.Forms.Panel();
            this.flowPanelGioHang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowDienThoai = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panelSanPham = new System.Windows.Forms.TabPage();
            this.flowPanelSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLoadLaisp = new System.Windows.Forms.Button();
            this.panelGioHang.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panelSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(791, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "🛒 Giỏ hàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label2.Location = new System.Drawing.Point(220, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "📦 Danh mục sản phẩm";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(780, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "👤 Tài khoản:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaiKhoan.AutoSize = true;
            this.txtTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txtTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.txtTaiKhoan.Location = new System.Drawing.Point(885, 14);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(123, 20);
            this.txtTaiKhoan.TabIndex = 7;
            this.txtTaiKhoan.Text = "Chưa đăng nhập";
            this.txtTaiKhoan.Click += new System.EventHandler(this.txtTaiKhoan_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblTongTien.Location = new System.Drawing.Point(0, 351);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTongTien.Size = new System.Drawing.Size(291, 35);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "💰 Tổng: 0 VNĐ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDatHang
            // 
            this.btnDatHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDatHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDatHang.FlatAppearance.BorderSize = 0;
            this.btnDatHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDatHang.ForeColor = System.Drawing.Color.White;
            this.btnDatHang.Location = new System.Drawing.Point(0, 386);
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.Size = new System.Drawing.Size(291, 42);
            this.btnDatHang.TabIndex = 2;
            this.btnDatHang.Text = "🛍 ĐẶT HÀNG NGAY";
            this.btnDatHang.UseVisualStyleBackColor = false;
            // 
            // panelGioHang
            // 
            this.panelGioHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGioHang.BackColor = System.Drawing.Color.White;
            this.panelGioHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGioHang.Controls.Add(this.flowPanelGioHang);
            this.panelGioHang.Controls.Add(this.lblTongTien);
            this.panelGioHang.Controls.Add(this.btnDatHang);
            this.panelGioHang.Location = new System.Drawing.Point(712, 165);
            this.panelGioHang.Name = "panelGioHang";
            this.panelGioHang.Size = new System.Drawing.Size(293, 430);
            this.panelGioHang.TabIndex = 3;
            // 
            // flowPanelGioHang
            // 
            this.flowPanelGioHang.AutoScroll = true;
            this.flowPanelGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.flowPanelGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelGioHang.Location = new System.Drawing.Point(0, 0);
            this.flowPanelGioHang.Name = "flowPanelGioHang";
            this.flowPanelGioHang.Padding = new System.Windows.Forms.Padding(8);
            this.flowPanelGioHang.Size = new System.Drawing.Size(291, 351);
            this.flowPanelGioHang.TabIndex = 3;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(890, 48);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(115, 38);
            this.btnDangNhap.TabIndex = 13;
            this.btnDangNhap.Text = "🔐 Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(890, 48);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(115, 38);
            this.btnDangXuat.TabIndex = 12;
            this.btnDangXuat.Text = "🚪 Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Visible = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(19, 48);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(130, 38);
            this.btnAdmin.TabIndex = 14;
            this.btnAdmin.Text = "⚙ Quản lý";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(687, 430);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "🔧 Linh kiện";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(687, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "🎧 Tai nghe";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.flowDienThoai);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "📱 Điện thoại";
            // 
            // flowDienThoai
            // 
            this.flowDienThoai.AutoScroll = true;
            this.flowDienThoai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.flowDienThoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDienThoai.Location = new System.Drawing.Point(3, 3);
            this.flowDienThoai.Margin = new System.Windows.Forms.Padding(1);
            this.flowDienThoai.Name = "flowDienThoai";
            this.flowDienThoai.Padding = new System.Windows.Forms.Padding(8);
            this.flowDienThoai.Size = new System.Drawing.Size(681, 424);
            this.flowDienThoai.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.panelSanPham);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 460);
            this.tabControl1.TabIndex = 2;
            // 
            // panelSanPham
            // 
            this.panelSanPham.BackColor = System.Drawing.Color.White;
            this.panelSanPham.Controls.Add(this.flowPanelSanPham);
            this.panelSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.panelSanPham.Location = new System.Drawing.Point(4, 30);
            this.panelSanPham.Name = "panelSanPham";
            this.panelSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.panelSanPham.Size = new System.Drawing.Size(687, 426);
            this.panelSanPham.TabIndex = 0;
            this.panelSanPham.Text = "🏪 Toàn bộ sản phẩm";
            // 
            // flowPanelSanPham
            // 
            this.flowPanelSanPham.AutoScroll = true;
            this.flowPanelSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.flowPanelSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelSanPham.Location = new System.Drawing.Point(3, 3);
            this.flowPanelSanPham.Margin = new System.Windows.Forms.Padding(1);
            this.flowPanelSanPham.Name = "flowPanelSanPham";
            this.flowPanelSanPham.Padding = new System.Windows.Forms.Padding(8);
            this.flowPanelSanPham.Size = new System.Drawing.Size(681, 420);
            this.flowPanelSanPham.TabIndex = 0;
            // 
            // btnLoadLaisp
            // 
            this.btnLoadLaisp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoadLaisp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadLaisp.FlatAppearance.BorderSize = 0;
            this.btnLoadLaisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadLaisp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLoadLaisp.ForeColor = System.Drawing.Color.White;
            this.btnLoadLaisp.Location = new System.Drawing.Point(19, 92);
            this.btnLoadLaisp.Name = "btnLoadLaisp";
            this.btnLoadLaisp.Size = new System.Drawing.Size(130, 38);
            this.btnLoadLaisp.TabIndex = 15;
            this.btnLoadLaisp.Text = "🔃Load Lai SP";
            this.btnLoadLaisp.UseVisualStyleBackColor = false;
            this.btnLoadLaisp.Visible = false;
            this.btnLoadLaisp.Click += new System.EventHandler(this.btnLoadLaisp_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1017, 607);
            this.Controls.Add(this.btnLoadLaisp);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelGioHang);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "🏪 Cửa hàng bán điện thoại";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelGioHang.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.panelSanPham.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtTaiKhoan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnDatHang;
        private System.Windows.Forms.Panel panelGioHang;
        private System.Windows.Forms.FlowLayoutPanel flowPanelGioHang;
        private Button btnDangNhap;
        private Button btnDangXuat;
        private Button btnAdmin;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private TabControl tabControl1;
        private TabPage panelSanPham;
        private FlowLayoutPanel flowPanelSanPham;
        private FlowLayoutPanel flowDienThoai;
        private Button btnLoadLaisp;
    }
}