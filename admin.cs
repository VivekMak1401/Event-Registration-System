using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistrationAndLogin
{
    public partial class admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\database.mdf;Integrated Security=True;Connect Timeout=30");
    
        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter drr;
        string Id;
        bool Mode = true;
        string sql;


        public admin()
        {
            InitializeComponent();
           Load();
        }

        public void Load()
        {
            try
            {
                sql = "select * from event";
                cmd = new SqlCommand(sql, con);
                con.Open();
                read = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[0], read[1], read[2], read[3], read[4], read[5], read[6]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void getID(String Id)
        {
            sql = "select * from event where Id = '" + Id + "'  ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            read = cmd.ExecuteReader();

            while (read.Read())
            {

                txt_stdname.Text = read[1].ToString();
                txt_stdid.Text = read[2].ToString();
                txt_course.Text = read[3].ToString();
                txt_email.Text = read[4].ToString();
                txt_mobile.Text = read[5].ToString();
                txt_sem.Text = read[6].ToString();
                
            }
            con.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                getID(Id);
                btn_save.Text = "Edit";

            }
            else if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "delete from event where Id  = @Id ";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Id ", Id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleteeeee");
                con.Close();
            }
        }

        private void admin_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stdname = txt_stdname.Text;
            string stdid = txt_stdid.Text;
            string course = txt_course.Text;
            string email = txt_email.Text;
            string mobileno = txt_mobile.Text;
            string semester = txt_sem.Text;

            if (Mode == true)
            {
                sql = "insert into event(studentname,studentid,course,email,mobileno,semester) values(@studentname,@studentid,@course,@email,@mobileno,@semester)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@studentname", stdname);
                cmd.Parameters.AddWithValue("@studentid", stdid);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobileno", mobileno);
                cmd.Parameters.AddWithValue("@semester", semester);
                MessageBox.Show("Record is Aded");
                cmd.ExecuteNonQuery();

                txt_stdname.Clear();
                txt_stdid.Clear();
                txt_course.Clear();
                txt_email.Clear();
                txt_mobile.Clear();
                txt_sem.Clear();
                txt_stdname.Focus();

            }
            else
            {
                Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                sql = "update event set studentname = @studentname, studentid= @studentid,course = @course,email = @email,mobileno = @mobileno,semester = @semester where id = @id";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@studentname", stdname);
                cmd.Parameters.AddWithValue("@studentid", stdid);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobileno", mobileno);
                cmd.Parameters.AddWithValue("@semester", semester);
                cmd.Parameters.AddWithValue("@Id", Id);
                MessageBox.Show("Record Updated");
                cmd.ExecuteNonQuery();

                txt_stdname.Clear();
                txt_stdid.Clear();
                txt_course.Clear();
                txt_email.Clear();
                txt_mobile.Clear();
                txt_sem.Clear();
                txt_stdname.Focus();
                btn_save.Text = "Save";
                Mode = true;

            }
            con.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_stdname.Clear();
            txt_stdid.Clear();
            txt_course.Clear();
            txt_email.Clear();
            txt_mobile.Clear();
            txt_sem.Clear();
            txt_stdname.Focus();
            btn_save.Text = "Save";
            Mode = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Load();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
