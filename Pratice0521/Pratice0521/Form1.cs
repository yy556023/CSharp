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

namespace Pratice0521
{
    public partial class Form1 : Form
    {
        #region SQL
        private string cnStr = Properties.Settings.Default.cnStr;
        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataSet ds;
        private SqlCommandBuilder cb;
        #endregion

        #region page
        private int index;
        private int count;
        #endregion

        public Form1()
        {
            InitializeComponent();

            //載入前設定載入位置為中央
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //把tb4的多行設定改成true
            textBox4.Multiline = true;
            
            //設定長寬
            textBox4.Width = 300;
            textBox4.Height = 300;

            //更改bt的text status
            button1.Text = "Fill";
            button2.Text = "獲取狀態";
            button3.Text = "Update";
            button4.Text = "上一頁";
            button5.Text = "下一頁";
            button6.Text = "Update v2";
            button7.Text = "Update v3";
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

            // tb改為唯讀
            //textBox1.ReadOnly = true;
            //textBox2.ReadOnly = true;
            //textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

            //tb4增加捲軸
            textBox4.ScrollBars = ScrollBars.Both;

            //SQL new出來
            cn = new SqlConnection(cnStr);
            da = new SqlDataAdapter();
            ds = new DataSet();
            cb = new SqlCommandBuilder(da);

            //初始化page宣告
            index = 0;
            count = 0;
        }

        // 重複的事情搬來 function
        private void set()
        {
            //給搬運工SQL指令
            da.SelectCommand = new SqlCommand("select * from DimCurrency order by CurrencyKey offset @a rows fetch next 10 rows only", cn);
            da.SelectCommand.Parameters.AddWithValue("@a", index); //複習用

            //設定dataGridVier外觀  ★一定要在Fill的指令前 才有用
            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //重按fill不讓資料重複
            if (ds.Tables["Dim"] != null && ds.Tables["Dim"].Rows.Count > 0)
            {
                ds.Tables["Dim"].Clear();
            }

            //搬運工運回來的資料放在ds這個DataSet裡面 並且取名叫 DimCurrency
            da.Fill(ds, "Dim");

            //讓資料顯示在dataGridView上
            dataGridView1.DataSource = ds.Tables["Dim"];
            dataGridView1.Columns["CurrencyKey"].HeaderText = "流水號";
            dataGridView1.Columns["CurrencyAlternateKey"].HeaderText = "縮寫";
            dataGridView1.Columns["CurrencyName"].HeaderText = "完整名稱";

            //把dataGridView上選到的資料binding再textBox上
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.DataBindings.Clear();
                }
            }

