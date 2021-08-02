using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratice_Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox) 
                {
                    TextBox txt = ctrl as TextBox;
                    txt.ReadOnly = true;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // 微軟官方文件 SendKeys https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=net-5.0

            if (e.KeyCode == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }
            else if (e.KeyCode == Keys.Up)
            {
                SendKeys.Send("+{TAB}"); //+ 字串鍵 == shift
            }
        }
    }
}
