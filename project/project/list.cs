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
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Documents\booked.mdf;Integrated Security=True;Connect Timeout=30");

        private void list_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select*from book", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
