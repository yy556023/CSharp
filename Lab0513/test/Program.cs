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
            //string a = Console.ReadLine();

            //switch (a)
            //{
            //    case "1":
            //        f1();
            //    break;
            //    case "2":
            //        f2();
            //    break;
            //    case "3":
            //        f3();
            //    break;
            //}
            f1();
            Console.WriteLine();
            f2();
            Console.WriteLine();
            f3();


            Console.ReadKey();
        }

        static void f1()
        {
            // 01. 目前有12個月份的溫度，請於畫面上顯示月份對應的溫度以及平均溫度
            //     (輸出請參考圖片 10_平均溫度.png)

            string[] x = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            double[] y = { 26, 28, 29, 31, 35, 34, 36, 37, 36, 32, 28, 18 };
            double sum = 0;

            Console.WriteLine("==【平均溫度】==");

            foreach (string temp in x)
            {
                Console.Write($"\t{temp}月");
            }
            Console.WriteLine();

            foreach (string temp in x) 
            {
                Console.Write("---------");
            }
            Console.WriteLine();
            Console.WriteLine();

            foreach (double temp in y)
            {
                Console.Write($"\t{temp}度");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"平均溫度為：{Queryable.Average(y.AsQueryable()):f1}度");

            return;
        }

        static void f2()
        {
            // 02. 顯示並且計算各學生的成績 
            //     (輸出請參考圖片 20_學員成績.png)
            //     "Eric", "Peter", "Charles" 65,81,95  54,67,73  92,76,62

            Console.WriteLine("==【學員成績】==");
            string[,] x = { { "Eric", "Peter", "Charles" }, { "65", "54", "92" }, { "81", "67", "76" }, { "95", "73", "62" } };

            int i = x.GetLength(0); //4
            int j = x.GetLength(1); //3
            int[] sum = new int[3];

            for (int k = 0; k < i; k++) 
            {
                for (int n = 0; n < j; n++)
                {

                    Console.Write($"\t{x[k, n],7}");
                    if (k < 3)
                    {
                        sum[k] += Convert.ToInt32(x[n + 1, k]);
                    }
                    
                }
                Console.WriteLine();
            }    

            for (int k = 0; k < i; k++)
            {
                Console.Write("-----------");
            }
            Console.WriteLine();

            foreach (int temp in sum)
            {
                Console.Write($"\t{temp,7}");
            }

            Console.WriteLine();

            return;

        }

        static void f3()
        {
            // 03. 顯示並且計算各處所營業處的營業額總額 
            //     "台北", "台中", "高雄"
            //     "第一處", "第二處", "第三處", "第四處"

            string[] x = { "第一處", "第二處", "第三處", "第四處" };
            string[][] y = new string[3][];

            y[0] = new string[] { "台北", "1100", "2200", "3300" };
            y[1] = new string[] { "台中", "2200", "4400" };
            y[2] = new string[] { "高雄", "1000", "2000", "3000", "4000" };

            int a = y.GetLength(0);
            int[] sum = new int[3];

            Console.Write("\t");

            foreach (string item in x)
            {
                Console.Write(item+"\t");
            }

            Console.Write("\n");

            foreach (string item in x)
            {
                Console.Write("-----------");
            }
            Console.Write("\n");

            for (int i = 0; i < y.GetLength(0); i++)
            {
                Console.Write(string.Join("\t", y[i]));
                Console.WriteLine();
            }

            foreach (string item in x)
            {
                Console.Write("-----------");
            }
            Console.Write("\n");


            for (int i = 0; i < y.GetLength(0); i++)
            {
                for (int j = 0; j < y[i].Length - 1; j++) 
                {
                    sum[i] += Convert.ToInt32(y[i][j + 1]);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{y[i][0]} 總金額：{sum[i]:c0}");
            }

            return;
        }
    }
}
