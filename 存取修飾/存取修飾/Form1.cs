using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 存取修飾
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    internal class a
    {
        protected int sex;
    }

    class b : a
    {
        static void ff()
        {
            a test = new a();
            b test2 = new b();
            test2.sex = 1;
        }
    }
}
