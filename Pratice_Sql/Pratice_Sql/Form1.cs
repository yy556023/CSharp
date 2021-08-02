using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice_Sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            da.Fill(ds.Products);

            var query = from p in ds.Products
                        where p.ProductID == 1
                        select p;

            var query2 = query.SingleOrDefault();



            dataGridView1.DataSource = query2;

        }
    }
}
