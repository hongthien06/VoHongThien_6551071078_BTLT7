namespace Cau1_QuanLyTheLoaiSach;

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
        this.lblMaTL = new System.Windows.Forms.Label();
        this.txtMaTL = new System.Windows.Forms.TextBox();
        this.lblTenTheLoai = new System.Windows.Forms.Label();
        this.txtTenTheLoai = new System.Windows.Forms.TextBox();
        this.lblMoTa = new System.Windows.Forms.Label();
        this.txtMoTa = new System.Windows.Forms.TextBox();
        this.lblSoLuongSach = new System.Windows.Forms.Label();
        this.numSoLuongSach = new System.Windows.Forms.NumericUpDown();
        this.lblNgayTao = new System.Windows.Forms.Label();
        this.lblNgayTaoValue = new System.Windows.Forms.Label();
        this.btnThem = new System.Windows.Forms.Button();
        this.btnSua = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnLamMoi = new System.Windows.Forms.Button();
        this.txtTimKiem = new System.Windows.Forms.TextBox();
        this.btnTimKiem = new System.Windows.Forms.Button();
        this.btnHienTatCa = new System.Windows.Forms.Button();
        this.dgvTheLoai = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.numSoLuongSach)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
        this.SuspendLayout();
        //
        // lblMaTL
        //
        this.lblMaTL.AutoSize = true;
        this.lblMaTL.Location = new System.Drawing.Point(15, 18);
        this.lblMaTL.Name = "lblMaTL";
        this.lblMaTL.Text = "Mã thể loại";
        //
        // txtMaTL
        //
        this.txtMaTL.Location = new System.Drawing.Point(110, 15);
        this.txtMaTL.Name = "txtMaTL";
        this.txtMaTL.PlaceholderText = "ReadOnly";
        this.txtMaTL.ReadOnly = true;
        this.txtMaTL.Size = new System.Drawing.Size(260, 23);
        this.txtMaTL.TabIndex = 0;
        this.txtMaTL.TabStop = false;
        //
        // lblTenTheLoai
        //
        this.lblTenTheLoai.AutoSize = true;
        this.lblTenTheLoai.Location = new System.Drawing.Point(15, 50);
        this.lblTenTheLoai.Name = "lblTenTheLoai";
        this.lblTenTheLoai.Text = "Tên thể loại";
        //
        // txtTenTheLoai
        //
        this.txtTenTheLoai.Location = new System.Drawing.Point(110, 47);
        this.txtTenTheLoai.Name = "txtTenTheLoai";
        this.txtTenTheLoai.Size = new System.Drawing.Size(260, 23);
        this.txtTenTheLoai.TabIndex = 1;
        //
        // lblMoTa
        //
        this.lblMoTa.AutoSize = true;
        this.lblMoTa.Location = new System.Drawing.Point(15, 82);
        this.lblMoTa.Name = "lblMoTa";
        this.lblMoTa.Text = "Mô tả";
        //
        // txtMoTa
        //
        this.txtMoTa.Location = new System.Drawing.Point(110, 79);
        this.txtMoTa.Multiline = true;
        this.txtMoTa.Name = "txtMoTa";
        this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.txtMoTa.Size = new System.Drawing.Size(260, 75);
        this.txtMoTa.TabIndex = 2;
        //
        // lblSoLuongSach
        //
        this.lblSoLuongSach.AutoSize = true;
        this.lblSoLuongSach.Location = new System.Drawing.Point(15, 168);
        this.lblSoLuongSach.Name = "lblSoLuongSach";
        this.lblSoLuongSach.Text = "Số lượng sách";
        //
        // numSoLuongSach
        //
        this.numSoLuongSach.Location = new System.Drawing.Point(110, 165);
        this.numSoLuongSach.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        this.numSoLuongSach.Name = "numSoLuongSach";
        this.numSoLuongSach.Size = new System.Drawing.Size(90, 23);
        this.numSoLuongSach.TabIndex = 3;
        //
        // lblNgayTao
        //
        this.lblNgayTao.AutoSize = true;
        this.lblNgayTao.Location = new System.Drawing.Point(215, 168);
        this.lblNgayTao.Name = "lblNgayTao";
        this.lblNgayTao.Text = "Ngày tạo:";
        //
        // lblNgayTaoValue
        //
        this.lblNgayTaoValue.AutoSize = true;
        this.lblNgayTaoValue.Location = new System.Drawing.Point(275, 168);
        this.lblNgayTaoValue.Name = "lblNgayTaoValue";
        this.lblNgayTaoValue.Text = "---";
        //
        // btnThem
        //
        this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnThem.Location = new System.Drawing.Point(520, 12);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(85, 28);
        this.btnThem.TabIndex = 4;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
        //
        // btnSua
        //
        this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSua.Location = new System.Drawing.Point(615, 12);
        this.btnSua.Name = "btnSua";
        this.btnSua.Size = new System.Drawing.Size(85, 28);
        this.btnSua.TabIndex = 5;
        this.btnSua.Text = "Sửa";
        this.btnSua.UseVisualStyleBackColor = true;
        this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
        //
        // btnXoa
        //
        this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnXoa.Location = new System.Drawing.Point(710, 12);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(85, 28);
        this.btnXoa.TabIndex = 6;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
        //
        // btnLamMoi
        //
        this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnLamMoi.Location = new System.Drawing.Point(805, 12);
        this.btnLamMoi.Name = "btnLamMoi";
        this.btnLamMoi.Size = new System.Drawing.Size(85, 28);
        this.btnLamMoi.TabIndex = 7;
        this.btnLamMoi.Text = "Làm mới";
        this.btnLamMoi.UseVisualStyleBackColor = true;
        this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
        //
        // txtTimKiem
        //
        this.txtTimKiem.Location = new System.Drawing.Point(15, 205);
        this.txtTimKiem.Name = "txtTimKiem";
        this.txtTimKiem.PlaceholderText = "Nhập tên thể loại cần tìm...";
        this.txtTimKiem.Size = new System.Drawing.Size(270, 23);
        this.txtTimKiem.TabIndex = 8;
        this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
        //
        // btnTimKiem
        //
        this.btnTimKiem.Location = new System.Drawing.Point(300, 203);
        this.btnTimKiem.Name = "btnTimKiem";
        this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
        this.btnTimKiem.TabIndex = 9;
        this.btnTimKiem.Text = "Tìm kiếm";
        this.btnTimKiem.UseVisualStyleBackColor = true;
        this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
        //
        // btnHienTatCa
        //
        this.btnHienTatCa.Location = new System.Drawing.Point(410, 203);
        this.btnHienTatCa.Name = "btnHienTatCa";
        this.btnHienTatCa.Size = new System.Drawing.Size(100, 28);
        this.btnHienTatCa.TabIndex = 10;
        this.btnHienTatCa.Text = "Hiện tất cả";
        this.btnHienTatCa.UseVisualStyleBackColor = true;
        this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
        //
        // dgvTheLoai
        //
        this.dgvTheLoai.AllowUserToAddRows = false;
        this.dgvTheLoai.AllowUserToDeleteRows = false;
        this.dgvTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvTheLoai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
        this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvTheLoai.Location = new System.Drawing.Point(15, 242);
        this.dgvTheLoai.MultiSelect = false;
        this.dgvTheLoai.Name = "dgvTheLoai";
        this.dgvTheLoai.ReadOnly = true;
        this.dgvTheLoai.RowHeadersWidth = 25;
        this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvTheLoai.Size = new System.Drawing.Size(875, 230);
        this.dgvTheLoai.TabIndex = 11;
        this.dgvTheLoai.SelectionChanged += new System.EventHandler(this.dgvTheLoai_SelectionChanged);
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(905, 487);
        this.Controls.Add(this.dgvTheLoai);
        this.Controls.Add(this.btnHienTatCa);
        this.Controls.Add(this.btnTimKiem);
        this.Controls.Add(this.txtTimKiem);
        this.Controls.Add(this.btnLamMoi);
        this.Controls.Add(this.btnXoa);
        this.Controls.Add(this.btnSua);
        this.Controls.Add(this.btnThem);
        this.Controls.Add(this.lblNgayTaoValue);
        this.Controls.Add(this.lblNgayTao);
        this.Controls.Add(this.numSoLuongSach);
        this.Controls.Add(this.lblSoLuongSach);
        this.Controls.Add(this.txtMoTa);
        this.Controls.Add(this.lblMoTa);
        this.Controls.Add(this.txtTenTheLoai);
        this.Controls.Add(this.lblTenTheLoai);
        this.Controls.Add(this.txtMaTL);
        this.Controls.Add(this.lblMaTL);
        this.MinimumSize = new System.Drawing.Size(920, 420);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản Lý Thể Loại Sách - Tri Thức Books";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        ((System.ComponentModel.ISupportInitialize)(this.numSoLuongSach)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label lblMaTL;
    private System.Windows.Forms.TextBox txtMaTL;
    private System.Windows.Forms.Label lblTenTheLoai;
    private System.Windows.Forms.TextBox txtTenTheLoai;
    private System.Windows.Forms.Label lblMoTa;
    private System.Windows.Forms.TextBox txtMoTa;
    private System.Windows.Forms.Label lblSoLuongSach;
    private System.Windows.Forms.NumericUpDown numSoLuongSach;
    private System.Windows.Forms.Label lblNgayTao;
    private System.Windows.Forms.Label lblNgayTaoValue;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.TextBox txtTimKiem;
    private System.Windows.Forms.Button btnTimKiem;
    private System.Windows.Forms.Button btnHienTatCa;
    private System.Windows.Forms.DataGridView dgvTheLoai;
}
