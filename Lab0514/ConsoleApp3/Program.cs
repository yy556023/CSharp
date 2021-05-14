using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoFlower x = new DemoFlower();
            x.FlowerName = "木棉花";
            Console.WriteLine(x.FlowerName);
            DemoFlower x2 = x;
            x2.FlowerName = "ㄎㄎ";
            Console.WriteLine(x2.FlowerName);

        }

        class DemoApple
        {

        }

        struct DemoFlower
        { //struct 結構 屬性+方法
            public string FlowerName;

            public void FlowerPrint()
            {
                Console.WriteLine("flower");
            }
        }
    }
}
