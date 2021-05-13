using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retest
{
    class Program
    {
        static void Main(string[] args)
        {
            f3();

            Console.ReadKey();
        }

        static void f1()
        {
            // 01. 目前有12個月份的溫度，請於畫面上顯示月份對應的溫度以及平均溫度
            //     (輸出請參考圖片 10_平均溫度.png)
            //      26, 28, 29, 31, 35, 34, 36, 37, 36, 32, 28, 18 

            int[] x = { 26, 28, 29, 31, 35, 34, 36, 37, 36, 32, 28, 18 };

            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"  {i.ToString().PadLeft(2, '0')}月");
            }
            Console.WriteLine("\n------------------------------\n");

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"  {x[i]}度");
            }
            Console.WriteLine("\n------------------------------\n");

            Console.WriteLine($"平均溫度為：{Queryable.Average(x.AsQueryable()):f2}度\n");

            return;
        }

        static void f2()
        {
            // 02. 顯示並且計算各學生的成績 
            //     (輸出請參考圖片 20_學員成績.png)
            //     "Eric", "Peter", "Charles"

            string[] x = { "Eric", "Peter", "Charles" };
            int[,] y = { { 65, 81, 95 }, { 54, 67, 73 }, { 92, 76, 62 } };
            int[] sum = new int[3];

            foreach (string t in x)
            {
                Console.Write($"\t{t.PadLeft(5,' ')}");
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"\t{y[j, i],5}");
                    sum[i] += y[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");

            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write($"\t{sum[i],5}");
            }
        }

        static void f3()
        {
            string[] x = { "第一處", "第二處", "第三處", "第四處" };
            string[] y = { "台北", "台中", "高雄" };
            int[][] z = new int[3][];
            int[] sum = new int[3];

            z[0] = new int[] { 1100, 2200, 3300 };
            z[1] = new int[] { 2200, 4400 };
            z[2] = new int[] { 1000, 2000, 3000, 4000 };

            foreach (string t in x)
            {
                Console.Write("\t" + t);
            }

            Console.WriteLine("\n------------------------------------------");

            for (int i = 0; i < y.GetLength(0); i++)
            {
                Console.Write(y[i]);

                for (int j = 0; j < z[i].Length; j++) 
                {
                    sum[i] += z[i][j];
                    Console.Write($"\t{z[i][j]}");
                }
                Console.WriteLine(); 
            }
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine($"{y[i]} 總金額為：{sum[i]:c0}");
            }
        }
    }
}
