using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_and_B
{
    class Program
    {
        static void Main()
        {
            f1();
        }

        static void f1()
        {
            //字串陣列
            int[] s = { -1, -1, -1, -1 };

            Random r = new Random();

            s[0] = r.Next(0, 10);

            int i = 1;
            int j = 0;

            while (s[3] == -1)
            {
                s[i] = r.Next(0, 10);
                if (s[i] == s[i - 1])
                {
                    s[i] = r.Next(0,10);
                }
                i++;
            }

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < i; j++)
                {
                    if(s[i] == s[j])
                    {
                        s[i] = r.Next(0, 10);
                        j = 0;
                        i = 0;
                    }
                }
            }

            int a = 0;
            int b = 0;

            //拆起來的字串陣列
            string[] z = new string[4];
            int[] ss = new int[4];
            //輸入一串數字
            string temp = Console.ReadLine();

            for (i = 0; i < 4; i++)
            {
                z[i] = temp.Substring(i, 1);
                ss[i] = int.Parse(z[i]);
            }

            

            foreach(var t in ss)
            {
                Console.WriteLine(t);
            }
            foreach (var t in s)
            {
                Console.WriteLine(t);
            }


            Console.ReadKey();


        }
    }
}
