namespace QuanLyDayDep
{
    partial class frmSanPham
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
            this.lblMaGiayDep = new System.Windows.Forms.Label();
            this.lblTenGiayDep = new System.Windows.Forms.Label();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.lblMaCo = new System.Windows.Forms.Label();
            this.lblMaChatLieu = new System.Windows.Forms.Label();
            this.lblMaMau = new System.Windows.Forms.Label();
            this.lblMaDoiTuong = new System.Windows.Forms.Label();
            this.lblMaMua = new System.Windows.Forms.Label();
            this.lblMaNuocSX = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();
            this.lblDonGiaNhap = new System.Windows.Forms.Label();
            this.lblDonGiaBan = new System.Windows.Forms.Label();
            this.txtMaGD = new System.Windows.Forms.TextBox();
            this.txtTenGD = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.dataGridView_SanPham = new System.Windows.Forms.DataGridView();
            this.MaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.cboMaCo = new System.Windows.Forms.ComboBox();
            this.cboMaCL = new System.Windows.Forms.ComboBox();
            this.cboMaMau = new System.Windows.Forms.ComboBox();
            this.cboMaDT = new System.Windows.Forms.ComboBox();
            this.cboMaMua = new System.Windows.Forms.ComboBox();
            this.cboMaNSX = new System.Windows.Forms.ComboBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnMo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaGiayDep
            // 
            this.lblMaGiayDep.AutoSize = true;
            this.lblMaGiayDep.Location = new System.Drawing.Point(45, 39);
            this.lblMaGiayDep.Name = "lblMaGiayDep";
            this.lblMaGiayDep.Size = new System.Drawing.Size(101, 20);
            this.lblMaGiayDep.TabIndex = 0;
            this.lblMaGiayDep.Text = "Mã Giày Dép";
            // 
            // lblTenGiayDep
            // 
            this.lblTenGiayDep.AutoSize = true;
            this.lblTenGiayDep.Location = new System.Drawing.Point(45, 74);
            this.lblTenGiayDep.Name = "lblTenGiayDep";
            this.lblTenGiayDep.Size = new System.Drawing.Size(106, 20);
            this.lblTenGiayDep.TabIndex = 1;
            this.lblTenGiayDep.Text = "Tên Giày Dép";
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Location = new System.Drawing.Point(45, 105);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(65, 20);
            this.lblMaLoai.TabIndex = 2;
            this.lblMaLoai.Text = "Mã Loại";
            // 
            // lblMaCo
            // 
            this.lblMaCo.AutoSize = true;
            this.lblMaCo.Location = new System.Drawing.Point(45, 143);
            this.lblMaCo.Name = "lblMaCo";
            this.lblMaCo.Size = new System.Drawing.Size(55, 20);
            this.lblMaCo.TabIndex = 3;
            this.lblMaCo.Text = "Mã Cỡ";
            // 
            // lblMaChatLieu
            // 
            this.lblMaChatLieu.AutoSize = true;
            this.lblMaChatLieu.Location = new System.Drawing.Point(45, 183);
            this.lblMaChatLieu.Name = "lblMaChatLieu";
            this.lblMaChatLieu.Size = new System.Drawing.Size(103, 20);
            this.lblMaChatLieu.TabIndex = 4;
            this.lblMaChatLieu.Text = "Mã Chất Liệu";
            // 
            // lblMaMau
            // 
            this.lblMaMau.AutoSize = true;
            this.lblMaMau.Location = new System.Drawing.Point(44, 215);
            this.lblMaMau.Name = "lblMaMau";
            this.lblMaMau.Size = new System.Drawing.Size(66, 20);
            this.lblMaMau.TabIndex = 5;
            this.lblMaMau.Text = "Mã Màu";
            // 
            // lblMaDoiTuong
            // 
            this.lblMaDoiTuong.AutoSize = true;
            this.lblMaDoiTuong.Location = new System.Drawing.Point(43, 245);
            this.lblMaDoiTuong.Name = "lblMaDoiTuong";
            this.lblMaDoiTuong.Size = new System.Drawing.Size(108, 20);
            this.lblMaDoiTuong.TabIndex = 6;
            this.lblMaDoiTuong.Text = "Mã Đối Tượng";
            // 
            // lblMaMua
            // 
            this.lblMaMua.AutoSize = true;
            this.lblMaMua.Location = new System.Drawing.Point(477, 33);
            this.lblMaMua.Name = "lblMaMua";
            this.lblMaMua.Size = new System.Drawing.Size(66, 20);
            this.lblMaMua.TabIndex = 7;
            this.lblMaMua.Text = "Mã Mùa";
            // 
            // lblMaNuocSX
            // 
            this.lblMaNuocSX.AutoSize = true;
            this.lblMaNuocSX.Location = new System.Drawing.Point(477, 64);
            this.lblMaNuocSX.Name = "lblMaNuocSX";
            this.lblMaNuocSX.Size = new System.Drawing.Size(98, 20);
            this.lblMaNuocSX.TabIndex = 8;
            this.lblMaNuocSX.Text = "Mã Nước SX";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(477, 96);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(78, 20);
            this.lblSoLuong.TabIndex = 9;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(481, 142);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(38, 20);
            this.lblAnh.TabIndex = 10;
            this.lblAnh.Text = "Ảnh";
            // 
            // lblDonGiaNhap
            // 
            this.lblDonGiaNhap.AutoSize = true;
            this.lblDonGiaNhap.Location = new System.Drawing.Point(481, 197);
            this.lblDonGiaNhap.Name = "lblDonGiaNhap";
            this.lblDonGiaNhap.Size = new System.Drawing.Size(110, 20);
            this.lblDonGiaNhap.TabIndex = 11;
            this.lblDonGiaNhap.Text = "Đơn Giá Nhập";
            // 
            // lblDonGiaBan
            // 
            this.lblDonGiaBan.AutoSize = true;
            this.lblDonGiaBan.Location = new System.Drawing.Point(477, 232);
            this.lblDonGiaBan.Name = "lblDonGiaBan";
            this.lblDonGiaBan.Size = new System.Drawing.Size(101, 20);
            this.lblDonGiaBan.TabIndex = 12;
            this.lblDonGiaBan.Text = "Đơn Giá Bán";
            // 
            // txtMaGD
            // 
            this.txtMaGD.Location = new System.Drawing.Point(187, 33);
            this.txtMaGD.Name = "txtMaGD";
            this.txtMaGD.Size = new System.Drawing.Size(121, 26);
            this.txtMaGD.TabIndex = 13;
            // 
            // txtTenGD
            // 
            this.txtTenGD.Location = new System.Drawing.Point(187, 74);
            this.txtTenGD.Name = "txtTenGD";
            this.txtTenGD.Size = new System.Drawing.Size(121, 26);
            this.txtTenGD.TabIndex = 14;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(622, 105);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(170, 26);
            this.txtSoLuong.TabIndex = 22;
            this.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(622, 136);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(170, 55);
            this.txtAnh.TabIndex = 23;
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(622, 197);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(170, 26);
            this.txtDonGiaNhap.TabIndex = 24;
            this.txtDonGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(622, 232);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(170, 26);
            this.txtDonGiaBan.TabIndex = 25;
            this.txtDonGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView_SanPham
            // 
            this.dataGridView_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGD,
            this.TenGD,
            this.MaLoai,
            this.MaCo,
            this.MaCL,
            this.MaMau,
            this.MaDT,
            this.MaMua,
            this.MaNSX,
            this.SoLuong,
            this.Anh,
            this.DonGiaNhap,
            this.DonGiaBan});
            this.dataGridView_SanPham.Location = new System.Drawing.Point(48, 315);
            this.dataGridView_SanPham.Name = "dataGridView_SanPham";
            this.dataGridView_SanPham.RowHeadersWidth = 62;
            this.dataGridView_SanPham.RowTemplate.Height = 28;
            this.dataGridView_SanPham.Size = new System.Drawing.Size(993, 205);
            this.dataGridView_SanPham.TabIndex = 26;
            this.dataGridView_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SanPham_CellClick);
            // 
            // MaGD
            // 
            this.MaGD.DataPropertyName = "MaGD";
            this.MaGD.HeaderText = "Mã Giày Dép";
            this.MaGD.MinimumWidth = 8;
            this.MaGD.Name = "MaGD";
            this.MaGD.Width = 150;
            // 
            // TenGD
            // 
            this.TenGD.DataPropertyName = "TenGD";
            this.TenGD.HeaderText = "Tên Giày Dép";
            this.TenGD.MinimumWidth = 8;
            this.TenGD.Name = "TenGD";
            this.TenGD.Width = 150;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.MinimumWidth = 8;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Width = 150;
            // 
            // MaCo
            // 
            this.MaCo.DataPropertyName = "MaCo";
            this.MaCo.HeaderText = "Mã Cỡ";
            this.MaCo.MinimumWidth = 8;
            this.MaCo.Name = "MaCo";
            this.MaCo.Width = 150;
            // 
            // MaCL
            // 
            this.MaCL.DataPropertyName = "MaCL";
            this.MaCL.HeaderText = "Mã Chất Liệu";
            this.MaCL.MinimumWidth = 8;
            this.MaCL.Name = "MaCL";
            this.MaCL.Width = 150;
            // 
            // MaMau
            // 
            this.MaMau.DataPropertyName = "MaMau";
            this.MaMau.HeaderText = "Mã Màu";
            this.MaMau.MinimumWidth = 8;
            this.MaMau.Name = "MaMau";
            this.MaMau.Width = 150;
            // 
            // MaDT
            // 
            this.MaDT.DataPropertyName = "MaDT";
            this.MaDT.HeaderText = "Mã Đối Tượng";
            this.MaDT.MinimumWidth = 8;
            this.MaDT.Name = "MaDT";
            this.MaDT.Width = 150;
            // 
            // MaMua
            // 
            this.MaMua.DataPropertyName = "MaMua";
            this.MaMua.HeaderText = "Mã Mùa";
            this.MaMua.MinimumWidth = 8;
            this.MaMua.Name = "MaMua";
            this.MaMua.Width = 150;
            // 
            // MaNSX
            // 
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.HeaderText = "Mã Nước SX";
            this.MaNSX.MinimumWidth = 8;
            this.MaNSX.Name = "MaNSX";
            this.MaNSX.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // Anh
            // 
            this.Anh.DataPropertyName = "Anh";
            this.Anh.HeaderText = "Ảnh";
            this.Anh.MinimumWidth = 8;
            this.Anh.Name = "Anh";
            this.Anh.Width = 150;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn Giá Nhập";
            this.DonGiaNhap.MinimumWidth = 8;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.Width = 150;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn Giá Bán";
            this.DonGiaBan.MinimumWidth = 8;
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.Width = 150;
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(187, 107);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(121, 28);
            this.cboMaLoai.TabIndex = 27;
            // 
            // cboMaCo
            // 
            this.cboMaCo.FormattingEnabled = true;
            this.cboMaCo.Location = new System.Drawing.Point(187, 143);
            this.cboMaCo.Name = "cboMaCo";
            this.cboMaCo.Size = new System.Drawing.Size(121, 28);
            this.cboMaCo.TabIndex = 28;
            // 
            // cboMaCL
            // 
            this.cboMaCL.FormattingEnabled = true;
            this.cboMaCL.Location = new System.Drawing.Point(187, 180);
            this.cboMaCL.Name = "cboMaCL";
            this.cboMaCL.Size = new System.Drawing.Size(121, 28);
            this.cboMaCL.TabIndex = 29;
            // 
            // cboMaMau
            // 
            this.cboMaMau.FormattingEnabled = true;
            this.cboMaMau.Location = new System.Drawing.Point(187, 215);
            this.cboMaMau.Name = "cboMaMau";
            this.cboMaMau.Size = new System.Drawing.Size(121, 28);
            this.cboMaMau.TabIndex = 30;
            // 
            // cboMaDT
            // 
            this.cboMaDT.FormattingEnabled = true;
            this.cboMaDT.Location = new System.Drawing.Point(187, 250);
            this.cboMaDT.Name = "cboMaDT";
            this.cboMaDT.Size = new System.Drawing.Size(121, 28);
            this.cboMaDT.TabIndex = 31;
            // 
            // cboMaMua
            // 
            this.cboMaMua.FormattingEnabled = true;
            this.cboMaMua.Location = new System.Drawing.Point(622, 24);
            this.cboMaMua.Name = "cboMaMua";
            this.cboMaMua.Size = new System.Drawing.Size(170, 28);
            this.cboMaMua.TabIndex = 32;
            // 
            // cboMaNSX
            // 
            this.cboMaNSX.FormattingEnabled = true;
            this.cboMaNSX.Location = new System.Drawing.Point(622, 65);
            this.cboMaNSX.Name = "cboMaNSX";
            this.cboMaNSX.Size = new System.Drawing.Size(170, 28);
            this.cboMaNSX.TabIndex = 33;
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(849, 74);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(192, 191);
            this.picAnh.TabIndex = 34;
            this.picAnh.TabStop = false;
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(849, 24);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(192, 35);
            this.btnMo.TabIndex = 35;
            this.btnMo.Text = "Mở";
            this.btnMo.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(966, 563);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 39);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(799, 563);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 44);
            this.btnHuy.TabIndex = 41;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(631, 568);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 39);
            this.btnLuu.TabIndex = 40;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(444, 568);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 39);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(71, 571);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 39);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(253, 574);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 33);
            this.btnSua.TabIndex = 37;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 615);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnMo);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.cboMaNSX);
            this.Controls.Add(this.cboMaMua);
            this.Controls.Add(this.cboMaDT);
            this.Controls.Add(this.cboMaMau);
            this.Controls.Add(this.cboMaCL);
            this.Controls.Add(this.cboMaCo);
            this.Controls.Add(this.cboMaLoai);
            this.Controls.Add(this.dataGridView_SanPham);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenGD);
            this.Controls.Add(this.txtMaGD);
            this.Controls.Add(this.lblDonGiaBan);
            this.Controls.Add(this.lblDonGiaNhap);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblMaNuocSX);
            this.Controls.Add(this.lblMaMua);
            this.Controls.Add(this.lblMaDoiTuong);
            this.Controls.Add(this.lblMaMau);
            this.Controls.Add(this.lblMaChatLieu);
            this.Controls.Add(this.lblMaCo);
            this.Controls.Add(this.lblMaLoai);
            this.Controls.Add(this.lblTenGiayDep);
            this.Controls.Add(this.lblMaGiayDep);
            this.Name = "frmSanPham";
            this.Text = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaGiayDep;
        private System.Windows.Forms.Label lblTenGiayDep;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.Label lblMaCo;
        private System.Windows.Forms.Label lblMaChatLieu;
        private System.Windows.Forms.Label lblMaMau;
        private System.Windows.Forms.Label lblMaDoiTuong;
        private System.Windows.Forms.Label lblMaMua;
        private System.Windows.Forms.Label lblMaNuocSX;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Label lblDonGiaNhap;
        private System.Windows.Forms.Label lblDonGiaBan;
        private System.Windows.Forms.TextBox txtMaGD;
        private System.Windows.Forms.TextBox txtTenGD;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.DataGridView dataGridView_SanPham;
        private System.Windows.Forms.ComboBox cboMaLoai;
        private System.Windows.Forms.ComboBox cboMaCo;
        private System.Windows.Forms.ComboBox cboMaCL;
        private System.Windows.Forms.ComboBox cboMaMau;
        private System.Windows.Forms.ComboBox cboMaDT;
        private System.Windows.Forms.ComboBox cboMaMua;
        private System.Windows.Forms.ComboBox cboMaNSX;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
    }
}