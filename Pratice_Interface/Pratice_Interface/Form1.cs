using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //IDrive i;
            Car c = new Car();
            //i = c;
            Drive(c);
            //i.AddSpeed(10);
            //i.AddSpeed(10);
            //button1.Text = i.Speed.ToString();
        }

        void Drive(IDrive x)
        {
            x.AddSpeed(10);
            x.AddSpeed(20);
            button1.Text = x.Speed.ToString();
        }

        public interface IDrive
        {
            public int Speed { get; }
            public void AddSpeed(int x);
        }

        public class Car : IDrive
        {
            private int _Speed = 0;

            public int Speed
            {
                get { return this._Speed; }
            }

            public void AddSpeed(int x)
            {
                this._Speed += x;
            }
        }
    }
}
