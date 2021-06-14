using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice_建構程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            p1.weight = 30;
            MessageBox.Show(p1.weight.ToString());
        }
    }

    public class Person
    {
        private int _weight = 50;

        public int weight
        {
            get { return _weight; }
            set { _weight = (value < 0) ? 0 : value; }
        }
    }
}
