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
            //亂數陣列
            int[] ans = new int[4];

            //使用者輸入的字串
            string a = "";

            //字串分割後 轉型成int放的陣列
            int[] put = new int[4];

            //亂數物件
            Random r = new Random();

            //
            List<string> at = new List<string>();

            //迴圈用
            int i, j;

            //顯示幾A幾B用
            int A = 0;
            int B = 0;

            //產生不重複的四位亂數
            for (i = 0; i < 4; i++)
            {
                ans[i] = r.Next(0, 10);
                for (j = 0; j < i; j++)
                {
                    while (ans[i] == ans[j])
                    {
                        j = 0;
                        ans[i] = r.Next(0, 10);
                    }
                }
            }

            //DEBUG用顯示答案
            foreach (var item in ans)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            //如果沒答對就不斷執行while迴圈
            while (A != 4)
            {
                //答案不對 A，B要歸零
                A = 0;
                B = 0;

                //使用者輸入字串
                a = Console.ReadLine();

                //如果字串長度不對不執行判定
                if (int.TryParse(a, out int abc))
                {
                    if (a.Length != 4)
                    {
                        Console.WriteLine("數字長度不符！");
                    }
                    //檢查輸入字串是否已經輸入過了
                    else if (at.Contains(a))
                    {
                        Console.WriteLine("輸入過囉！\n");
                    }
                    //對了就執行
                    else
                    {
                        //添加字串到輸入紀錄
                        at.Add(a);
                        //字串分割後放進put陣列(型態int)
                        try
                        {
                            for (i = 0; i < 4; i++)
                            {
                                put[i] = Convert.ToInt32(a.Substring(i, 1));
                            }

                            //put陣列的數字依序對比ans陣列  
                            for (i = 0; i < 4; i++)
                            {
                                for (j = 0; j < 4; j++)
                                {
                                    if (put[i] == ans[j])
                                    {

                                        //如果值相同index也相同則 + A
                                        if (i == j)
                                        {
                                            A += 1;
                                        }
                                        //如果值相同index不同則 + B
                                        else
                                        {
                                            B += 1;
                                        }
                                    }
                                }
                            }
                            //顯示幾A幾B
                            Console.WriteLine(A + "A " + B + "B\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message + "\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("輸入非數字！");
                }
            }

            Console.WriteLine("答對了");
            Console.ReadKey();
        }

        static void f1()
        {

        }
    }
}
