using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int h(ref int x, ref int y, out int k)
            //{
            //    int z = x + y;
            //    x = 0;
            //    y = 0;
            //    k = 999;
            //    return z;
            //}

            //int a = 1;
            //int b = 3;
            //int c;
            //int demo = h(ref a, ref b, out c);

            //Console.WriteLine(a + " " + b);

            //int demo = int.Parse("1a"); //輸入字串格是不正確
            //int demo = int.Parse("1.5") // 格式不正確
            //double demo3 = double.Parse("1.5"); // 1.5

            int.TryParse("1234", out int demo2);

            //記憶體位置=======================================
            int a = 99;
            int b = 99;

            bool temp = object.ReferenceEquals(a, b);
            Console.WriteLine(temp); //False

            string x = "123";
            string y = "123";
            string z = x;

            z = "bee";

            //Console.WriteLine(x); //123

            temp = object.ReferenceEquals(x, y);
            Console.WriteLine(temp); //True


            Console.ReadLine();

        }
    }
}
