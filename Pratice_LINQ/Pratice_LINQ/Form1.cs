using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> test = new List<string> { "a", "b", "c", "d" };

            var query = from p in test
                        select p;
            foreach (var item in query)
            {
                MessageBox.Show(item);
            }


        }
    }
}
