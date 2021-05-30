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

namespace Lab0527
{
    public partial class Form1 : Form
    {
        #region SQL
        private string cnStr = Properties.Settings.Default.cn;
        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataSet ds;
        #endregion

        private int index;

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
            if (ds.Tables["AP"] != null && ds.Tables["AP"].Rows.Count > 0)
            {
                ds.Tables["AP"].Clear();
            }
            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            da.Fill(ds, "AP");
            dataGridView1.DataSource = ds.Tables["AP"];

            dataGridView1.Columns["ProductID"].HeaderText = "商品編號";
            dataGridView1.Columns["ProductName"].HeaderText = "商品名稱";
            dataGridView1.Columns["ProductPrice"].HeaderText = "商品價格";
        }

        private void Select_Click(object sender, EventArgs e)
        {
            da.SelectCommand = new SqlCommand("select * from ADOProduct",cn);

            set();

            //foreach (Control item in this.Controls)
            //{
            //    if (item is TextBox)
            //    {
            //        item.DataBindings.Clear();
            //    }
            //}

            //ProductID.DataBindings.Add("Text", ds.Tables["AP"],"ProductID");
            //ProductName.DataBindings.Add("Text", ds.Tables["AP"], "ProductName");
            //ProductPrice.DataBindings.Add("Text", ds.Tables["AP"], "ProductPrice");
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "insert into ADOProduct values(@ProductName,@ProductPrice);";
            cmd.Parameters.Add("ProductName", SqlDbType.NVarChar, 50).Value = ProductName.Text;
            cmd.Parameters.Add("ProductPrice", SqlDbType.Int).Value = ProductPrice.Text;

            cn.Open();
            da.InsertCommand = cmd;
            int i = da.InsertCommand.ExecuteNonQuery();
            MessageBox.Show($"作業筆數{i}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cn.Close();

            set();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "UPDATE ADOProduct SET ProductName = @ProductName,ProductPrice = @ProductPrice WHERE ProductID = @ProductID;";
            cmd.Parameters.Add("ProductName", SqlDbType.NVarChar, 50).Value = ProductName.Text;
            cmd.Parameters.Add("ProductPrice", SqlDbType.Int).Value = ProductPrice.Text;
            cmd.Parameters.Add("ProductID", SqlDbType.Int).Value = ProductID.Text;

            cn.Open();
            da.UpdateCommand = cmd;
            int i = da.UpdateCommand.ExecuteNonQuery();
            MessageBox.Show($"作業筆數{i}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cn.Close();

            set();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE ADOProduct WHERE ProductID = @ProductID;";
            cmd.Parameters.Add("ProductID", SqlDbType.Int).Value = ProductID.Text;

            cn.Open();
            da.DeleteCommand = cmd;
            int i = da.DeleteCommand.ExecuteNonQuery();
            MessageBox.Show($"作業筆數{i}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cn.Close();

            set();
        }

        private void Where_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;
                if ((string)row.Cells[1].Value == ProductName.Text) 
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    dataGridView1.CurrentCell = row.Cells[0];
                    row.Selected = true;
                }
            }
        }
    }
}
