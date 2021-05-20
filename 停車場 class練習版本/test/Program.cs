using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main()
        {

            string check = "y";

            while (check == "y" || check == "Y")
            {
                Console.WriteLine("=====停車收費試算=====");
                Console.WriteLine("請輸入進場時間：");
                string s_t = Console.ReadLine();
                Console.WriteLine("請輸入離場時間：");
                string e_t = Console.ReadLine();

                Pay test1 = new Pay(s_t, e_t);
                test1.Print();
                Console.WriteLine("是否要繼續查詢？ Y/N");
                check = Console.ReadLine();
            }
        }
    }
}
