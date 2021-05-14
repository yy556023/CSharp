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

            //輸入紀錄
            List<string> at = new List<string>();

            //迴圈用
            int i, j;

            //檢測字串重複用
            bool m = false;

            //計次用
            int t = 0;

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

                //檢查字串內是否有重複
                for (i = 0; i < 9; i++)
                {
                    if (a.IndexOf(i.ToString()) != a.LastIndexOf(i.ToString()))
                    {
                        m = true;
                        break;
                    }
                }

                //依權重來判斷錯誤 先判斷輸入的是不是數字
                if (!int.TryParse(a, out int abc))
                {
                    Console.WriteLine("輸入非數字！\n");
                }
                //如果是數字 長度有沒有符合
                else if (a.Length != 4)
                {
                    Console.WriteLine("數字長度不符！\n");
                }
                //如果是數字 長度也符合 則檢查字串內是否有重複
                else if (m)
                {
                    //把檢查字串內數字重複的判定重設
                    m = false;

                    Console.WriteLine("字串內數字重複！\n");
                }
                //以上條件都符合 則檢查輸入紀錄是否輸入過了
                else if (at.Contains(a))
                {
                    Console.WriteLine("輸入過囉！\n");
                }
                //所有條件都正確則開始執行比對動作
                else
                {
                    //添加字串到輸入紀錄
                    at.Add(a);

                    //字串分割後放進put陣列(型態int)
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
            }
            Console.WriteLine("答對了");
            Console.ReadKey();
        }
    }
}
