using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0602_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dataList = new string[] { "a1", "b", "a2", "c" };

            var query = from o in dataList
                        select o;

            foreach (var item in query)
            {
                MessageBox.Show(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] dataList = new string[] { "a1", "b", "a2", "c" };

            var query = from o in dataList
                        orderby dataList descending
                        select o;

            foreach (var item in query)
            {
                MessageBox.Show(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] dataList = new string[] { "a1", "b", "a2", "c" };

            var query = from o in dataList
                        where o.IndexOf("a") == 0
                        orderby dataList descending
                        select o;

            foreach (var item in query)
            {
                MessageBox.Show(item);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
