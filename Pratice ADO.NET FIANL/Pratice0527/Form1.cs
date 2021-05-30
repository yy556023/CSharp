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

namespace Pratice0527
{
    public partial class Form1 : Form
    {
        #region SQL
        private string cnStr = Properties.Settings.Default.cn;
        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataSet ds;
        private DataTable dt;
        #endregion

        #region ForData
        private Dictionary<string, string> dcdb;
        private Dictionary<string, string> dctb;
        private Dictionary<string, string> dcsc;
        private string db;
        private string sc;
        private string tb;
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
            dt = new DataTable();
            dcdb = new Dictionary<string, string>();
            dcsc = new Dictionary<string, string>();
            dctb = new Dictionary<string, string>();
            DBcb.Enabled = false;
            SCcb.Enabled = false;
            TBcb.Enabled = false;
            SELECT.Enabled = false;
            UPDATE.Enabled = false;
            INSERT.Enabled = false;
            DELETE.Enabled = false;
        }

        private void set()
        {
            if (ds.Tables["dgv"] != null && ds.Tables["dgv"].Rows.Count > 0)
            {
                ds.Tables.Clear();
            }

            dataGridView1.RowTemplate.Height = 20;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            da.Fill(ds, "dgv");

            dataGridView1.DataSource = ds.Tables["dgv"];
        }

        // 獲取資料庫列表
        private void GET_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                using (SqlCommand cmd = new SqlCommand("select dbid, name from master.dbo.sysdatabases", cn))
                {
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    dcdb.Add("0", "請選擇");

                    while (dr.Read())
                    {
                        dcdb.Add(dr["dbid"].ToString(), dr["name"].ToString());
                    }

                    DBcb.DataSource = new BindingSource(dcdb, null);
                    DBcb.ValueMember = "key";
                    DBcb.DisplayMember = "value";
                }
            }

            GET.Enabled = false;
            DBcb.Enabled = true;
        }

        // 選好資料庫後 獲取結構描述列表
        private void DBcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dcsc.Clear();
            dcsc.Add("0", "請選擇");
            int i = 1;

            db = ((KeyValuePair<string, string>)DBcb.SelectedItem).Value;

            if (db != "請選擇")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"select SCHEMA_NAME from {db}.INFORMATION_SCHEMA.SCHEMATA where(SCHEMA_NAME not in ('guest', 'sys', 'INFORMATION_SCHEMA') and SCHEMA_NAME not like 'db_%') or SCHEMA_NAME = 'dbo'";
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dcsc.Add(i.ToString(), dr["SCHEMA_NAME"].ToString());
                    i++;
                }
                
                SCcb.DataSource = new BindingSource(dcsc, null);
                SCcb.ValueMember = "key";
                SCcb.DisplayMember = "value";
                SCcb.Enabled = true;
                cn.Close();
            }
            else
            {
                dataGridView1.DataSource = "";
                dcsc.Clear();
                dctb.Clear(); 
                SCcb.Text = "";
                TBcb.Text = "";
                SCcb.Enabled = false;
                TBcb.Enabled = false;
                SELECT.Enabled = false;
                UPDATE.Enabled = false;
                INSERT.Enabled = false;
                DELETE.Enabled = false;
            }
        }

        // 選好結構列表後 列出 該資料庫該結構列表所有的資料表
        private void SCcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dctb.Clear();
            dctb.Add("0", "請選擇");

            int i = 1;

            sc = ((KeyValuePair<string, string>)SCcb.SelectedItem).Value;

            if (sc != "請選擇")
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand($"select TABLE_NAME from {db}.INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = @a", cn);
                cmd.Parameters.AddWithValue("@a", sc);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dctb.Add(i.ToString(), dr["TABLE_NAME"].ToString());
                    i++;
                }

                TBcb.DataSource = new BindingSource(dctb, null);
                TBcb.ValueMember = "key";
                TBcb.DisplayMember = "value";
                TBcb.Enabled = true;
                cn.Close();
            }
            else
            {
                dctb.Clear();
                TBcb.Text = "";
                TBcb.Enabled = false;
                SELECT.Enabled = false;
                UPDATE.Enabled = false;
                INSERT.Enabled = false;
                DELETE.Enabled = false;
            }
        }

        // 選好資料表後啟用功能按鈕
        private void TBcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tb = ((KeyValuePair<string, string>)TBcb.SelectedItem).Value;

            if (tb == "請選擇")
            {
                SELECT.Enabled = false;
            }
            else
            {
                SELECT.Enabled = true;
            }
        }

        private void SELECT_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $"select * from {db}.{sc}.{tb}";
            cmd.Connection = cn;

            da.SelectCommand = cmd;

            set();

            UPDATE.Enabled = true;
            INSERT.Enabled = true;
            DELETE.Enabled = true;
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.UpdateCommand = cb.GetUpdateCommand();
            da.Update(ds.Tables["dgv"]);

            set();
        }

        // 請使用 Lab.dbo.AWDimCurrency
        private void INSERT_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataRow newRow = ds.Tables["dgv"].NewRow();

            newRow[0] = textBox2.Text;
            newRow[1] = textBox3.Text;
            newRow[2] = textBox4.Text;

            ds.Tables["dgv"].Rows.Add(newRow);
            da.InsertCommand = cb.GetInsertCommand();
            da.Update(ds.Tables["dgv"]);
                      
            set();

            MessageBox.Show("Insert成功", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要Delete嗎?","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int i = dataGridView1.CurrentRow.Index;

                ds.Tables["dgv"].Rows[i].Delete();
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                da.DeleteCommand = cb.GetDeleteCommand();
                da.Update(ds.Tables["dgv"]);

                set();

                MessageBox.Show("Delete成功", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }          
        }
    }
}
