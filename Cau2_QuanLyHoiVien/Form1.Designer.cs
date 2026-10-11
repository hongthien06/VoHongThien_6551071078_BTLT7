namespace Cau2_QuanLyHoiVien;

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
        this.lblMaHV = new System.Windows.Forms.Label();
        this.txtMaHV = new System.Windows.Forms.TextBox();
        this.lblHoTen = new System.Windows.Forms.Label();
        this.txtHoTen = new System.Windows.Forms.TextBox();
        this.lblSDT = new System.Windows.Forms.Label();
        this.txtSDT = new System.Windows.Forms.TextBox();
        this.lblEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblNgaySinh = new System.Windows.Forms.Label();
        this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
        this.lblHangThanhVien = new System.Windows.Forms.Label();
        this.cboHangThanhVien = new System.Windows.Forms.ComboBox();
        this.chkTrangThai = new System.Windows.Forms.CheckBox();
        this.grpGioiTinh = new System.Windows.Forms.GroupBox();
        this.rdoNam = new System.Windows.Forms.RadioButton();
        this.rdoNu = new System.Windows.Forms.RadioButton();
        this.lblNgayDangKy = new System.Windows.Forms.Label();
        this.lblNgayDangKyValue = new System.Windows.Forms.Label();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.txtTimTen = new System.Windows.Forms.TextBox();
        this.lblLocHang = new System.Windows.Forms.Label();
        this.cboLocHang = new System.Windows.Forms.ComboBox();
        this.btnTimKiem = new System.Windows.Forms.Button();
        this.btnHienTatCa = new System.Windows.Forms.Button();
        this.dgvHoiVien = new System.Windows.Forms.DataGridView();
        this.grpGioiTinh.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvHoiVien)).BeginInit();
        this.SuspendLayout();
        //
        // lblMaHV
        //
        this.lblMaHV.AutoSize = true;
        this.lblMaHV.Location = new System.Drawing.Point(15, 18);
        this.lblMaHV.Name = "lblMaHV";
        this.lblMaHV.Text = "Mã hội viên";
        //
        // txtMaHV
        //
        this.txtMaHV.Location = new System.Drawing.Point(125, 15);
        this.txtMaHV.Name = "txtMaHV";
        this.txtMaHV.PlaceholderText = "ReadOnly";
        this.txtMaHV.ReadOnly = true;
        this.txtMaHV.Size = new System.Drawing.Size(180, 23);
        this.txtMaHV.TabIndex = 0;
        this.txtMaHV.TabStop = false;
        //
        // lblHoTen
        //
        this.lblHoTen.AutoSize = true;
        this.lblHoTen.Location = new System.Drawing.Point(15, 50);
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.Text = "Họ tên";
        //
        // txtHoTen
        //
        this.txtHoTen.Location = new System.Drawing.Point(125, 47);
        this.txtHoTen.Name = "txtHoTen";
        this.txtHoTen.Size = new System.Drawing.Size(180, 23);
        this.txtHoTen.TabIndex = 1;
        //
        // lblSDT
        //
        this.lblSDT.AutoSize = true;
        this.lblSDT.Location = new System.Drawing.Point(15, 82);
        this.lblSDT.Name = "lblSDT";
        this.lblSDT.Text = "Số điện thoại";
        //
        // txtSDT
        //
        this.txtSDT.Location = new System.Drawing.Point(125, 79);
        this.txtSDT.MaxLength = 15;
        this.txtSDT.Name = "txtSDT";
        this.txtSDT.Size = new System.Drawing.Size(180, 23);
        this.txtSDT.TabIndex = 2;
        //
        // lblEmail
        //
        this.lblEmail.AutoSize = true;
        this.lblEmail.Location = new System.Drawing.Point(15, 114);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Text = "Email";
        //
        // txtEmail
        //
        this.txtEmail.Location = new System.Drawing.Point(125, 111);
        this.txtEmail.MaxLength = 100;
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(180, 23);
        this.txtEmail.TabIndex = 3;
        //
        // lblNgaySinh
        //
        this.lblNgaySinh.AutoSize = true;
        this.lblNgaySinh.Location = new System.Drawing.Point(15, 146);
        this.lblNgaySinh.Name = "lblNgaySinh";
        this.lblNgaySinh.Text = "Ngày sinh";
        //
        // dtpNgaySinh
        //
        this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpNgaySinh.Location = new System.Drawing.Point(125, 143);
        this.dtpNgaySinh.Name = "dtpNgaySinh";
        this.dtpNgaySinh.Size = new System.Drawing.Size(180, 23);
        this.dtpNgaySinh.TabIndex = 4;
        //
        // lblHangThanhVien
        //
        this.lblHangThanhVien.AutoSize = true;
        this.lblHangThanhVien.Location = new System.Drawing.Point(15, 178);
        this.lblHangThanhVien.Name = "lblHangThanhVien";
        this.lblHangThanhVien.Text = "Hạng thành viên";
        //
        // cboHangThanhVien
        //
        this.cboHangThanhVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboHangThanhVien.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
        this.cboHangThanhVien.Location = new System.Drawing.Point(125, 175);
        this.cboHangThanhVien.Name = "cboHangThanhVien";
        this.cboHangThanhVien.Size = new System.Drawing.Size(180, 23);
        this.cboHangThanhVien.TabIndex = 5;
        //
        // chkTrangThai
        //
        this.chkTrangThai.AutoSize = true;
        this.chkTrangThai.Checked = true;
        this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkTrangThai.Location = new System.Drawing.Point(15, 210);
        this.chkTrangThai.Name = "chkTrangThai";
        this.chkTrangThai.TabIndex = 6;
        this.chkTrangThai.Text = "Đang hoạt động";
        this.chkTrangThai.UseVisualStyleBackColor = true;
        //
        // grpGioiTinh
        //
        this.grpGioiTinh.Controls.Add(this.rdoNam);
        this.grpGioiTinh.Controls.Add(this.rdoNu);
        this.grpGioiTinh.Location = new System.Drawing.Point(345, 10);
        this.grpGioiTinh.Name = "grpGioiTinh";
        this.grpGioiTinh.Size = new System.Drawing.Size(230, 60);
        this.grpGioiTinh.TabIndex = 7;
        this.grpGioiTinh.TabStop = false;
        this.grpGioiTinh.Text = "Giới tính";
        //
        // rdoNam
        //
        this.rdoNam.AutoSize = true;
        this.rdoNam.Checked = true;
        this.rdoNam.Location = new System.Drawing.Point(20, 25);
        this.rdoNam.Name = "rdoNam";
        this.rdoNam.TabIndex = 0;
        this.rdoNam.TabStop = true;
        this.rdoNam.Text = "Nam";
        this.rdoNam.UseVisualStyleBackColor = true;
        //
        // rdoNu
        //
        this.rdoNu.AutoSize = true;
        this.rdoNu.Location = new System.Drawing.Point(120, 25);
        this.rdoNu.Name = "rdoNu";
        this.rdoNu.TabIndex = 1;
        this.rdoNu.Text = "Nữ";
        this.rdoNu.UseVisualStyleBackColor = true;
        //
        // lblNgayDangKy
        //
        this.lblNgayDangKy.AutoSize = true;
        this.lblNgayDangKy.Location = new System.Drawing.Point(345, 85);
        this.lblNgayDangKy.Name = "lblNgayDangKy";
        this.lblNgayDangKy.Text = "Ngày đăng ký:";
        //
        // lblNgayDangKyValue
        //
        this.lblNgayDangKyValue.AutoSize = true;
        this.lblNgayDangKyValue.Location = new System.Drawing.Point(440, 85);
        this.lblNgayDangKyValue.Name = "lblNgayDangKyValue";
        this.lblNgayDangKyValue.Text = "---";
        //
        // btnThem
        //
        this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnThem.Location = new System.Drawing.Point(775, 12);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(115, 32);
        this.btnThem.TabIndex = 8;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
        //
        // btnSua
        //
        this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSua.Location = new System.Drawing.Point(775, 52);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(115, 32);
        this.btnSua.TabIndex = 9;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
        //
        // btnXoa
        //
        this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnXoa.Location = new System.Drawing.Point(775, 92);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(115, 32);
        this.btnXoa.TabIndex = 10;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
        //
        // btnLamMoi
        //
        this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnLamMoi.Location = new System.Drawing.Point(775, 132);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(115, 32);
        this.btnLamMoi.TabIndex = 11;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = true;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
        //
        // txtTimTen
        //
        this.txtTimTen.Location = new System.Drawing.Point(15, 250);
        this.txtTimTen.Name = "txtTimTen";
        this.txtTimTen.PlaceholderText = "Nhập họ tên cần tìm...";
        this.txtTimTen.Size = new System.Drawing.Size(290, 23);
        this.txtTimTen.TabIndex = 12;
        this.txtTimTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimTen_KeyDown);
        //
        // lblLocHang
        //
        this.lblLocHang.AutoSize = true;
        this.lblLocHang.Location = new System.Drawing.Point(345, 253);
        this.lblLocHang.Name = "lblLocHang";
        this.lblLocHang.Text = "Hạng thành viên";
        //
        // cboLocHang
        //
        this.cboLocHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLocHang.Items.AddRange(new object[] { "-- Tất cả --", "Basic", "VIP", "Premium" });
        this.cboLocHang.Location = new System.Drawing.Point(455, 250);
        this.cboLocHang.Name = "cboLocHang";
        this.cboLocHang.Size = new System.Drawing.Size(160, 23);
        this.cboLocHang.TabIndex = 13;
        //
        // btnHienTatCa
        //
        this.btnHienTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnHienTatCa.Location = new System.Drawing.Point(650, 247);
        this.btnHienTatCa.Name = "btnHienTatCa";
        this.btnHienTatCa.Size = new System.Drawing.Size(115, 30);
        this.btnHienTatCa.TabIndex = 15;
        this.btnHienTatCa.Text = "Hiện tất cả";
        this.btnHienTatCa.UseVisualStyleBackColor = true;
        this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
        //
        // btnTimKiem
        //
        this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnTimKiem.Location = new System.Drawing.Point(775, 247);
        this.btnTimKiem.Name = "btnTimKiem";
        this.btnTimKiem.Size = new System.Drawing.Size(115, 30);
        this.btnTimKiem.TabIndex = 14;
        this.btnTimKiem.Text = "Tìm kiếm";
        this.btnTimKiem.UseVisualStyleBackColor = true;
        this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
        //
        // dgvHoiVien
        //
        this.dgvHoiVien.AllowUserToAddRows = false;
        this.dgvHoiVien.AllowUserToDeleteRows = false;
        this.dgvHoiVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        this.dgvHoiVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvHoiVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        this.dgvHoiVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvHoiVien.Location = new System.Drawing.Point(15, 288);
        this.dgvHoiVien.MultiSelect = false;
        this.dgvHoiVien.Name = "dgvHoiVien";
        this.dgvHoiVien.ReadOnly = true;
        this.dgvHoiVien.RowHeadersWidth = 25;
        this.dgvHoiVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvHoiVien.Size = new System.Drawing.Size(875, 220);
        this.dgvHoiVien.TabIndex = 16;
        this.dgvHoiVien.SelectionChanged += new System.EventHandler(this.dgvHoiVien_SelectionChanged);
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(905, 523);
        this.Controls.Add(this.dgvHoiVien);
        this.Controls.Add(this.btnTimKiem);
        this.Controls.Add(this.btnHienTatCa);
        this.Controls.Add(this.cboLocHang);
        this.Controls.Add(this.lblLocHang);
        this.Controls.Add(this.txtTimTen);
        this.Controls.Add(this.btnLamMoi);
        this.Controls.Add(this.btnXoa);
        this.Controls.Add(this.btnSua);
        this.Controls.Add(this.btnThem);
        this.Controls.Add(this.lblNgayDangKyValue);
        this.Controls.Add(this.lblNgayDangKy);
        this.Controls.Add(this.grpGioiTinh);
        this.Controls.Add(this.chkTrangThai);
        this.Controls.Add(this.cboHangThanhVien);
        this.Controls.Add(this.lblHangThanhVien);
        this.Controls.Add(this.dtpNgaySinh);
        this.Controls.Add(this.lblNgaySinh);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.txtSDT);
        this.Controls.Add(this.lblSDT);
        this.Controls.Add(this.txtHoTen);
        this.Controls.Add(this.lblHoTen);
        this.Controls.Add(this.txtMaHV);
        this.Controls.Add(this.lblMaHV);
        this.MinimumSize = new System.Drawing.Size(920, 450);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản Lý Hội Viên Phòng Gym FitZone";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        this.grpGioiTinh.ResumeLayout(false);
        this.grpGioiTinh.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dgvHoiVien)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblMaHV;
    private System.Windows.Forms.TextBox txtMaHV;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblSDT;
    private System.Windows.Forms.TextBox txtSDT;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblNgaySinh;
    private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    private System.Windows.Forms.Label lblHangThanhVien;
    private System.Windows.Forms.ComboBox cboHangThanhVien;
    private System.Windows.Forms.CheckBox chkTrangThai;
    private System.Windows.Forms.GroupBox grpGioiTinh;
    private System.Windows.Forms.RadioButton rdoNam;
    private System.Windows.Forms.RadioButton rdoNu;
    private System.Windows.Forms.Label lblNgayDangKy;
    private System.Windows.Forms.Label lblNgayDangKyValue;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.TextBox txtTimTen;
    private System.Windows.Forms.Label lblLocHang;
    private System.Windows.Forms.ComboBox cboLocHang;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnHienTatCa;
    private System.Windows.Forms.DataGridView dgvHoiVien;
}
