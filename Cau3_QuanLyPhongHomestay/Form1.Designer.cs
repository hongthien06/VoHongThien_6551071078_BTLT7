namespace Cau3_QuanLyPhongHomestay;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.lblMaPhong = new System.Windows.Forms.Label();
        this.txtMaPhong = new System.Windows.Forms.TextBox();
        this.lblSoPhong = new System.Windows.Forms.Label();
        this.txtSoPhong = new System.Windows.Forms.TextBox();
        this.lblTangSo = new System.Windows.Forms.Label();
        this.numTangSo = new System.Windows.Forms.NumericUpDown();
        this.lblLoaiPhong = new System.Windows.Forms.Label();
        this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
        this.btnQuanLyLoaiPhong = new System.Windows.Forms.Button();
        this.lblTinhTrang = new System.Windows.Forms.Label();
        this.cboTinhTrang = new System.Windows.Forms.ComboBox();
        this.picHinhAnh = new System.Windows.Forms.PictureBox();
        this.btnChonAnh = new System.Windows.Forms.Button();
        this.txtHinhAnh = new System.Windows.Forms.TextBox();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.cboLocLoaiPhong = new System.Windows.Forms.ComboBox();
        this.cboLocTinhTrang = new System.Windows.Forms.ComboBox();
        this.btnTimKiem = new System.Windows.Forms.Button();
        this.btnHienTatCa = new System.Windows.Forms.Button();
        this.dgvPhong = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.numTangSo)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
        this.SuspendLayout();
        //
        // lblMaPhong
        //
        this.lblMaPhong.AutoSize = true;
        this.lblMaPhong.Location = new System.Drawing.Point(15, 10);
        this.lblMaPhong.Name = "lblMaPhong";
        this.lblMaPhong.Text = "Mã phòng";
        //
        // txtMaPhong
        //
        this.txtMaPhong.Location = new System.Drawing.Point(15, 28);
        this.txtMaPhong.Name = "txtMaPhong";
        this.txtMaPhong.ReadOnly = true;
        this.txtMaPhong.Size = new System.Drawing.Size(70, 23);
        this.txtMaPhong.TabIndex = 0;
        this.txtMaPhong.TabStop = false;
        //
        // lblSoPhong
        //
        this.lblSoPhong.AutoSize = true;
        this.lblSoPhong.Location = new System.Drawing.Point(100, 10);
        this.lblSoPhong.Name = "lblSoPhong";
        this.lblSoPhong.Text = "Số phòng";
        //
        // txtSoPhong
        //
        this.txtSoPhong.Location = new System.Drawing.Point(100, 28);
        this.txtSoPhong.MaxLength = 10;
        this.txtSoPhong.Name = "txtSoPhong";
        this.txtSoPhong.Size = new System.Drawing.Size(110, 23);
        this.txtSoPhong.TabIndex = 1;
        //
        // lblTangSo
        //
        this.lblTangSo.AutoSize = true;
        this.lblTangSo.Location = new System.Drawing.Point(225, 10);
        this.lblTangSo.Name = "lblTangSo";
        this.lblTangSo.Text = "Tầng số";
        //
        // numTangSo
        //
        this.numTangSo.Location = new System.Drawing.Point(225, 28);
        this.numTangSo.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
        this.numTangSo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.numTangSo.Name = "numTangSo";
        this.numTangSo.Size = new System.Drawing.Size(70, 23);
        this.numTangSo.TabIndex = 2;
        this.numTangSo.Value = new decimal(new int[] { 1, 0, 0, 0 });
        //
        // lblLoaiPhong
        //
        this.lblLoaiPhong.AutoSize = true;
        this.lblLoaiPhong.Location = new System.Drawing.Point(310, 10);
        this.lblLoaiPhong.Name = "lblLoaiPhong";
        this.lblLoaiPhong.Text = "Loại phòng";
        //
        // cboLoaiPhong
        //
        this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLoaiPhong.Location = new System.Drawing.Point(310, 28);
        this.cboLoaiPhong.Name = "cboLoaiPhong";
        this.cboLoaiPhong.Size = new System.Drawing.Size(160, 23);
        this.cboLoaiPhong.TabIndex = 3;
        //
        // btnQuanLyLoaiPhong
        //
        this.btnQuanLyLoaiPhong.Location = new System.Drawing.Point(310, 58);
        this.btnQuanLyLoaiPhong.Name = "btnQuanLyLoaiPhong";
        this.btnQuanLyLoaiPhong.Size = new System.Drawing.Size(160, 27);
        this.btnQuanLyLoaiPhong.TabIndex = 4;
        this.btnQuanLyLoaiPhong.Text = "Quản lý Loại phòng...";
        this.btnQuanLyLoaiPhong.UseVisualStyleBackColor = true;
        this.btnQuanLyLoaiPhong.Click += new System.EventHandler(this.btnQuanLyLoaiPhong_Click);
        //
        // lblTinhTrang
        //
        this.lblTinhTrang.AutoSize = true;
        this.lblTinhTrang.Location = new System.Drawing.Point(485, 10);
        this.lblTinhTrang.Name = "lblTinhTrang";
        this.lblTinhTrang.Text = "Tình trạng";
        //
        // cboTinhTrang
        //
        this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboTinhTrang.Items.AddRange(new object[] { "Trống", "Đang ở", "Đang dọn" });
        this.cboTinhTrang.Location = new System.Drawing.Point(485, 28);
        this.cboTinhTrang.Name = "cboTinhTrang";
        this.cboTinhTrang.Size = new System.Drawing.Size(120, 23);
        this.cboTinhTrang.TabIndex = 5;
        //
        // picHinhAnh
        //
        this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.picHinhAnh.Location = new System.Drawing.Point(620, 10);
        this.picHinhAnh.Name = "picHinhAnh";
        this.picHinhAnh.Size = new System.Drawing.Size(105, 75);
        this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picHinhAnh.TabStop = false;
        //
        // btnChonAnh
        //
        this.btnChonAnh.Location = new System.Drawing.Point(620, 90);
        this.btnChonAnh.Name = "btnChonAnh";
        this.btnChonAnh.Size = new System.Drawing.Size(105, 27);
        this.btnChonAnh.TabIndex = 6;
        this.btnChonAnh.Text = "Chọn ảnh...";
        this.btnChonAnh.UseVisualStyleBackColor = true;
        this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
        //
        // txtHinhAnh
        //
        this.txtHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.txtHinhAnh.Location = new System.Drawing.Point(620, 122);
        this.txtHinhAnh.Name = "txtHinhAnh";
        this.txtHinhAnh.ReadOnly = true;
        this.txtHinhAnh.Size = new System.Drawing.Size(105, 16);
        this.txtHinhAnh.TabStop = false;
        this.txtHinhAnh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        //
        // btnThem
        //
        this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnThem.Location = new System.Drawing.Point(740, 26);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(60, 27);
        this.btnThem.TabIndex = 7;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
        //
        // btnSua
        //
        this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSua.Location = new System.Drawing.Point(806, 26);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(60, 27);
        this.btnSua.TabIndex = 8;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
        //
        // btnXoa
        //
        this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnXoa.Location = new System.Drawing.Point(872, 26);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(60, 27);
        this.btnXoa.TabIndex = 9;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
        //
        // btnLamMoi
        //
        this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnLamMoi.Location = new System.Drawing.Point(938, 26);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(70, 27);
        this.btnLamMoi.TabIndex = 10;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = true;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
        //
        // cboLocLoaiPhong
        //
        this.cboLocLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocLoaiPhong.Location = new System.Drawing.Point(15, 150);
        this.cboLocLoaiPhong.Name = "cboLocLoaiPhong";
        this.cboLocLoaiPhong.Size = new System.Drawing.Size(180, 23);
        this.cboLocLoaiPhong.TabIndex = 11;
        //
        // cboLocTinhTrang
        //
        this.cboLocTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocTinhTrang.Items.AddRange(new object[] { "-- Tất cả --", "Trống", "Đang ở", "Đang dọn" });
        this.cboLocTinhTrang.Location = new System.Drawing.Point(205, 150);
        this.cboLocTinhTrang.Name = "cboLocTinhTrang";
        this.cboLocTinhTrang.Size = new System.Drawing.Size(160, 23);
        this.cboLocTinhTrang.TabIndex = 12;
        //
        // btnTimKiem
        //
        this.btnTimKiem.Location = new System.Drawing.Point(375, 148);
        this.btnTimKiem.Name = "btnTimKiem";
        this.btnTimKiem.Size = new System.Drawing.Size(90, 27);
        this.btnTimKiem.TabIndex = 13;
        this.btnTimKiem.Text = "Tìm kiếm";
        this.btnTimKiem.UseVisualStyleBackColor = true;
        this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
        //
        // btnHienTatCa
        //
        this.btnHienTatCa.Location = new System.Drawing.Point(475, 148);
        this.btnHienTatCa.Name = "btnHienTatCa";
        this.btnHienTatCa.Size = new System.Drawing.Size(90, 27);
        this.btnHienTatCa.TabIndex = 14;
        this.btnHienTatCa.Text = "Hiện tất cả";
        this.btnHienTatCa.UseVisualStyleBackColor = true;
        this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
        //
        // dgvPhong
        //
        this.dgvPhong.AllowUserToAddRows = false;
        this.dgvPhong.AllowUserToDeleteRows = false;
        this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvPhong.Location = new System.Drawing.Point(15, 185);
        this.dgvPhong.MultiSelect = false;
        this.dgvPhong.Name = "dgvPhong";
        this.dgvPhong.ReadOnly = true;
        this.dgvPhong.RowHeadersWidth = 25;
        this.dgvPhong.RowTemplate.Height = 60;
        this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvPhong.Size = new System.Drawing.Size(993, 335);
        this.dgvPhong.TabIndex = 15;
        this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1023, 535);
        this.Controls.Add(this.dgvPhong);
        this.Controls.Add(this.btnHienTatCa);
        this.Controls.Add(this.btnTimKiem);
        this.Controls.Add(this.cboLocTinhTrang);
        this.Controls.Add(this.cboLocLoaiPhong);
        this.Controls.Add(this.btnLamMoi);
        this.Controls.Add(this.btnXoa);
        this.Controls.Add(this.btnSua);
        this.Controls.Add(this.btnThem);
        this.Controls.Add(this.txtHinhAnh);
        this.Controls.Add(this.btnChonAnh);
        this.Controls.Add(this.picHinhAnh);
        this.Controls.Add(this.cboTinhTrang);
        this.Controls.Add(this.lblTinhTrang);
        this.Controls.Add(this.btnQuanLyLoaiPhong);
        this.Controls.Add(this.cboLoaiPhong);
        this.Controls.Add(this.lblLoaiPhong);
        this.Controls.Add(this.numTangSo);
        this.Controls.Add(this.lblTangSo);
        this.Controls.Add(this.txtSoPhong);
        this.Controls.Add(this.lblSoPhong);
        this.Controls.Add(this.txtMaPhong);
        this.Controls.Add(this.lblMaPhong);
        this.MinimumSize = new System.Drawing.Size(1039, 450);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản Lý Phòng - Sunrise Homestay";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        ((System.ComponentModel.ISupportInitialize)(this.numTangSo)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblMaPhong;
    private System.Windows.Forms.TextBox txtMaPhong;
    private System.Windows.Forms.Label lblSoPhong;
    private System.Windows.Forms.TextBox txtSoPhong;
    private System.Windows.Forms.Label lblTangSo;
    private System.Windows.Forms.NumericUpDown numTangSo;
    private System.Windows.Forms.Label lblLoaiPhong;
    private System.Windows.Forms.ComboBox cboLoaiPhong;
    private System.Windows.Forms.Button btnQuanLyLoaiPhong;
    private System.Windows.Forms.Label lblTinhTrang;
    private System.Windows.Forms.ComboBox cboTinhTrang;
    private System.Windows.Forms.PictureBox picHinhAnh;
    private System.Windows.Forms.Button btnChonAnh;
    private System.Windows.Forms.TextBox txtHinhAnh;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.ComboBox cboLocLoaiPhong;
    private System.Windows.Forms.ComboBox cboLocTinhTrang;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnHienTatCa;
    private System.Windows.Forms.DataGridView dgvPhong;
}
