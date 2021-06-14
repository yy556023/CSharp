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

namespace Pratice0604
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            da.Fill(ds.Products);

            dataGridView1.DataSource = ds.Products;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            da.Update(ds.Products);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=LabDb;Integrated Security=True");
            SqlDataAdapter da2 = new SqlDataAdapter();
            DataSet ds2 = new DataSet();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Products";
            cmd.Connection = cn;

            da2.SelectCommand = cmd;
            da2.Fill(ds2,"test");

            dataGridView1.DataSource = ds2.Tables["test"];

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            DataSet ds2 = new DataSet();
            
            using (SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=LabDb;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("update Products set UnitsInStock = 20 where ProductId = 2", cn))
                {
                    SqlDataAdapter da2 = new SqlDataAdapter();

                    cn.Open();
                    da2.UpdateCommand = cmd;
                    da2.UpdateCommand.ExecuteNonQuery();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow newRow = ds.Products.NewRow();

            newRow[0] = 6;
            newRow[1] = 2;
            newRow[2] = "Mother Fucker";
            newRow[3] = 90000;
            newRow[4] = 100;

            ds.Products.Rows.Add(newRow);

            da.Update(ds.Products);

        }

        private void button6_Click(object sender, EventArgs e)
        {


        }
    }
}
