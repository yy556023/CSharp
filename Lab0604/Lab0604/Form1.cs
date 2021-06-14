using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0604
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LabDbEntities context = new LabDbEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            var query = from p in context.Products
                        join c in context.Categories on p.CategoryId equals c.CategoryId
                        select new
                        {
                            CategoryName = c.CategoryName,
                            ProductID = p.ProductId,
                            ProductName = p.ProductName,
                            UnitsinStock = p.UnitsInStock
                        };

            dataGridView1.DataSource = query.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = from p in context.Products
                        where p.ProductId == 1
                        select p;
            Product prod = query.Single();

            Product prod = context.Products.Single(o => o.ProductId == 1);

            Product prod = context.Products.Find(1);

            //Product prod = context.Products.Single(o => o.ProductId == 1);

            (sender as Button).Text = prod.ProductName;
        }
    }
}
