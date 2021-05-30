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

namespace sp
{
    public partial class Form1 : Form
    {
        #region SQL

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            MyDBConn db = new MyDBConn();
            DataTable dt = new DataTable();
            Dictionary<string, string> dc = new Dictionary<string, string>();
            dc.Add("@num", textBox1.Text);
            db.MyGetData(CommandType.StoredProcedure, "uspQueryByNumber", ref dt, dc);

            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        
    }
}
