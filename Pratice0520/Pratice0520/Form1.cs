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


namespace Pratice0520
{
    public partial class Form1 : Form
    {
        #region sql
        private string cnStr = "Data Source=YOWANEHAKU\\SQLEXPRESS;Initial Catalog = AdventureWorksDW; Integrated Security = True";
        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataSet ds;
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cnStr);
            da = new SqlDataAdapter();
            ds = new DataSet();
        }

        private void set()
        {
            da.Fill(ds, "test");
            dataGridView1.DataSource = ds.Tables["test"];

            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;

            da.SelectCommand = new SqlCommand($"select {a} from {b}", cn);
            if (ds.Tables.Count > 0)
            {
                ds.Tables.Clear();
            }
            set();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select @a from @b where @c = @d", cn);
            da.SelectCommand.Parameters.AddWithValue("@a", textBox1.Text);
            da.SelectCommand.Parameters.AddWithValue("@b", textBox2.Text);
            da.SelectCommand.Parameters.AddWithValue("@c", textBox3.Text);
            da.SelectCommand.Parameters.AddWithValue("@d", textBox4.Text);
            if (ds.Tables.Count > 0)
            {
                ds.Tables.Clear();
            }

            set();
        }

    }
}
