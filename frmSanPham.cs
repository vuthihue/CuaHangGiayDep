﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace QuanLyDayDep
{
    public partial class frmSanPham : Form
    {
        DataTable tableSanPham;
        
        public frmSanPham()
        {
            InitializeComponent();
        }

        

        
        private void loatDaTaToGridview()
        {
            string sql = "select *from SanPham";
            tableSanPham = Functions.GetDataToTable(sql);
            
           dataGridView_SanPham.DataSource = tableSanPham;
            
        }
        private void ResetValues()
        {
            txtMaGD.Text = "";
            txtTenGD.Text = "";
            cboMaCL.Text = "";
            cboMaCo.Text = "";
            cboMaDT.Text = "";
            cboMaMua.Text = "";
            cboMaMau.Text = "";
            cboMaNSX.Text = "";
            cboMaLoai.Text = "";
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtDonGiaBan.Text = "0";
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtAnh.Text = "";
            picAnh.Image = null;
            
        }

        private void dataGridView_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaCo, MaMua, MaMau, MaDT, MaCL, MaNSX, MaLoai;
            txtMaGD.Text = dataGridView_SanPham.CurrentRow.Cells["MaGD"].Value.ToString();
            txtTenGD.Text = dataGridView_SanPham.CurrentRow.Cells["TenGD"].Value.ToString();
            MaLoai = dataGridView_SanPham.CurrentRow.Cells["MaLoai"].Value.ToString();
            cboMaLoai.Text = Functions.GetFieldValues("select TenLoai from TheLoai where MaLoai='" + MaLoai + "'");
            MaCo = dataGridView_SanPham.CurrentRow.Cells["MaCo"].Value.ToString();
            cboMaCo.Text = Functions.GetFieldValues("select TenCo From Co Where MaCo='" + MaCo + "'");
            MaMau = dataGridView_SanPham.CurrentRow.Cells["MaMau"].Value.ToString();
            cboMaMau.Text = Functions.GetFieldValues("Select TenMau From Mau Where MaMau='" + MaMau + "'");
            MaMua = dataGridView_SanPham.CurrentRow.Cells["MaMua"].Value.ToString();
            cboMaMua.Text = Functions.GetFieldValues("select TenMua From Mua Where MaMua='" + MaMua + "'");
            MaCL = dataGridView_SanPham.CurrentRow.Cells["MaCL"].Value.ToString();
            cboMaCL.Text = Functions.GetFieldValues("select TenCL From ChatLieu Where MaCL='" + MaCL + "'");
            MaDT = dataGridView_SanPham.CurrentRow.Cells["MaDT"].Value.ToString();
            cboMaDT.Text = Functions.GetFieldValues("select TenDT From DoiTuong Where MaDT='" + MaDT + "'");
            MaNSX = dataGridView_SanPham.CurrentRow.Cells["MaNSX"].Value.ToString();
            cboMaNSX.Text = Functions.GetFieldValues("select TenNSX From NuocSX Where MaNSX='" + MaNSX + "'");
            txtSoLuong.Text = dataGridView_SanPham.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtAnh.Text = dataGridView_SanPham.CurrentRow.Cells["Anh"].Value.ToString();
            txtDonGiaNhap.Text = dataGridView_SanPham.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDonGiaBan.Text = dataGridView_SanPham.CurrentRow.Cells["DonGiaBan"].Value.ToString();
            txtMaGD.Enabled = false;
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            txtMaGD.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            Functions.FillCombo("select MaCL,TenCL from ChatLieu", cboMaCL, "MaCL", "TenCL");
            cboMaCL.SelectedIndex = -1;
            Functions.FillCombo("select MaMau,TenMau From Mau", cboMaMau, "MaMau", "TenMau");
            cboMaMau.SelectedIndex = -1;
            Functions.FillCombo("select MaCo,TenCo From Co", cboMaCo, "MaCo", "TenCo");
            cboMaCo.SelectedIndex = -1;
            Functions.FillCombo("select MaDT,TenDT From DoiTuong", cboMaDT, "MaDT", "TenDT");
            cboMaDT.SelectedIndex = -1;
            Functions.FillCombo("select MaLoai,TenLoai From TheLoai", cboMaLoai, "MaLoai", "TenLoai");
            cboMaLoai.SelectedIndex = -1;
            Functions.FillCombo("select MaNSX,TenNSX From NuocSX", cboMaNSX, "MaNSX", "TenNSX");
            cboMaNSX.SelectedIndex = -1;
            Functions.FillCombo("select MaMua,TenMua From Mua", cboMaMua, "MaMua", "TenMua");
            cboMaMua.SelectedIndex = -1;

            loatDaTaToGridview();
            ResetValues();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaGD.Enabled = true;
            txtMaGD.Focus();
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaGD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGD.Focus();
                return;
            }
            if (txtTenGD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenGD.Focus();
                return;
            }
            if (cboMaCL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaCL.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnMo.Focus();
                return;
            }
            if (cboMaCo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn cỡ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaCo.Focus();
            }
            if (cboMaDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaDT.Focus();
            }
            if (cboMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaLoai.Focus();
            }
            if (cboMaMau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaMau.Focus();
            }
            if (cboMaMua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaMua.Focus();
            }
            if (cboMaNSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNSX.Focus();
            }

            sql = "SELECT MaGD FROM SanPham WHERE MaGD'" + txtMaGD.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã giày dép này đã tồn tại, bạn phải chọn mã giầy dép khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGD.Focus();
                return;
            }
            sql = "INSERT INTO SanPham(MaGD,TenGD,MaLoai,MaCo,MaCL,MaMau,MaDT,MaMua,MaNSX,SoLuong,DonGiaNhap, DonGiaBan,Anh) VALUES(N'"
                + txtMaGD.Text.Trim() + "','" + txtTenGD.Text.Trim() +"','"+cboMaCo.SelectedValue.ToString()+
                "','"+cboMaLoai.SelectedValue.ToString()+
                "','" + cboMaCL.SelectedValue.ToString()
                + "','" +cboMaMau.SelectedValue.ToString()+ "','" +cboMaMua.SelectedValue.ToString()+ "','" +cboMaNSX.SelectedValue.ToString()
                + "','" +cboMaDT.SelectedValue.ToString()+
                "'," + txtSoLuong.Text.Trim() + "," + txtDonGiaNhap.Text +
                "," + txtDonGiaBan.Text + ",'" + txtAnh.Text + "','"  + "')";

            Functions.RunSQL(sql);
            loatDaTaToGridview();
            //ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaGD.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtMaGD.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tableSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE SanPham WHERE MaGD=N'" + txtMaGD.Text + "'";
                Functions.RunSqlDel(sql);
                loatDaTaToGridview();
                ResetValues();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tableSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGD.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGD.Focus();
                return;
            }
            if (txtTenGD.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenGD.Focus();
                return;
            }
            if (cboMaCL.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaCL.Focus();
                return;
            }
            if (cboMaDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaDT.Focus();
                return;
            }
            if (cboMaLoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaLoai.Focus();
                return;
            }
            if (cboMaMau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaMau.Focus();
                return;
            }
            if (cboMaMua.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mùa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaMua.Focus();
                return;
            }
            if (cboMaNSX.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaNSX.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE SanPham SET TenGD='" + txtTenGD.Text +
                "',MaCL='" + cboMaCL.SelectedValue.ToString()+"',MaCo='" + cboMaCo.SelectedValue.ToString() +
               "',MaLoai='" + cboMaLoai.SelectedValue.ToString() 
               
               + "',MaMau='" + cboMaMau.SelectedValue.ToString() + "',MaMua='" + cboMaMua.SelectedValue.ToString() + "',MaNSX='" + cboMaNSX.SelectedValue.ToString()
               + "',MaDT='" + cboMaDT.SelectedValue.ToString() +
               
                "',SoLuong='" + txtSoLuong.Text +
                "',Anh='" + txtAnh.Text  + "' WHERE MaGD='" + txtMaGD.Text + "'";
            Functions.RunSQL(sql);
            loatDaTaToGridview();
            ResetValues();
            btnHuy.Enabled = false;
        }
    }

}
