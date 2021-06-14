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

namespace 使用SQL預存程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 test = new Class1();
            DataTable dt = new DataTable();
            Dictionary<string, string> dc = new Dictionary<string, string>();
            dc.Add("@num", textBox1.Text);
            test.getdata(CommandType.StoredProcedure, "test", ref dt, dc);

            dataGridView1.DataSource = dt;
        }
    }
}
