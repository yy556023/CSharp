using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0603
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            da.Fill(ds.Products);

            var query = from p in ds.Products
                        select new
                        {
                            id = p.ProductID,
                            name = p.ProductName
                        };

            dataGridView1.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.Fill(ds.Products);

            DataTable dt = ds.Products;

            var query = from p in dt.AsEnumerable()
                        select new
                        {
                            id = p["ProductID"],
                            name = p["ProductName"]
                        };

            dataGridView1.DataSource = query.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var query = from p in ds.Products
                        where p.ProductID == 1
                        select p;
            var result = query.Single();

            result.UnitPrice = 100;
            dataGridView1.DataSource = ds.Products;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            da.Update(ds.Products);
        }
    }
}
