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

namespace Lab0524
{
    public partial class Form1 : Form
    {
        #region SQL
        private string cnStr = Properties.Settings.Default.cnStr;
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
            //SQL new出來
            cn = new SqlConnection(cnStr);
            da = new SqlDataAdapter();
            ds = new DataSet();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            button1.Text = "Fill";
            button2.Text = "顯示PK";
            button3.Text = "Insert";
            button4.Text = "Insert V2";
            button5.Text = "Insert V3";
            button6.Text = "Delete";
            button7.Text = "Delete V2";
            label1.Text = "CurrencyKey";
            label2.Text = "CurrencyAlternateKey";
            label3.Text = "CurrencyName";

            textBox4.ScrollBars = ScrollBars.Both;
        }

        private void set()
        {
            da.SelectCommand = new SqlCommand("select * from DimCurrency", cn);
            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (ds.Tables["Dim"] != null && ds.Tables["Dim"].Rows.Count > 0)
            {
                ds.Tables["Dim"].Clear();
            }
            da.FillSchema(ds, SchemaType.Mapped, "Dim");
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "Dim");
            dataGridView1.DataSource = ds.Tables["Dim"];
            dataGridView1.Columns["CurrencyKey"].HeaderText = "流水號";
            dataGridView1.Columns["CurrencyAlternateKey"].HeaderText = "縮寫";
            dataGridView1.Columns["CurrencyName"].HeaderText = "完整名稱";

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

        private void button1_Click(object sender, EventArgs e)
        {
            set();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            DataColumn[] apple = ds.Tables["Dim"].PrimaryKey;

            for (int i = 0; i < apple.Length; i++)
            {
                textBox4.Text = apple[i].ColumnName + "\n"; //Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 10.偷看狀態
            textBox4.Text = "";
            foreach (DataRow item in ds.Tables["Dim"].Rows) 
            {
                textBox4.Text += item.RowState + "===>" + string.Join(",", item.ItemArray) + "\r\n";
            }
            // 20.請走路工更新
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.InsertCommand = cb.GetInsertCommand();
            int i = da.Update(ds.Tables["Dim"]);
            MessageBox.Show($"{i}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 目標 透過 DataRow
            DataRow newRow = ds.Tables["Dim"].NewRow();

            newRow["CurrencyKey"] = textBox1.Text;
            newRow["CurrencyAlternateKey"] = textBox2.Text;
            newRow["CurrencyName"] = textBox3.Text;

            ds.Tables["Dim"].Rows.Add(newRow);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.InsertCommand = cb.GetInsertCommand();
            int i = da.Update(ds.Tables["Dim"]);
            MessageBox.Show($"{i}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO DimCurrency (CurrencyAlternateKey,CurrencyName) VALUES(@a,@b)";
            cmd.Connection = cn;
            cmd.Parameters.AddWithValue("@a",textBox2.Text);
            cmd.Parameters.AddWithValue("@b",textBox3.Text);

            cn.Open();
            da.InsertCommand = cmd;
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            textBox4.Text = index + 1 + " - " + string.Join(",", ds.Tables["Dim"].Rows[index].ItemArray);

            ds.Tables["Dim"].Rows[index].Delete();

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.DeleteCommand = cb.GetDeleteCommand();
            da.Update(ds.Tables["Dim"]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE DimCurrency WHERE CurrencyKey = @a";
            cmd.Parameters.AddWithValue("@a", textBox1.Text);

            cn.Open();
            da.DeleteCommand = cmd;
            da.DeleteCommand.ExecuteReader();
            cn.Close();

            textBox4.Text = "delete complete";

        }
    }
}
