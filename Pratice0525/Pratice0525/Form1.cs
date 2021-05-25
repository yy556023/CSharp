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

namespace Pratice0525
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

        #region dgv
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
            textBox4.ScrollBars = ScrollBars.Both;
            index = 0;
        }

        private void set()
        {
            if (ds.Tables["Dim"] != null && ds.Tables["Dim"].Rows.Count > 0)
            {
                ds.Tables["Dim"].Clear();
            }

            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            da.FillSchema(ds, SchemaType.Mapped, "AWDimCurrency");
            da.Fill(ds, "Dim");

            dataGridView1.DataSource = ds.Tables["Dim"];
            dataGridView1.Columns["CurrencyKey"].HeaderText = "流水號";
            dataGridView1.Columns["CurrencyAlternateKey"].HeaderText = "縮寫";
            dataGridView1.Columns["CurrencyName"].HeaderText = "完整名稱";
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //textBox1.Text = dataGridView1.CurrentRow.Cells["CurrencyKey"].Value.ToString();
            //textBox2.Text = dataGridView1.CurrentRow.Cells["CurrencyAlternateKey"].Value.ToString();
            //textBox3.Text = dataGridView1.CurrentRow.Cells["CurrencyName"].Value.ToString();
        }

        // Fill
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from AWDimCurrency";
            da.SelectCommand = cmd;

            set();

            foreach (DataRow item in ds.Tables["Dim"].Rows)
            {
                comboBox1.Items.Add(item.ItemArray[0].ToString().PadLeft(3, '0') + " " + item.ItemArray[2]);
            }
            comboBox1.Text = "XXX 請選擇貨幣";


            //==========DataBinding複習用============
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.DataBindings.Clear();
                }
            }
            textBox1.DataBindings.Add("Text", ds.Tables["Dim"], "CurrencyKey");
            textBox2.DataBindings.Add("Text", ds.Tables["Dim"], "CurrencyAlternateKey");
            textBox3.DataBindings.Add("Text", ds.Tables["Dim"], "CurrencyName");

            //==========DataBinding複習用============
        }

        // Update cb
        private void button2_Click(object sender, EventArgs e)
        {
            cb = new SqlCommandBuilder(da);
            da.UpdateCommand = cb.GetUpdateCommand();
            da.Update(ds.Tables["Dim"]);

            set();

            textBox4.Text = "Update Complete";
        }

        // Update V3 全手動
        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "UPDATE AWDimCurrency SET CurrencyAlternateKey = @a, CurrencyName = @b WHERE CurrencyKey = @c";
                cmd.Parameters.AddWithValue("@a", textBox2.Text);
                cmd.Parameters.AddWithValue("@b", textBox3.Text);
                cmd.Parameters.AddWithValue("@c", textBox1.Text);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            set();

            textBox4.Text = "Update Complete";
        }

        // Insert cb
        private void button5_Click(object sender, EventArgs e)
        {
            cb = new SqlCommandBuilder(da);
            da.InsertCommand = cb.GetInsertCommand();

            da.Update(ds.Tables["Dim"]);

            set();

            textBox4.Text = "Insert Complete";
        }

        // Insert V2 DataRow
        private void button6_Click(object sender, EventArgs e)
        {
            DataRow newRow = ds.Tables["Dim"].NewRow();

            newRow["CurrencyAlternateKey"] = textBox2.Text;
            newRow["CurrencyName"] = textBox3.Text;

            ds.Tables["Dim"].Rows.Add(newRow);

            cb = new SqlCommandBuilder(da);
            da.InsertCommand = cb.GetInsertCommand();

            da.Update(ds.Tables["Dim"]);

            set();

            textBox4.Text = "Insert Complete";
        }

        // Insert V3 全手動
        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO AWDimCurrency VALUES(@a, @b)";
            cmd.Parameters.AddWithValue("@a", textBox2.Text);
            cmd.Parameters.AddWithValue("@b", textBox3.Text);

            da.InsertCommand = cmd;

            cn.Open();
            da.InsertCommand.ExecuteNonQuery();
            cn.Close();

            set();

            textBox4.Text = "Insert Complete";
        }

        // Delete cb
        private void button8_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            ds.Tables["Dim"].Rows[index].Delete();

            cb = new SqlCommandBuilder(da);
            da.DeleteCommand = cb.GetDeleteCommand();
            da.Update(ds.Tables["Dim"]);

            set();

            textBox4.Text = "Delete Complete";
        }

        // Delete V2
        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除嗎?", "刪除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "DELETE AWDimCurrency WHERE CurrencyKey = @a";
                cmd.Parameters.AddWithValue("@a", textBox1.Text);

                da.DeleteCommand = cmd;

                cn.Open();
                da.DeleteCommand.ExecuteReader();
                cn.Close();

                set();

                textBox4.Text = "Delete Complete";
            }
        }

        // Status
        private void button10_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";

            foreach (DataRow item in ds.Tables["Dim"].Rows)
            {
                textBox4.Text += item.RowState + "===>" + string.Join(",", item.ItemArray) + "\r\n";
            }
        }

        // 在tb上 結束編輯時按Enter
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dataGridView1.BindingContext[ds.Tables["Dim"]].EndCurrentEdit();
            }
        }

        // cb選擇 dgv自動跳到顯示位置
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows[index].Selected = false;
            index = comboBox1.SelectedIndex;
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows[index].Index;
            dataGridView1.CurrentCell = dataGridView1.Rows[index].Cells[0];
            dataGridView1.Rows[index].Selected = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ds.Tables.Count > 0)
            {

                string temp = "";

                foreach (DataRow item in ds.Tables["Dim"].Rows)
                {
                    if (item.RowState == DataRowState.Modified || item.RowState == DataRowState.Added)
                    {
                        temp += string.Join(",", item.ItemArray) + "\r\n";
                    }
                }
                if (temp.Length > 0)
                {
                    if (MessageBox.Show($"有尚未保存的資料：\r\n{temp}確定要離開嗎？", "資料未保存", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
