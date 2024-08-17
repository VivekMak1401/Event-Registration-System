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
    public partial class Home : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\database.mdf;Integrated Security=True;Connect Timeout=30");

        SqlCommand cmd;
        SqlDataReader read;
        SqlDataAdapter drr;
        string Id;
        bool Mode = true;
        string sql;

        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
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
               // btn_save.Text = "Save";
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
           // btn_save.Text = "Save";
            Mode = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
