using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDayDep;

namespace QuanLyDayDep
{
    public partial class frmCongViec : Form
    {
        DataTable tableCongViec;
        public frmCongViec()
        {
            InitializeComponent();
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        {
            txtMaCV.Enabled = false;
            loatDaTaToGridview();
        }
        private void loatDaTaToGridview()
        {
            string sql = "select *from CongViec";
            tableCongViec = Functions.GetDataToTable(sql);
            dataGridView_CongViec.DataSource = tableCongViec;      
        }

        private void dataGridView_CongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCV.Text = dataGridView_CongViec.CurrentRow.Cells["MaCV"].Value.ToString();
            txtTenCV.Text = dataGridView_CongViec.CurrentRow.Cells["TenCV"].Value.ToString();
            txtMaCV.Enabled = false;      
        }
        private void ResetVaLues()
        {
            txtMaCV.Text = "";
            txtTenCV.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetVaLues();
            txtMaCV.Enabled = true;
            loatDaTaToGridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete From CongViec Where MaCV= '" + txtMaCV.Text + "'";
            Functions.RunSqlDel(sql);
            loatDaTaToGridview();
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetVaLues();
            //btnHuy.Enabled = false;
            //btnThem.Enabled = true;
            txtMaCV.Enabled = false;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtMaCV.Text == "")
            {
                MessageBox.Show("Bạn nhập mã CV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenCV.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên CV", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE CongViec SET TenCV='" +
                txtTenCV.Text.ToString() +
                "' WHERE MaCV='" + txtMaCV.Text + "'";
            MessageBox.Show(sql);
            Functions.RunSqlDel(sql);
            //SqlCommand cmd = new SqlCommand(sql, con);
            //cmd.ExecuteNonQuery();
            loatDaTaToGridview();
            btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCV.Text == "")
            {
                MessageBox.Show("bạn cần nhập mã Cv");
                txtMaCV.Focus();
                return;
            }
            if (txtTenCV.Text == "")
            {
                MessageBox.Show("bạn cần nhập tên loai");
                txtTenCV.Focus();
            }
            else
            {

                string sql = "insert into CongViec values ('" + txtMaCV.Text + "','" + txtTenCV.Text + "')";

                MessageBox.Show(sql);
                Functions.RunSqlDel(sql);
                loatDaTaToGridview();
            }
        }
    }
}
