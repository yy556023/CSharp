using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0602_ADO.NET
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
                        select p;

            dataGridView1.DataSource = query.ToList();
        }

        //Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True
    }
}
