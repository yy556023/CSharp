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

            string d = "------------------------------------------------------------------------------------------------";
            Console.Write("★輸入1～9其中之一：");
            string x = Console.ReadLine();
            Console.WriteLine(d);

            switch (x)
            {
                case "1":
                    function1();
                    break;
                case "2":
                    function2();
                    break;
                case "3":
                    function3();
                    break;
                case "4":
                    function4();
                    break;
                case "5":
                    function5();
                    break;
                case "6":
                    function6();
                    break;
                case "7":
                    function7();
                    break;
                case "8":
                    function8();
                    break;
                case "9":
                    function9();
                    break;
                case "exit":
                    System.Environment.Exit(System.Environment.ExitCode);
                    break;
                default:
                    Console.WriteLine("沒這東西。");
                    Console.WriteLine(d);
                    Main();
                    return;
            }
        }

        static void function1()
        {
            // 01.依照員工的年資計算獎金        
            //    條件達一年未滿三年，獎金一個月、達三年未滿六年，獎金三個月，超過六年，發放獎金五個月
            string d = "------------------------------------------------------------------------------------------------";

            try
            {
                
                Console.Write("★輸入年資：");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("★輸入薪水：");
                double y = Convert.ToDouble(Console.ReadLine());

                string z = $"試算年資：{x} 年，薪水：{y:c0} 元\n";

                if (x < 0 || y <= 0)
                {
                    Console.WriteLine(d);
                    Console.WriteLine("輸入錯誤！請重新輸入！");
                    Console.WriteLine(d);
                    function1();
                    return;
                }

                if (x >= 6)
                {
                    Console.WriteLine(d);
                    Console.WriteLine(z);
                    Console.WriteLine($"獎金五個月，共{y * 5:c0}");
                    Console.WriteLine(d);
                }
                else if (3 <= x && x < 6)
                {
                    Console.WriteLine(d);
                    Console.WriteLine(z);
                    Console.WriteLine($"獎金三個月，共{y * 3:c0}");
                    Console.WriteLine(d);
                }
                else if (1 <= x && x < 3)
                {
                    Console.WriteLine(d);
                    Console.WriteLine(z);
                    Console.WriteLine($"獎金一個月，共{y:c0}");
                    Console.WriteLine(d);
                }
                else
                {
                    Console.WriteLine(d);
                    Console.WriteLine(z);
                    Console.WriteLine("沒獎金");
                    Console.WriteLine(d);
                }
                Main();
            }
            catch(Exception e)
            {
                Console.WriteLine(d);
                Console.WriteLine(e.Message);
                Console.WriteLine(d);
                function1();
            }
            
        }

        static void function2()
        {
            // 02.計算出 1 + 3 + 5.. + 99 的總和
            //1 + ....(2n - 1)

            string d = "------------------------------------------------------------------------------------------------";

            try
            {
                Console.Write("★輸入一數字：");
                double z = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(d);
                double y = 1;

                double x = (1 + (2 * z - 1)) * z / 2;

                while (y < (2 * z - 1))
                {

                    Console.Write($"{y} + ");
                    y += 2;
                }
                Console.Write($"{y} = {x}\n");
                Console.WriteLine(d);
                Main();
            }
            catch(Exception e)
            {
                Console.WriteLine(d);
                Console.WriteLine(e.Message);
                Console.WriteLine(d);
                function2();
            }
            
        }

        static void function3()
        {
            // 03.計算出 1 * 2 * ... * n  的總和

            string d = "------------------------------------------------------------------------------------------------";

            try
            {
                Console.Write("★輸入一數字n：");

                double x = Convert.ToDouble(Console.ReadLine());
                double sum = x;
                int i = 0;
                string temp = "";

                for (i = 0; i < x ; i++) 
                {
                    if (i != x - 1) 
                    {
                        
                        temp += (i + 1) + " * ";                         
                    }
                    else
                    {
                        temp += (i + 1) + " ";
                    }
                    
                }

                while (x > 1)
                {
                    sum = sum * (x - 1);
                    x--;
                }

                Console.WriteLine(d);
                Console.WriteLine($"{temp}= {sum:n0}");
                Console.WriteLine(d);
                Main();
            }
            catch(Exception e)
            {
                Console.WriteLine(d);
                Console.WriteLine(e.Message);
                Console.WriteLine(d);
                function3();
            }
        }

        static void function4()
        {
            // 04.輸出九九乘法表 

            string d = "------------------------------------------------------------------------------------------------";
            
            try
            {
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        Console.Write(Convert.ToString($"{(i + 1)}*{(j + 1)}={(i + 1) * (j + 1)}\t|"));
                        if (j == 8)
                        {
                            Console.Write("\n");
                        }
                    }
                }
                Console.WriteLine(d);
                Main();
            }
            catch(Exception e)
            {
                Console.WriteLine(d);
                Console.WriteLine(e.Message);
                Console.WriteLine(d);
                function4();
            }
            
        }
    
        static void function5()
        {
            // 05.底下的迴圈各自會跑出什麼結果? 

            //Console.WriteLine("===【先觀看底下迴圈的結果，在實際執行查看】===");
            //int a = 10, b = 20, c;

            //do
            //{
            //    c = a + b;
            //    a -= 1;
            //} while (b < 0);

            //Console.WriteLine($"A，do while() 迴圈後，c 的值為：{c}、a 的值為：{a}"); //c = 30, a = 9
            //Console.ReadKey();

            //a = 10;
            //b = 20;
            //c = 0;
            //do
            //{
            //    for (c = 1; c <= 5; c++) // 1 2 3 4 5
            //    {
            //        a += c;
            //    }
            //    b -= 1;
            //} while (b <= 0);

            //Console.WriteLine($"B，do while() 迴圈後，a 的值為：{a}、b 的值為：{b}"); // a = 25, b = 19
            //Console.ReadKey();

            //a = 10;
            //b = 10;
            //c = 10;
            //while (c >= 0) // 10 9 8 7 6 5 4 3 2 1 0
            //{
            //    a = a + b;
            //    c = c - 1;
            //}

            //Console.WriteLine($"C，while() 迴圈後，a 的值為：{a}、c 的值為：{c}"); // a = 120, c = -1
            //Console.ReadKey();
            Main();
        }
    
        static void function6()
        {
            // 06.讓使用者輸入一個數字，使用算出這個數字有幾位數。
            //    條件：使用while迴圈和四則運算

            string d = "------------------------------------------------------------------------------------------------";

            try
            {
                Console.Write("★輸入一串數字：");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(d);
                double y = x;
                int temp = 0;

                while (y > 10)
                {
                    y /= 10;
                    temp++;
                }
                temp++;

                Console.WriteLine($"數字：{x:n0}，總共 {temp:n0} 位數");
                Console.WriteLine(d);
                Main();
            } 
            catch (Exception e)
            {
                Console.WriteLine(d);
                Console.WriteLine(e.Message);
                Console.WriteLine(d);
                function6();
            }
        }

        static void function7()
        {
            // 07.水仙花數，判斷100 - 999之間，列出有哪些數值是水仙花數。
            //    條件：使用while迴圈
            //    若三位數字abc，abc = (a * a * a) + (b * b * b) + (c * c * c)，abc就是一個水仙花數
            //    Ans: 153、370、371、407

            string d = "------------------------------------------------------------------------------------------------";

            try
            {
                int x = 100;
                double[] m = new double[3];
                string sum1 = "";
                string sum2 = "";
                List<double> temp = new List<double>();

                while (x < 1000)
                {
                    m[0] = x / 100;
                    m[1] = (x % 100) / 10;
                    m[2] = ((x % 100) % 10);

                    double sum = (Math.Pow(m[0], 3) + Math.Pow(m[1], 3) + Math.Pow(m[2], 3));

                    sum1 = Convert.ToString(x);
                    sum2 = Convert.ToString(sum);

                    if (sum1 == sum2)
                    {
                        temp.Add(x);
                    }
                    x++;
                }

                Console.Write("100～999的水仙花數有：");

                foreach (double y in temp)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine($"\n{d}");
                Main();
            }
            catch (Exception e)
            {
                Console.WriteLine(d);
                Console.WriteLine(e.Message);
                Console.WriteLine(d);
                function7();
            }
        }

        static void function8()
        {
            // 08.宣告一個陣列，使用迴圈放入數值1-10，再使陣列內容反轉印出 
            //    (不使用Array.Reverse())

            string d = "------------------------------------------------------------------------------------------------";

            try
            {
                int[] x = new int[10];
                int y = 1;
                int i = 0;

                for (i = 0; i < x.Length; i++) 
                {
                    x[i] = y;
                    y++;
                }

                for (; i > 1; i--)
                {
                    Console.Write(x[i - 1] + ",");
                }
                Console.Write(x[i - 1]);

                Console.WriteLine($"\n{d}");
                Main();
            }
            catch (Exception e)
            {
                Console.WriteLine(d);
                Console.WriteLine(e.Message);
                Console.WriteLine(d);
                function8();
            }
        }

        static void function9()
        {
            // 09.費式數列的前兩項為 1、1，之後的每一項為前兩項之和
            //    前10項為：1、1、2、3、5、8、13、21、34、55 
            //    (透過陣列完成)

            string d = "------------------------------------------------------------------------------------------------";

            try
            {
                Console.Write("★輸入一個數字：");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(d);
                int i = 0;
                int[] y = new int[x];

                y[0] = 1;
                y[1] = 1;

                for (i = 0; i < x; i++)
                {
                    if (i < 2)
                    {
                        continue;
                    }
                    else
                    {
                        y[i] = y[i - 1] + y[i - 2];
                    }
                }
                Console.WriteLine(string.Join(" ", y));

                Array.Reverse(y);

                for (; i > 0; i--)
                {
                    Console.Write(y[i - 1] + " ");
                }
                
                Console.WriteLine($"\n{d}");
                Main();
            }      
            catch (Exception e)
            {
                Console.WriteLine(d);
                Console.WriteLine(e.Message);
                Console.WriteLine(d);
                function9();
            }
        }
    }
}
