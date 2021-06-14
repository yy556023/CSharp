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

namespace Pratice0604_Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabDbEntities db = new LabDbEntities();

            var t = db.Database.BeginTransaction(IsolationLevel.ReadCommitted);

            Product p = db.Products.Single(o => o.ProductId == 2);
            label1.Text = p.UnitsInStock.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabDbEntities db = new LabDbEntities();

            var t = db.Database.BeginTransaction(IsolationLevel.ReadCommitted);

            Product p = db.Products.SqlQuery("select * from Products with (xLock) where ProductId = 2").FirstOrDefault();
            p.UnitsInStock--;
            System.Threading.Thread.Sleep(5000);
            db.SaveChanges();
            t.Commit();
            label1.Text = p.UnitsInStock.ToString();
        }
    }
}
