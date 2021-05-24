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

namespace Lab0521
{
    public partial class Form2 : Form
    {
        #region SQL
        private string cnStr = Properties.Settings.Default.cnStr;
        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataSet ds;
        #endregion

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cnStr);
            da = new SqlDataAdapter();
            ds = new DataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from DimCurrency", cn);
            da.Fill(ds, "DimCurrency");
            dataGridView1.DataSource = ds.Tables["DimCurrency"];
            dataGridView1.Columns["CurrencyKey"].HeaderText = "流水號";
            dataGridView1.Columns["CurrencyAlternateKey"].HeaderText = "縮寫";
            dataGridView1.Columns["CurrencyName"].HeaderText = "完整名稱";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            textBox1.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyKey");
            textBox2.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyAlternateKey");
            textBox3.DataBindings.Add("Text", ds.Tables["DimCurrency"], "CurrencyName");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";

            foreach (DataRow item in ds.Tables["DimCurrency"].Rows) 
            {
                textBox4.Text += item.RowState + "===>" + string.Join(",", item.ItemArray) + Environment.NewLine;
            }
        }

        private void btuupdatev1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.UpdateCommand = cb.GetUpdateCommand();
            
            int i = da.Update(ds.Tables["DimCurrency"]);

            textBox4.Text = cb.GetUpdateCommand().CommandText + Environment.NewLine;
            textBox4.Text += $"i的數字是{i}";
        }
    }
}