            // ADD() 控制項屬性,來源,來源成員
            textBox1.DataBindings.Add("Text", ds.Tables["Dim"], "CurrencyKey");
            textBox2.DataBindings.Add("Text", ds.Tables["Dim"], "CurrencyAlternateKey");
            textBox3.DataBindings.Add("Text", ds.Tables["Dim"], "CurrencyName");
        }

        // Fill按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            // 取得資料總筆數
            da.SelectCommand = new SqlCommand("select count(*) from DimCurrency", cn);
            da.Fill(ds, "count");
            count = (int)ds.Tables["count"].Rows[0].ItemArray[0];
            ds.Tables.Clear();

            // 資料顯示在dataGridView1上
            set();

            // Fill重按時 載入最初的預設值
            index = 0;
            button4.Enabled = false;
            button5.Enabled = true;
        }

        // 獲取狀態按鈕
        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";

            // 透過foreach 來撈出DataRow的集合
            foreach (DataRow item in ds.Tables["Dim"].Rows)
            {
                // 在tb4上面顯示 ds.Tables["Dim"]每一列的資料集合
                textBox4.Text += item.RowState + "===>" + string.Join(",", item.ItemArray) + Environment.NewLine;
            }

            button3.Enabled = true;
        }

        // 更新按鈕
        private void button3_Click(object sender, EventArgs e)
        {
            //給建築工給出update sql指令 交給 搬運工
            da.UpdateCommand = cb.GetUpdateCommand();

            //搬運工 執行 update指令 da.Update(更改範圍 | 更改資料來源)
            da.Update(ds.Tables["Dim"]);

            button2.Enabled = false;
            button3.Enabled = false;

            textBox4.Text = "Update Complete";
        }

        // 上一頁按鈕
        private void button4_Click(object sender, EventArgs e)
        {
            // index - 10
            index -= 10;
            
            // bt5的Enabled判斷 如果index只要小於count那代表下一頁可以按
            button5.Enabled = (index < count) ? true : false;

            // 設定index最小值不超過0
            index = (index < 0) ? 0 : index;

            // 自己的enabled判斷 如果index = 0 則代表沒有上一頁
            button4.Enabled = (index == 0) ? false : true;

            set();
        }

        // 下一頁按鈕
        private void button5_Click(object sender, EventArgs e)
        {
            // index + 10
            index += 10;

            // bt4的Enabled判斷 如果index只要大於0那代表上一頁可以按
            button4.Enabled = (index > 0) ? true : false;

            // 設定index的最大邊界 不超過count
            index = (index > count) ? index-=10 : index;

            // 自己的enabled判斷 如果index >= count - 10(因為一頁載入10筆) 則代表沒有下一頁
            button5.Enabled = (index >= count - 10) ? false : true;

            set();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string temp = string.Empty;

            // 如果沒載入資料 關閉視窗時 則不執行程式
            if(ds.Tables.Count > 0)
            {
                // foreach run所有資料 
                foreach (DataRow item in ds.Tables["Dim"].Rows)
                {
                    // 如果有資料狀態為Modified 關閉視窗時 則跳出MsgBox
                    if (item.RowState == DataRowState.Modified)
                    {
                        //if (MessageBox.Show("有已編輯，尚未更新的資料。\n真的要離開嗎？", "資料未更新", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        //{
                        //    e.Cancel = true;
                        //}

                        temp += string.Join(",", item.ItemArray) + "\n\r";
                    }                   
                }
                //宣告 result為 MsgBox按鈕的回傳值
                DialogResult result = MessageBox.Show($"有已編輯，尚未更新的資料。\n{temp}", "資料未更新", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                switch (result)
                {
                    // 如果使用者點選取消，則取消關閉Form1表單
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dataGridView1.Focus();
                //明倫的方法
                //dataGridView1.BindingContext[ds.Tables["Dim"]].EndCurrentEdit();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (DataRow item in ds.Tables["Dim"].Rows)
            {
                if (item.RowState == DataRowState.Modified)
                {
                    button2.Enabled = true;
                    break;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // da.Fill 走出去 + 走回來 + 放資料
            // da.Uptate(資料表) => 把橋放下來(自己啟動cn) 

            // 底下執行會錯誤
            //da.UpdateCommand.Parameters.Add("@p1",SqlDbType.VarChar,50).Value = textBox2.Text

            da.UpdateCommand = cb.GetUpdateCommand();

            
            da.UpdateCommand.Parameters[0].Value = textBox2.Text;
            da.UpdateCommand.Parameters[1].Value = textBox3.Text;
            da.UpdateCommand.Parameters[2].Value = textBox1.Text;
            da.UpdateCommand.Parameters[3].Value = textBox2.Text;
            da.UpdateCommand.Parameters[4].Value = "AfghaniApple";
            

            cn.Open();
            da.UpdateCommand.ExecuteNonQuery();
            cn.Close();

            button2.Enabled = false;
            button3.Enabled = false;

            textBox4.Text = "Update Complete";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // update v3 自己寫command + 自已帶參數
            da.UpdateCommand = new SqlCommand("UPDATE DimCurrency SET CurrencyAlternateKey = @a,CurrencyName = @b where CurrencyKey = @c", cn);
            da.UpdateCommand.Parameters.AddWithValue("@a",textBox2.Text);
            da.UpdateCommand.Parameters.AddWithValue("@b",textBox3.Text);
            da.UpdateCommand.Parameters.AddWithValue("@c",textBox1.Text);

            cn.Open();
            int i = da.UpdateCommand.ExecuteNonQuery();
            MessageBox.Show($"{i}資料");
            cn.Close();

            textBox4.Text = "Update Complete";
            //textBox1.DataBindings.Add("Text", ds.Tables["Dim"], "CurrencyKey");
            //textBox2.DataBindings.Add("Text", ds.Tables["Dim"], "CurrencyAlternateKey");
            //textBox3.DataBindings.Add("Text", ds.Tables["Dim"], "CurrencyName");
        }
    }
}


