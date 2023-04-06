using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentManagingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection cnn;
        public SqlDataAdapter da;
        public DataSet ds;

        void Grid_Format()
        {
            dg_hoc_sinh.ReadOnly = true;
            dg_hoc_sinh.Columns[0].HeaderText = "Student ID";
            dg_hoc_sinh.Columns[0].Width = 100;
            dg_hoc_sinh.Columns[1].HeaderText = "Name";
            dg_hoc_sinh.Columns[1].Width = 190;
            dg_hoc_sinh.Columns[2].HeaderText = "DoB";
            dg_hoc_sinh.Columns[2].Width = 120;
            dg_hoc_sinh.Columns[3].HeaderText = "Address";
            dg_hoc_sinh.Columns[3].Width = 250;
        }

        void Load_Database_Form()
        {
            try
            {
                cnn = new SqlConnection();
                cnn.ConnectionString = "path"; //Your SQL Database path
                cnn.Open();
                ds = new DataSet();
                da = new SqlDataAdapter("Select * From HOCSINH", cnn);
                da.Fill(ds);
                dg_hoc_sinh.DataSource = ds.Tables[0];
                Grid_Format();
                //Input the data from the first line of the DataGridView onto the existing Controls on the Form
                DataGridViewRow row = dg_hoc_sinh.Rows[0];
                txt_ma_hs.Text = row.Cells["MAHS"].Value.ToString();
                txt_ten_hs.Text = row.Cells["HOTEN"].Value.ToString();
                if (row.Cells["NGAYSINH"].Value.ToString().Length > 0)
                    dt_ngay_sinh.Value = DateTime.Parse(row.Cells["NGAYSINH"].Value.ToString());
                txt_dia_chi.Text = row.Cells["DIACHI"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Can't connect to the SQL Database");
            }
        }

        bool Check_Verification()
        {
            //Check TextBox input
            if (txt_ma_hs.Text == "")
            {
                MessageBox.Show("You haven't enter the Student ID");
                return false;
            }

            //Kiểm tra dữ liệu textbox
            if (txt_ten_hs.Text == "")
            {
                MessageBox.Show("You haven't enter the Student Names");
                return false;
            }

            //Check TextBox input
            if (txt_dia_chi.Text == "")
            {
                MessageBox.Show("You haven't enter the Address");
                return false;
            }

            //Check if the student ID already exists
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            string lenh = "Select * From HOCSINH where MAHS='" + txt_ma_hs.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(lenh, cnn);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This Student ID already existed");
                return false;
            }
            return true;
        }
        bool Check_Delete()
        {
            //Check that the student exists on the KETQUA table?
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            string lenh = "Select * From KETQUA where MAHS='" + txt_ma_hs.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(lenh, cnn);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("This Student ID already has result -> Can't delete it!!");
                return false;
            }
            return true;
        }

        //Function for the Insert statement => call the procedure them_hocsinh in SQLDatabase
        void Insert()
        {
            //Build insert command
            SqlCommand lenh_them = new SqlCommand("them_hocsinh", cnn);
            lenh_them.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = lenh_them.Parameters.Add("@mahs", SqlDbType.Char, 9);
            p1.Value = txt_ma_hs.Text;
            SqlParameter p2 = lenh_them.Parameters.Add("@hoten", SqlDbType.Char, 100);
            p2.Value = txt_ten_hs.Text;
            SqlParameter p3 = lenh_them.Parameters.Add("@ngaysinh", SqlDbType.DateTime);
            p3.Value = dt_ngay_sinh.Value;
            SqlParameter p4 = lenh_them.Parameters.Add("@diachi", SqlDbType.Char, 100);
            p4.Value = txt_dia_chi.Text;

            lenh_them.ExecuteNonQuery();
        }
        void Delete()
        {
            //Build delete command
            SqlCommand lenh_xoa = new SqlCommand("xoa_hocsinh", cnn);
            lenh_xoa.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = lenh_xoa.Parameters.Add("@mahs", SqlDbType.Char, 9);
            p1.Value = txt_ma_hs.Text;

            lenh_xoa.ExecuteNonQuery();
        }
        new void Update()
        {
            //Prepare to store temporary variable mahs_cu for the code students want to delete
            //Based on event select row with code to delete on DataGridView
            string mahs_cu;
            DataGridViewSelectedRowCollection rows = dg_hoc_sinh.SelectedRows;
            DataGridViewRow row = rows[0];
            mahs_cu = row.Cells["MAHS"].Value.ToString();
            //Build Update Command
            SqlCommand lenh_sua = new SqlCommand("sua_hocsinh", cnn);
            lenh_sua.CommandType = CommandType.StoredProcedure;

            SqlParameter p1 = lenh_sua.Parameters.Add("@mahs_cu", SqlDbType.Char, 9);
            p1.Value = mahs_cu;
            SqlParameter p2 = lenh_sua.Parameters.Add("@mahs", SqlDbType.Char, 9);
            p2.Value = txt_ma_hs.Text;
            SqlParameter p3 = lenh_sua.Parameters.Add("@hoten", SqlDbType.Char, 100);
            p3.Value = txt_ten_hs.Text;
            SqlParameter p4 = lenh_sua.Parameters.Add("@ngaysinh", SqlDbType.DateTime);
            p4.Value = dt_ngay_sinh.Value;
            SqlParameter p5 = lenh_sua.Parameters.Add("@diachi", SqlDbType.Char, 100);
            p5.Value = txt_dia_chi.Text;

            lenh_sua.ExecuteNonQuery();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Database_Form();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (Check_Verification())
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                try
                {
                    //Execute the command to add data
                    Insert();
                    //User interaction => successful event notification
                    MessageBox.Show("Added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't add due to this:" + ex.ToString());
                }
                //Place the data on the DataGridView to observe the results
                Load_Database_Form();
            }
        }
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete it?", "NOTICE", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (Check_Delete())
                {
                    if (cnn.State == ConnectionState.Closed)
                        cnn.Open();
                    try
                    {
                        //Execute the command to delete data
                        Delete();
                        //Interact with the user => successful event notification
                        MessageBox.Show("Deleted Successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't delete due to this:" + ex.ToString());
                    }
                    //Load Data
                    Load_Database_Form();
                }
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to edit the database info?", "NOTICE", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Execute command
                    Update();
                    //Interacting with users
                    MessageBox.Show("Your database info has successfully repaired!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //Load the data - nubs said
                Load_Database_Form();
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dg_hoc_sinh_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dg_hoc_sinh.SelectedRows;
            if (rows.Count > 0)
            {
                DataGridViewRow row = rows[0];
                txt_ma_hs.Text = row.Cells["MAHS"].Value.ToString();
                txt_ten_hs.Text = row.Cells["HOTEN"].Value.ToString();
                if (row.Cells["NGAYSINH"].Value.ToString().Length > 0)
                    dt_ngay_sinh.Value = DateTime.Parse(row.Cells["NGAYSINH"].Value.ToString());
                txt_dia_chi.Text = row.Cells["DIACHI"].Value.ToString();
            }
        }
    }
}
