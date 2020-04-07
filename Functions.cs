using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyDayDep;


// Sử dụng đối tượng MessageBox

namespace QuanLyDayDep
{
    //string sql;
    class Functions
    {
        public static SqlConnection con;  //Khai báo đối tượng kết nối . biến toàn cục.muốn dùng có thể gọi trưc tiếp      
        //tạo phương thức connection
        public static void Connect()
        {
            con = new SqlConnection();   //Khởi tạo đối tượng
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CuaHangGiayDep;Integrated Security=True";
            con.Open();                  //Mở kết nối
            //Kiểm tra kết nối
            if (con.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        public static void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();   	//Đóng kết nối
                con.Dispose(); 	//Giải phóng tài nguyên
                con = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql,con);
            DataTable table = new DataTable();
            dap.Fill(table);//đổ kq từ câu lệnh sql vào table
            return table;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool checkKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
       public static void FillCombo(string sql, ComboBox cbo, string ma,string ten)
            
        //hiển thị theo tên trong cbo từ đó ánh xạ được cả mã.để chèn vào mã của bảng khác
        //mục đích đổ dữ liệu vào cbo
        {



            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; // Truong gia tri
            cbo.DisplayMember = ten;


           // cbo.ValueMember = ma; //Trường giá trị//gắn  với trường mã
           // cbo.DisplayMember = ten; //Trường hiển thị

            //string sql = "select *from tblPhong";
            //SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            //DataTable tabletblPhong = new DataTable();

            //adp.Fill(tabletblPhong);
            //dataGridView_tblPhong.DataSource = tabletblPhong;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd; // Khai báo đối tượng SqlCommand
            cmd = new SqlCommand(); // Khởi tạo đối tượng
            cmd.Connection = Functions.con; // Gán kết nối
            cmd.CommandText = sql; // Gán câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); // Thực hiện câu lệnh SQL
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap= new SqlDataAdapter(sql,con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void RunSQL(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        //public static void RunSqlDel(string sql)
        //{
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = Functions.con;
        //    cmd.CommandText = sql;
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (System.Exception)
        //    {
        //        MessageBox.Show("Dữ liệu đang được dùng, không thể xóa","Thông báo",
        //                         MessageBoxButtons.OK, MessageBoxIcon.Stop);

        //    }
        //    cmd.Dispose();
        //    cmd = null;
        //}

    }
}
