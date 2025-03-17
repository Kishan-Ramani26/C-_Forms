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

namespace WinFormsApp1
{
    public partial class RegisterForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\C#\\WinFormsApp1\\Database1.mdf;Integrated Security=True");
        string gender;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into RegisterForm values('" + name.Text + "','" + password.Text + "','" + Branch.Text + "','" + Convert.ToInt32(Sem.Text) + "','" + gender + "','" + citylist.SelectedIndex.ToString() + "')";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Inserted Successfully");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "MALE";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "FEMALE";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "update RegisterForm set name='" + name.Text + "',Branch='" + Branch.Text + "' where Id='" + Convert.ToInt16(IDTXT.Text) + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Database Updated Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }
    }
}
