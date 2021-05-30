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

namespace combobox
{
    public partial class Form1 : Form
    {
        #region SQL
        private string cnStr = Properties.Settings.Default.cn;
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
            if (ds.Tables["DP"] != null && ds.Tables["DP"].Rows.Count > 0)
            {
                ds.Tables["DP"].Clear();
            }

            da.Fill(ds, "DP");
            dataGridView1.DataSource = ds.Tables["DP"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(cnStr)) 
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ProductCategoryKey,EnglishProductCategoryName FROM DimProductCategory", cn))  
                {
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Dictionary<string, string> dc = new Dictionary<string, string>();
                    dc.Add("0", "請選擇");
                    while (dr.Read())
                    {
                        dc.Add(dr["ProductCategoryKey"].ToString(), dr["EnglishProductCategoryName"].ToString());
                    }

                    comboBox1.DataSource = new BindingSource(dc, null);
                    comboBox1.DisplayMember = "Value"; //表
                    comboBox1.ValueMember = "Key"; //裏
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedIndex + " - " + comboBox1.SelectedItem;
            SqlCommand cmd = new SqlCommand("select ProductSubcategoryKey, EnglishProductSubcategoryName, SpanishProductSubcategoryName" +
                    ", FrenchProductSubcategoryName from DimProductSubcategory where ProductCategoryKey = @a", cn);
            cmd.Parameters.AddWithValue("@a", ((KeyValuePair<string, string>)comboBox1.SelectedItem).Key);
            da.SelectCommand = cmd;

            set();
        }
    }
}
