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
    public partial class Form1 : Form
    {
        #region SQL
        private string cnStr = Properties.Settings.Default.cnStr;
        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataSet ds;
        private string sql = "select * from DimCurrency order by CurrencyAlternateKey offset @cat rows fetch next 5 rows only";
        #endregion

        #region Program
        //資料筆數
        private int count;
        //指標位置
        private int index;
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

            count = 0;
            index = 0;

            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void GetIndex(int value)
        {
            da.SelectCommand = new SqlCommand(sql, cn);
            da.SelectCommand.Parameters.AddWithValue("@cat", index);

            if (ds.Tables["DimCurrency"] != null && ds.Tables["DimCurrency"].Rows.Count > 0)
            {
                ds.Tables["DimCurrency"].Clear();
            }

            //設定資料欄位高度
            dataGridView1.RowTemplate.Height = 40;

            //放下資料取名叫 DimCurrency
            da.Fill(ds, "DimCurrency");
            
            //DGV1的顯示資料來源為 DimCurrency名稱的資料表
            dataGridView1.DataSource = ds.Tables["DimCurrency"];

            dataGridView1.Columns["CurrencyKey"].HeaderText = "流水號";
            dataGridView1.Columns["CurrencyAlternateKey"].HeaderText = "縮寫";
            dataGridView1.Columns["CurrencyName"].HeaderText = "完整名稱";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            label1.Text = $"第{index + 1}筆 - 第{index + 5}筆，共{count}筆";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //取得資料總筆數
            //方法A
            //da.SelectCommand = new SqlCommand("select * from DimCurrency", cn);
            //da.Fill(ds, "count");
            //count = ds.Tables["count"].Rows.Count;
            //方法B
            da.SelectCommand = new SqlCommand("select count(*) from DimCurrency", cn);
            da.Fill(ds, "count");

            //取得select 資料105 並且轉型成int
            count = (int)ds.Tables["count"].Rows[0].ItemArray[0];

            GetIndex(index);

            button1.Enabled = false;
            button3.Enabled = true;
        }

        //待修正部分
        private void button2_Click(object sender, EventArgs e)
        {
            index -= 5;
            
            GetIndex(index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index += 5;

            GetIndex(index);
        }
    }
}
