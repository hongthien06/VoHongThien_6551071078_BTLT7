namespace Cau4_QuanLyLichKham;

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
        this.lblTenBenhNhan = new System.Windows.Forms.Label();
        this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
        this.lblMaLich = new System.Windows.Forms.Label();
        this.txtMaLich = new System.Windows.Forms.TextBox();
        this.lblSDT = new System.Windows.Forms.Label();
        this.txtSDT = new System.Windows.Forms.TextBox();
        this.lblNgayKham = new System.Windows.Forms.Label();
        this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
        this.lblGioKham = new System.Windows.Forms.Label();
        this.dtpGioKham = new System.Windows.Forms.DateTimePicker();
        this.lblBacSi = new System.Windows.Forms.Label();
        this.cboBacSi = new System.Windows.Forms.ComboBox();
        this.btnQuanLyBacSi = new System.Windows.Forms.Button();
        this.lblTrangThai = new System.Windows.Forms.Label();
        this.cboTrangThai = new System.Windows.Forms.ComboBox();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.lblTuNgay = new System.Windows.Forms.Label();
        this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
        this.lblDenNgay = new System.Windows.Forms.Label();
        this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
        this.cboLocBacSi = new System.Windows.Forms.ComboBox();
        this.btnTimKiem = new System.Windows.Forms.Button();
        this.btnHienTatCa = new System.Windows.Forms.Button();
        this.dgvLichKham = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).BeginInit();
        this.SuspendLayout();
        //
        // lblTenBenhNhan
        //
        this.lblTenBenhNhan.AutoSize = true;
        this.lblTenBenhNhan.Location = new System.Drawing.Point(15, 18);
        this.lblTenBenhNhan.Name = "lblTenBenhNhan";
        this.lblTenBenhNhan.Text = "Tên bệnh nhân";
        //
        // txtTenBenhNhan
        //
        this.txtTenBenhNhan.Location = new System.Drawing.Point(120, 15);
        this.txtTenBenhNhan.Name = "txtTenBenhNhan";
        this.txtTenBenhNhan.Size = new System.Drawing.Size(185, 23);
        this.txtTenBenhNhan.TabIndex = 0;
        //
        // lblMaLich
        //
        this.lblMaLich.AutoSize = true;
        this.lblMaLich.Location = new System.Drawing.Point(330, 18);
        this.lblMaLich.Name = "lblMaLich";
        this.lblMaLich.Text = "Mã lịch";
        //
        // txtMaLich
        //
        this.txtMaLich.Location = new System.Drawing.Point(385, 15);
        this.txtMaLich.Name = "txtMaLich";
        this.txtMaLich.ReadOnly = true;
        this.txtMaLich.Size = new System.Drawing.Size(65, 23);
        this.txtMaLich.TabStop = false;
        //
        // lblSDT
        //
        this.lblSDT.AutoSize = true;
        this.lblSDT.Location = new System.Drawing.Point(15, 68);
        this.lblSDT.Name = "lblSDT";
        this.lblSDT.Text = "Số điện thoại";
        //
        // txtSDT
        //
        this.txtSDT.Location = new System.Drawing.Point(120, 65);
        this.txtSDT.MaxLength = 15;
        this.txtSDT.Name = "txtSDT";
        this.txtSDT.Size = new System.Drawing.Size(185, 23);
        this.txtSDT.TabIndex = 1;
        //
        // lblNgayKham
        //
        this.lblNgayKham.AutoSize = true;
        this.lblNgayKham.Location = new System.Drawing.Point(15, 100);
        this.lblNgayKham.Name = "lblNgayKham";
        this.lblNgayKham.Text = "Ngày khám";
        //
        // dtpNgayKham
        //
        this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpNgayKham.Location = new System.Drawing.Point(120, 97);
        this.dtpNgayKham.Name = "dtpNgayKham";
        this.dtpNgayKham.Size = new System.Drawing.Size(185, 23);
        this.dtpNgayKham.TabIndex = 2;
        //
        // lblGioKham
        //
        this.lblGioKham.AutoSize = true;
        this.lblGioKham.Location = new System.Drawing.Point(330, 47);
        this.lblGioKham.Name = "lblGioKham";
        this.lblGioKham.Text = "Giờ khám";
        //
        // dtpGioKham
        //
        this.dtpGioKham.Format = System.Windows.Forms.DateTimePickerFormat.Time;
        this.dtpGioKham.Location = new System.Drawing.Point(330, 65);
        this.dtpGioKham.Name = "dtpGioKham";
        this.dtpGioKham.ShowUpDown = true;
        this.dtpGioKham.Size = new System.Drawing.Size(120, 23);
        this.dtpGioKham.TabIndex = 3;
        //
        // lblBacSi
        //
        this.lblBacSi.AutoSize = true;
        this.lblBacSi.Location = new System.Drawing.Point(475, 47);
        this.lblBacSi.Name = "lblBacSi";
        this.lblBacSi.Text = "Bác sĩ";
        //
        // cboBacSi
        //
        this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboBacSi.Location = new System.Drawing.Point(475, 65);
        this.cboBacSi.Name = "cboBacSi";
        this.cboBacSi.Size = new System.Drawing.Size(290, 23);
        this.cboBacSi.TabIndex = 4;
        //
        // btnQuanLyBacSi
        //
        this.btnQuanLyBacSi.Location = new System.Drawing.Point(475, 95);
        this.btnQuanLyBacSi.Name = "btnQuanLyBacSi";
        this.btnQuanLyBacSi.Size = new System.Drawing.Size(150, 27);
        this.btnQuanLyBacSi.TabIndex = 5;
        this.btnQuanLyBacSi.Text = "Quản lý Bác sĩ...";
        this.btnQuanLyBacSi.UseVisualStyleBackColor = true;
        this.btnQuanLyBacSi.Click += new System.EventHandler(this.btnQuanLyBacSi_Click);
        //
        // lblTrangThai
        //
        this.lblTrangThai.AutoSize = true;
        this.lblTrangThai.Location = new System.Drawing.Point(790, 47);
        this.lblTrangThai.Name = "lblTrangThai";
        this.lblTrangThai.Text = "Trạng thái";
        //
        // cboTrangThai
        //
        this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboTrangThai.Items.AddRange(new object[] { "Chờ khám", "Đã khám", "Đã hủy" });
        this.cboTrangThai.Location = new System.Drawing.Point(790, 65);
        this.cboTrangThai.Name = "cboTrangThai";
        this.cboTrangThai.Size = new System.Drawing.Size(150, 23);
        this.cboTrangThai.TabIndex = 6;
        //
        // btnThem
        //
        this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnThem.Location = new System.Drawing.Point(735, 12);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(65, 27);
        this.btnThem.TabIndex = 7;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
        //
        // btnSua
        //
        this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSua.Location = new System.Drawing.Point(806, 12);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(65, 27);
        this.btnSua.TabIndex = 8;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
        //
        // btnXoa
        //
        this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnXoa.Location = new System.Drawing.Point(877, 12);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(65, 27);
        this.btnXoa.TabIndex = 9;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
        //
        // btnLamMoi
        //
        this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnLamMoi.Location = new System.Drawing.Point(948, 12);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(65, 27);
        this.btnLamMoi.TabIndex = 10;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = true;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
        //
        // lblTuNgay
        //
        this.lblTuNgay.AutoSize = true;
        this.lblTuNgay.Location = new System.Drawing.Point(15, 148);
        this.lblTuNgay.Name = "lblTuNgay";
        this.lblTuNgay.Text = "Từ ngày";
        //
        // dtpTuNgay
        //
        this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpTuNgay.Location = new System.Drawing.Point(70, 145);
        this.dtpTuNgay.Name = "dtpTuNgay";
        this.dtpTuNgay.Size = new System.Drawing.Size(115, 23);
        this.dtpTuNgay.TabIndex = 11;
        //
        // lblDenNgay
        //
        this.lblDenNgay.AutoSize = true;
        this.lblDenNgay.Location = new System.Drawing.Point(200, 148);
        this.lblDenNgay.Name = "lblDenNgay";
        this.lblDenNgay.Text = "Đến ngày";
        //
        // dtpDenNgay
        //
        this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpDenNgay.Location = new System.Drawing.Point(262, 145);
        this.dtpDenNgay.Name = "dtpDenNgay";
        this.dtpDenNgay.Size = new System.Drawing.Size(115, 23);
        this.dtpDenNgay.TabIndex = 12;
        //
        // cboLocBacSi
        //
        this.cboLocBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocBacSi.Location = new System.Drawing.Point(392, 145);
        this.cboLocBacSi.Name = "cboLocBacSi";
        this.cboLocBacSi.Size = new System.Drawing.Size(280, 23);
        this.cboLocBacSi.TabIndex = 13;
        //
        // btnTimKiem
        //
        this.btnTimKiem.Location = new System.Drawing.Point(682, 143);
        this.btnTimKiem.Name = "btnTimKiem";
        this.btnTimKiem.Size = new System.Drawing.Size(90, 27);
        this.btnTimKiem.TabIndex = 14;
        this.btnTimKiem.Text = "Tìm kiếm";
        this.btnTimKiem.UseVisualStyleBackColor = true;
        this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
        //
        // btnHienTatCa
        //
        this.btnHienTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnHienTatCa.Location = new System.Drawing.Point(923, 143);
        this.btnHienTatCa.Name = "btnHienTatCa";
        this.btnHienTatCa.Size = new System.Drawing.Size(90, 27);
        this.btnHienTatCa.TabIndex = 15;
        this.btnHienTatCa.Text = "Hiện tất cả";
        this.btnHienTatCa.UseVisualStyleBackColor = true;
        this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
        //
        // dgvLichKham
        //
        this.dgvLichKham.AllowUserToAddRows = false;
        this.dgvLichKham.AllowUserToDeleteRows = false;
        this.dgvLichKham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        this.dgvLichKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvLichKham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        this.dgvLichKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvLichKham.Location = new System.Drawing.Point(15, 182);
        this.dgvLichKham.MultiSelect = false;
        this.dgvLichKham.Name = "dgvLichKham";
        this.dgvLichKham.ReadOnly = true;
        this.dgvLichKham.RowHeadersWidth = 25;
        this.dgvLichKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvLichKham.Size = new System.Drawing.Size(998, 335);
        this.dgvLichKham.TabIndex = 16;
        this.dgvLichKham.SelectionChanged += new System.EventHandler(this.dgvLichKham_SelectionChanged);
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1028, 532);
        this.Controls.Add(this.dgvLichKham);
        this.Controls.Add(this.btnHienTatCa);
        this.Controls.Add(this.btnTimKiem);
        this.Controls.Add(this.cboLocBacSi);
        this.Controls.Add(this.dtpDenNgay);
        this.Controls.Add(this.lblDenNgay);
        this.Controls.Add(this.dtpTuNgay);
        this.Controls.Add(this.lblTuNgay);
        this.Controls.Add(this.btnLamMoi);
        this.Controls.Add(this.btnXoa);
        this.Controls.Add(this.btnSua);
        this.Controls.Add(this.btnThem);
        this.Controls.Add(this.cboTrangThai);
        this.Controls.Add(this.lblTrangThai);
        this.Controls.Add(this.btnQuanLyBacSi);
        this.Controls.Add(this.cboBacSi);
        this.Controls.Add(this.lblBacSi);
        this.Controls.Add(this.dtpGioKham);
        this.Controls.Add(this.lblGioKham);
        this.Controls.Add(this.dtpNgayKham);
        this.Controls.Add(this.lblNgayKham);
        this.Controls.Add(this.txtSDT);
        this.Controls.Add(this.lblSDT);
        this.Controls.Add(this.txtMaLich);
        this.Controls.Add(this.lblMaLich);
        this.Controls.Add(this.txtTenBenhNhan);
        this.Controls.Add(this.lblTenBenhNhan);
        this.MinimumSize = new System.Drawing.Size(1044, 450);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản Lý Lịch Khám Bệnh - An Khang Clinic";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblTenBenhNhan;
    private System.Windows.Forms.TextBox txtTenBenhNhan;
    private System.Windows.Forms.Label lblMaLich;
    private System.Windows.Forms.TextBox txtMaLich;
    private System.Windows.Forms.Label lblSDT;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Label lblNgayKham;
    private System.Windows.Forms.DateTimePicker dtpNgayKham;
    private System.Windows.Forms.Label lblGioKham;
    private System.Windows.Forms.DateTimePicker dtpGioKham;
    private System.Windows.Forms.Label lblBacSi;
    private System.Windows.Forms.ComboBox cboBacSi;
    private System.Windows.Forms.Button btnQuanLyBacSi;
    private System.Windows.Forms.Label lblTrangThai;
    private System.Windows.Forms.ComboBox cboTrangThai;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Label lblTuNgay;
    private System.Windows.Forms.DateTimePicker dtpTuNgay;
    private System.Windows.Forms.Label lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpDenNgay;
    private System.Windows.Forms.ComboBox cboLocBacSi;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnHienTatCa;
    private System.Windows.Forms.DataGridView dgvLichKham;
}
