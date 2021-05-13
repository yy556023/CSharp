using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Random a = new Random();

            int ans = a.Next(1, 101);
            int max = 100;
            int min = 1;
            int t = 0;

            Console.Write("請輸入介於1～100的數字：");

            do
            {
                i = Convert.ToInt32(Console.ReadLine());
                if (i > ans)
                {
                    max = i;
                }
                else if (i < ans)
                {
                    min = i;
                }
                else
                {
                    t++;
                    break;
                }
                Console.WriteLine($"輸入錯誤！介於{min}～{max}之間");
                Console.Write("請重新輸入：");
                t++;
            } while (i != ans);

            Console.WriteLine($"bingo，猜了{t}次");
            Console.ReadKey();
                
        }
    }
}
