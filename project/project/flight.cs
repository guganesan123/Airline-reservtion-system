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
    public partial class flight : Form
    {
        public flight()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\booked.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblflight(takeofdate,pick,destination) values('"+textBox2.Text.ToString()+"','"+comboBox1.Text+"','"+comboBox2.Text+"')",con);
            int i = cmd.ExecuteNonQuery();
            if(i>0)
            {
                MessageBox.Show("added");
            }
            else
            {
                MessageBox.Show("not added");
            }
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select*from tblflight",con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from tblflight where filghtid="+textBox1.Text+"", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("deleted");
            }
            else
            {
                MessageBox.Show("not deleted");
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update tblflight set takeofdate"+textBox2.Text+" where filghtid="+textBox1.Text+" ", con);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("updated");
            }
            else
            {
                MessageBox.Show("not updated");
            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
