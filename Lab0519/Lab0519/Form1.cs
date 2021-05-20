using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0519
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                button1_Click(button1,e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi", "hi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //點選後增加combobox item
            comboBox1.Items.Add("Fuck");
        }

        private void btnGetCtrl_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                lsItem.Items.Add(item.Name);
                //Console.WriteLine(item.Name);
            }
        }
    }
}
