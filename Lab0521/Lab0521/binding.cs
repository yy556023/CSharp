using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0521
{
    public partial class binding : Form
    {
        public binding()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //方法A
            //label1.DataBindings.Clear();
            //label1.DataBindings.Add("text", textBox1, "text");
            
            //方法B
            //if (label1.DataBindings.Count == 0)
            //{
            //    label1.DataBindings.Add("text", textBox1, "text");
            //}

            //方法C
            foreach (Control item in this.Controls)
            {
                // 10.
                //textBox2.Text += item.Name + Environment.NewLine;
                // 20.
                if (item is Label)
                {
                    item.DataBindings.Clear();
                    item.DataBindings.Add("text", textBox1, "text");
                }            
            }
        }
    }
}
