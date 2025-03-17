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


namespace WinFormsApp1
{
    public partial class _01Button : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=G:\\C#\\WinFormsApp1\\Database1.mdf;Integrated Security=True");
        public _01Button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into Demo values ('" + name.Text + "','" + branch.Text + "','" + sem.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully");
        }

        private void Update_BTN_Click(object sender, EventArgs e)
        {
            string query = "update Demo set name='"+name.Text+"',branch='"+branch.Text+"',sem='"+Convert.ToInt32(sem.Text)+"' where id='"+Convert.ToInt32(ID_Val.Text)+"' ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
        }

        private void Delete_BTN_Click(object sender, EventArgs e)
        {
            string query = "delete from Demo where id='" + Convert.ToInt32(ID_Val.Text) + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Demo";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
