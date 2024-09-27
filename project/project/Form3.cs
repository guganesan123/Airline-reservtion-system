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

namespace project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\booked.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into book(pname ,fligtid,seat,src,dest) values('" + textBox1.Text + "'," + textBox2.Text+ "," + textBox3.Text + ",'" + comboBox1.Text + "','" + comboBox2.Text + "')",con);
            int i = cmd.ExecuteNonQuery();
            if (i >0)
            {
                MessageBox.Show("updated");
            }
            else
            {
                MessageBox.Show("not booked");

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select*from book",con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
