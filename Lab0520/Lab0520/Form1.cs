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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'adventureWorksDWDataSet.DimCurrency' 資料表。您可以視需要進行移動或移除。
            this.dimCurrencyTableAdapter.Fill(this.adventureWorksDWDataSet.DimCurrency);


            //dgvDimCurrency.Columns[0].HeaderText = "流水號";
            dgvDimCurrency.Columns[1].HeaderText = "縮寫";
            dgvDimCurrency.Columns[2].HeaderText = "完整名稱";

            dgvDimCurrency.Columns["currencyKeyDataGridViewTextBoxColumn"].HeaderText = "流水號";

            //調整欄位寬度
            dgvDimCurrency.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            // 連線字串
            string connStr = Lab0520.Properties.Settings.Default.AdventureWorksDWConnectionString;

            // 搭橋
            SqlConnection cn = new SqlConnection(connStr);

            // 走路工
            SqlDataAdapter da = new SqlDataAdapter("select * from DimCurrency",cn);

            // 準備接收資料
            DataSet ds = new DataSet();

            // 走路工出門 + 把資料放下
            da.Fill(ds, "apple");
            
            //調整資料列的高度
            dgvDemo.RowTemplate.Height = 40;
            // 資料顯示在畫面上
            //dgvDemo.DataSource = ds.Tables[0];
            dgvDemo.DataSource = ds.Tables["apple"];

            // 修改欄位顯示名稱 + 調整大小
            dgvDemo.Columns[0].HeaderText = "流水號";
            dgvDemo.Columns[1].HeaderText = "縮寫";
            dgvDemo.Columns[2].HeaderText = "完整名稱";
            dgvDemo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


        }
    }
}
