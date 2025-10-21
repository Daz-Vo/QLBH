namespace QuanLyBanHang
{
    partial class fChiTietSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChiTietSP));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.flowPanelThumbnails = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.panelActions = new System.Windows.Forms.Panel();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnBuyNow = new System.Windows.Forms.Button();
            this.labelDescriptionTitle = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.lblSoLuongTonKho = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.picAnhSP = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanelMain.Controls.Add(this.panelImage, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelDetails, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1100, 614);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.White;
            this.panelImage.Controls.Add(this.flowPanelThumbnails);
            this.panelImage.Controls.Add(this.picAnhSP);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(3, 3);
            this.panelImage.Name = "panelImage";
            this.panelImage.Padding = new System.Windows.Forms.Padding(25);
            this.panelImage.Size = new System.Drawing.Size(489, 608);
            this.panelImage.TabIndex = 0;
            // 
            // flowPanelThumbnails
            // 
            this.flowPanelThumbnails.AutoScroll = true;
            this.flowPanelThumbnails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.flowPanelThumbnails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanelThumbnails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelThumbnails.Location = new System.Drawing.Point(25, 473);
            this.flowPanelThumbnails.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.flowPanelThumbnails.Name = "flowPanelThumbnails";
            this.flowPanelThumbnails.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowPanelThumbnails.Size = new System.Drawing.Size(439, 110);
            this.flowPanelThumbnails.TabIndex = 1;
            this.flowPanelThumbnails.WrapContents = false;
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.White;
            this.panelDetails.Controls.Add(this.panelActions);
            this.panelDetails.Controls.Add(this.labelDescriptionTitle);
            this.panelDetails.Controls.Add(this.txtProductDescription);
            this.panelDetails.Controls.Add(this.lblSoLuongTonKho);
            this.panelDetails.Controls.Add(this.lblGia);
            this.panelDetails.Controls.Add(this.lblTenSP);
            this.panelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetails.Location = new System.Drawing.Point(498, 3);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.panelDetails.Size = new System.Drawing.Size(599, 608);
            this.panelDetails.TabIndex = 1;
            // 
            // panelActions
            // 
            this.panelActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActions.Controls.Add(this.txtSoLuong);
            this.panelActions.Controls.Add(this.lblQuantity);
            this.panelActions.Controls.Add(this.btnAddToCart);
            this.panelActions.Controls.Add(this.btnBuyNow);
            this.panelActions.Location = new System.Drawing.Point(30, 505);
            this.panelActions.Name = "panelActions";
            this.panelActions.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panelActions.Size = new System.Drawing.Size(539, 75);
            this.panelActions.TabIndex = 5;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(23, 35);
            this.txtSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(80, 31);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblQuantity.Location = new System.Drawing.Point(26, 10);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(69, 19);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Số lượng";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(130, 15);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(180, 50);
            this.btnAddToCart.TabIndex = 1;
            this.btnAddToCart.Text = "THÊM GIỎ HÀNG";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnBuyNow
            // 
            this.btnBuyNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnBuyNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyNow.FlatAppearance.BorderSize = 0;
            this.btnBuyNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyNow.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyNow.ForeColor = System.Drawing.Color.White;
            this.btnBuyNow.Location = new System.Drawing.Point(320, 15);
            this.btnBuyNow.Name = "btnBuyNow";
            this.btnBuyNow.Size = new System.Drawing.Size(180, 50);
            this.btnBuyNow.TabIndex = 0;
            this.btnBuyNow.Text = "MUA NGAY";
            this.btnBuyNow.UseVisualStyleBackColor = false;
            this.btnBuyNow.Click += new System.EventHandler(this.btnBuyNow_Click);
            // 
            // labelDescriptionTitle
            // 
            this.labelDescriptionTitle.AutoSize = true;
            this.labelDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriptionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.labelDescriptionTitle.Location = new System.Drawing.Point(32, 234);
            this.labelDescriptionTitle.Name = "labelDescriptionTitle";
            this.labelDescriptionTitle.Size = new System.Drawing.Size(155, 25);
            this.labelDescriptionTitle.TabIndex = 4;
            this.labelDescriptionTitle.Text = "Mô Tả Sản Phẩm";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.txtProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.txtProductDescription.Location = new System.Drawing.Point(30, 262);
            this.txtProductDescription.Multiline = true;
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.ReadOnly = true;
            this.txtProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProductDescription.Size = new System.Drawing.Size(539, 237);
            this.txtProductDescription.TabIndex = 3;
            this.txtProductDescription.TabStop = false;
            this.txtProductDescription.Text = "Chưa có thông tin mô tả.";
            // 
            // lblSoLuongTonKho
            // 
            this.lblSoLuongTonKho.AutoSize = true;
            this.lblSoLuongTonKho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTonKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSoLuongTonKho.Location = new System.Drawing.Point(34, 189);
            this.lblSoLuongTonKho.Name = "lblSoLuongTonKho";
            this.lblSoLuongTonKho.Size = new System.Drawing.Size(50, 20);
            this.lblSoLuongTonKho.TabIndex = 2;
            this.lblSoLuongTonKho.Text = "Còn: 0";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblGia.Location = new System.Drawing.Point(28, 129);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(257, 51);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "000.000 VNĐ";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lblTenSP.Location = new System.Drawing.Point(30, 25);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(539, 104);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Tên Sản Phẩm: ";
            // 
            // picAnhSP
            // 
            this.picAnhSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.picAnhSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAnhSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.picAnhSP.Location = new System.Drawing.Point(25, 25);
            this.picAnhSP.Name = "picAnhSP";
            this.picAnhSP.Size = new System.Drawing.Size(439, 448);
            this.picAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhSP.TabIndex = 0;
            this.picAnhSP.TabStop = false;
            // 
            // fChiTietSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 614);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "fChiTietSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Sản Phẩm";
            this.Load += new System.EventHandler(this.fChiTietSP_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.PictureBox picAnhSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSoLuongTonKho;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label labelDescriptionTitle;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button btnBuyNow;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        // KHAI BÁO BIẾN MỚI
        private System.Windows.Forms.FlowLayoutPanel flowPanelThumbnails;
    }
}