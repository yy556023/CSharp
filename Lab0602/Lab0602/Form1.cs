using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab0602
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.id = 1;
            emp1.name = "Jeter";

            Employee emp2 = new Employee()
            {
                id = 2,
                name = "Jeter"
            };

            var emp7 = new Employee() { id = 7, name = "Jeremy Lin" };

            //Employee[] empList = new Employee[3];
            //empList[0] = emp1;
            //empList[0] = emp1;
            //empList[0] = emp1;

            var empList = new Employee[]
            {
                new Employee(){id = 1,name = "Taiwan" },
                new Employee(){id = 2,name = "Jeter" },
                new Employee(){id = 7,name = "Lin" }
            };

            button1.Text = empList[1].name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var emp10 = new { id = 10, name = "Messi", country = "A." };
            button2.Text = emp10.GetType().ToString();
            this.Text = emp10.LastName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cityList = new[]
            {
                new {cityID= "TC" ,cityName = "Taichung"},
                new {cityID = "TP" ,cityName = "Taipei"}
            };
        }
    }
    class CityType
    {
        public string cityID { get; set; }
        public string cityName { get; set; }
    }

    class Employee
    {
        private int _id;
        private string _name;

        public int id { get; set; }
        public string name { get; set; }
        
        public Employee()
        {
            
        }

    }
}
