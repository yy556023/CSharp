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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'adventureWorksDWDataSet.DimCurrency' 資料表。您可以視需要進行移動或移除。
            this.dimCurrencyTableAdapter.Fill(this.adventureWorksDWDataSet.DimCurrency);

        }
    }
}
