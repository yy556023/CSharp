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

namespace Lab0520
{
    public partial class Form2 : Form
    {
        #region 宣告
        private string cnStr = Properties.Settings.Default.AdventureWorksDWConnectionString;
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

            label1.Text = "查詢條件：";
            txtResult.Multiline = true;
            txtResult.Width = 200;
            txtResult.Height = 200;
        }

        private void set()
        {
            da.Fill(ds, "DimCurry");
            dataGridView1.DataSource = ds.Tables["DimCurry"];

            //dataGridView1.Columns[0].HeaderText = "流水號";
            //dataGridView1.Columns[1].HeaderText = "幣別";
            //dataGridView1.Columns[2].HeaderText = "完整名稱";

            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from DimCurrency",cn);
            if (ds.Tables["DimCurrency"] != null && ds.Tables[0].Rows.Count > 0)
            {
                ds.Tables[0].Clear();
            }
            set();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select @apple from DimCurrency", cn);
            //da.SelectCommand = new SqlCommand("select * from DimCurrency where CurrencyAlternateKey = @apple", cn);
            da.SelectCommand.Parameters.AddWithValue("@apple", txtWhere.Text);
            //ds.Tables.Count> 0
            if (ds.Tables["DimCurry"] != null && ds.Tables[0].Rows.Count > 0) 
            {
                ds.Tables[0].Clear();
            }
            set();
        }

        private void btnWhereWith_Click(object sender, EventArgs e)
        {
  
        }
    }
}
