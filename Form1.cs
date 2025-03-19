using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\C#\\WinFormsApp1\\Database1.mdf;Integrated Security=True");

            string query = "insert into Student (name,branch,qty,city) values (@name,@branch,@qty,@city)";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@branch", branch.Text);
            cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(qty.Text));
            cmd.Parameters.AddWithValue("@city", city.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully");
        }
    }
}
