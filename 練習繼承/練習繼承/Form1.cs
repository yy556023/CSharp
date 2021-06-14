using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 練習繼承
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CDog a = new CDog(100,50);
            MessageBox.Show(a.price.ToString());
            MessageBox.Show(a.Weight.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            練習元件.Class1 a = new 練習元件.Class1();
            a.ff();
        }
    }

    public class CAnimal
    {
        public virtual void MakeSound()
        {
            MessageBox.Show("Fuck");
        }

        public CAnimal()
        {
            this.Weight = 0;
        }

        public CAnimal(int WeightValue)
        {
            this.Weight = WeightValue;
        }

        private int _Weight = 0;

        public int Weight
        {
            get
            {
                return this._Weight;
            }
            set
            {
                if (value >= 0)
                {
                    this._Weight = value;
                }
            }
        }
    }

    public class CDog : CAnimal
    {
        public int price { get; set; }

        public CDog() : base()
        {
            this.price = 0;
        }

        public CDog(int v1,int v2) : base(v1)
        {
            this.price = v1;
        }

        public override void MakeSound()
        {
            MessageBox.Show("Fuck You");
        }
    }
}
