using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0528
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class CAnimal
        {
            public virtual void MakeSound()
            {
                MessageBox.Show("SEX!");
            }
        }

        public class CDog : CAnimal
        {
            public override void MakeSound()
            {
                MessageBox.Show("HaveSex!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CAnimal a = new CAnimal();
            a.MakeSound();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CAnimal b = new CDog();
            b.MakeSound();
        }
    }
}
