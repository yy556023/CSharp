using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0604_EDM_MultiUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LabDbEntities db = new LabDbEntities();
            Product p = db.Products.Find(2);
            label1.Text = p.UnitsInStock.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabDbEntities db = new LabDbEntities();
            Product p = db.Products.Find(2);
            p.UnitsInStock -= 1;
            System.Threading.Thread.Sleep(1000 * 5);
            db.SaveChanges();
            (sender as Button).Text = "Done";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LabDbEntities db = new LabDbEntities();
            var t = db.Database.BeginTransaction(IsolationLevel.ReadCommitted);
            //var query = from o in db.Products
            //            where o.ProductId == 2
            //            select o;
            //Product pp = query.FirstOrDefault();


            Product p = db.Products.SqlQuery("select * from Products with (xLock) where ProductId = 2").FirstOrDefault();
            p.UnitsInStock -= 1;
            db.SaveChanges();
            System.Threading.Thread.Sleep(1000 * 5);
            t.Commit();
            (sender as Button).Text = "Done";
        }
    }
}
