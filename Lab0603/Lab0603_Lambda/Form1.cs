using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0603_Lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        delegate int AddDelegate(int x, int unit);

        private void button1_Click(object sender, EventArgs e)
        {
            int Answer = Add(1000, 1);
            (sender as Button).Text = Answer.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDelegate p = (x, y) => x + y * 10;

            int answer = p(1000, 1);
            this.Text = answer.ToString();
        }
    }
}
