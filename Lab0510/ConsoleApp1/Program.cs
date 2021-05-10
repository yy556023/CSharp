using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("輸入1～7以選擇function：");
            char x = Convert.ToChar(Console.ReadLine());

            switch (x)
            {
                case '1':
                    function1();
                    break;
                case '2':
                    function2();
                    break;
                case '3':
                    function3();
                    break;
                case '4':
                    function4();
                    break;
                case '5':
                    function5();
                    break;
                case '6':
                    function6();
                    break;
                case '7':
                    function7();
                    break;
            }





            //int a = 1 / 3;

            //double b = 1 / 3;

            //double c = 1.0 / 3.0;

            //decimal d = 1/3;

            //Console.WriteLine(Convert.ToString(a) +"\n"+ Convert.ToString(b) + 
            //    "\n"+Convert.ToString(c)+Convert.ToString(d));

            // 格式化數值 | 數值格式化

            //double test = 2.0 / 3.0;
            //Console.WriteLine(test); //0.66666666667
            //Console.WriteLine($"格式化(C)：{test:C}"); //NT$ 0.67
            //Console.WriteLine($"格式化(C)：{test:C5}"); //NT$ 0.66667

            //Console.WriteLine($"格式化(F)：{test:F}"); //0.67
            //Console.WriteLine($"格式化(F5)：{test:F5}"); //0.66667


            //Console.WriteLine($"格式化(N)：{1234567:N}"); //1,234,567.00
            //Console.WriteLine($"格式化(N5)：{1234567:N5}"); //1,234,567.00000


            //Console.WriteLine($"格式化(F)：{1234567:F}"); //1234567.00
            //Console.WriteLine($"格式化(F5)：{1234567:F5}"); //1234567.00000

        }

        static void function1()
        {
            string[] test = { "春節", "清明節", "勞動節", "端午節", "中秋節", "國慶日" };

            Console.WriteLine($"國定假日為：{test[0]},{test[1]},{test[2]},{test[3]},{test[4]}," +
                $"{test[5]}");

         
        }

        static void function2()
        {
            double chinese = 80.56;
            double math = 76.54;

            Console.WriteLine($"國文成績：{chinese:f1}、數學成績：{math:f1}\n");
            Console.WriteLine(string.Format("國文成績：{0:f1}、數學成績：{1:f1}",chinese,math));
            Console.ReadKey();
        }

        static void function3()
        {
            try
            {
                const double inch = 2.53999;
                string temp;

                Console.Write("輸入公分(cm)：");
                temp = Console.ReadLine();
                double x = Convert.ToDouble(temp);

                Console.WriteLine($"{x * inch:f2}英吋(inch)");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(e.Message + "請重新輸入！");
                Console.WriteLine("---------------------------------");
                function3();
            }           
        }

        static void function4()
        {
            try
            {
                string temp;

                Console.WriteLine("---------------------------------");
                Console.WriteLine("★輸入兩個數字比大小★");
                Console.WriteLine("---------------------------------");
                Console.Write("輸入數字1：");
                temp = Console.ReadLine();
                double x = Convert.ToDouble(temp);
                Console.Write("輸入數字2：");
                temp = Console.ReadLine();
                double y = Convert.ToDouble(temp);

                temp = (x > y) ? x + "" : y + "";

                Console.WriteLine("比較大的是："+ temp);
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(e.Message + "請重新輸入！");
                Console.WriteLine("---------------------------------");
                function4();
            }        
        }

        static void function5()
        {
            try
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("★輸入兩個數字來看輸入2是不是輸入1的倍數★");
                Console.WriteLine("----------------------------------------");
                Console.Write("輸入1：");
                double x = double.Parse(Console.ReadLine());
                Console.Write("輸入2：");
                double y = double.Parse(Console.ReadLine());

                if (x > y)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("輸入錯誤！重新輸入！");
                    Console.WriteLine("---------------------------------");
                    function5();
                }
                else
                {
                    string test = (y % x == 0) ? "是" : "否";

                    Console.WriteLine(test);
                    Console.ReadKey();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(e.Message + "請重新輸入！");
                Console.WriteLine("---------------------------------");
                function5();
            }       
        }

        static void function6()
        {
            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("★請輸入衣服件數：★");
                Console.WriteLine("---------------------------------");
                double cloth = 399;
                double dis = 0.79;
                double check = 1500;
                double x = Convert.ToDouble(Console.ReadLine());
                double sum = x * cloth;

                if (sum > check)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($"總金額：{sum:c0}，消費滿{check},打{dis * 100}折，折扣後金額：{sum * dis:c0}");
                    Console.WriteLine("---------------------------------");
                    Console.ReadKey();

                   
                }
                else
                {
                    Console.WriteLine("-----------------------------------------------");
                    Console.WriteLine($"目前金額：{sum:c0}，還差{1500 - sum:c0}元就可以打折");
                    Console.WriteLine("-----------------------------------------------");
                    Console.ReadKey();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(e.Message + "請重新輸入！");
                Console.WriteLine("---------------------------------");
                function6();
            }
        }

        static void function7()
        {
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("★輸入三角形三邊長(數字不等於0且大於0)：★");
                Console.WriteLine("--------------------------------------------");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double z = double.Parse(Console.ReadLine());


                double max = Math.Max(x, Math.Max(y, z));
                double mid = Math.Min(Math.Min(Math.Max(x, y), Math.Max(y, z)), Math.Max(x, z));
                double min = Math.Min(x, Math.Min(y, z));
                Console.WriteLine($"MAX：{max:n0} MID：{mid:n0} MIN：{min:n0}");

                x = Math.Abs(x);
                y = Math.Abs(y);
                z = Math.Abs(z);

                double[] tri = { x, y, z };

                Array.Sort(tri);
                Array.Reverse(tri);

                x = tri[0];
                y = tri[1];
                z = tri[2];

                if (x == y + z || x > y + z)
                {
                    Console.WriteLine("無法形成三角形");
                    Console.ReadKey();
                    return;
                }

                if (x != y || y != z || x != z &&(x != 0 && y != 0 && z != 0))
                {
                    x = Math.Pow(x, 2);
                    y = Math.Pow(y, 2);
                    z = Math.Pow(z, 2);

                    if (x > y + z)
                    {
                        Console.WriteLine("鈍角");
                    }
                    else if (x < y + z)
                    {
                        Console.WriteLine("銳角");
                    }
                    else
                    {
                        Console.WriteLine("直角");
                    }
                }
                else if (x == y && y == z)
                {
                    Console.WriteLine("正三角");
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine(e.Message+"請重新輸入！");
                Console.WriteLine("---------------------------------");
                function7();
            }           
        }
    }
}
