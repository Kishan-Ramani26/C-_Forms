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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-6V5I9OV;Initial Catalog=RegisterDB;Integrated Security=True");
        String gender;
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
            String query = "insert into RegisterForm values('" + name.Text + "','" + password.Text + "','" + Branch.Text + "','" + Convert.ToInt32(Sem.Text) + "','"+gender+"','"+citylist.SelectedIndex+"')";
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
    }
}
