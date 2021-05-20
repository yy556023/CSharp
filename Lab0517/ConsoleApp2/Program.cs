using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        enum Season
        {
            Spring = 3,
            Summer = 13,
            Auturn = 23,
            Winter
        }

        enum ConsoleColor
        {
            Black,
            Red,
            Blue
        }

        static void Main(string[] args)
        {
            int i = 123;
            string k = "apple";
            double s = 123.1;
            List<int> z = new List<int>();
            z.Add(999);
            //Console.WriteLine(i);
            //Console.WriteLine((int)s);
            //Console.WriteLine(z[0]);
            Console.WriteLine(Season.Summer);      //Summer
            Console.WriteLine((int)Season.Summer); //13
            Console.WriteLine((Season)24);         //Winter
            //Console.BackgroundColor = ConsoleColor.

            DateTime dl = new DateTime(2021,8,19);
            
            Console.WriteLine(dl);

            DateTime d3 = DateTime.Now;
            Console.WriteLine(d3.Day);

            //d3.DayOfWeek = DayOfWeek.

            switch ((int)d3.DayOfWeek)
            {
                case 6:
                case 7:
                    Console.WriteLine($"今天{d3.DayOfWeek}，應該不用上課");
                    break;
                default:
                    Console.WriteLine($"今天 {d3.DayOfWeek} 要上課");
                    break;
            }

        }
    }
}
