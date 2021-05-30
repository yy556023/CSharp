using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0526
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal test = new Animal();
            test.MakeSound();
        }
    }

    class Animal
    {
        public void MakeSound()
        {
            MakeSound(3);
        }

        public void MakeSound(int x)
        {
            MakeSound(x);
        }

        public void MakeSound(int x, string y = "*")
        {
            string result = "Animal: ";

            for (int i = 0; i < x; i++)
            {
                result += y;
            }
            MessageBox.Show(result, "Hint");
        }
    }
}
