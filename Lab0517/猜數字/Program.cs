using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 猜數字
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. 不重複的四位數字: 0123456789
            string question = string.Empty;
            Random r = new Random();

            // 存放 0-9
            //List<int> ls = new List<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    ls.Add(i);
            //}
            //// 讀出 ls ==> 確認資料有存放到 List
            //foreach (var item in ls)
            //{
            //    Console.Write($"{item}  "); // 0  1  2 ... 9
            //}

            //for (int i = 0; i < 4; i++) // 0  1  2  3 ==> 隨機產生"門牌"號碼
            //{
            //    int temp = r.Next(0, ls.Count); // 10  9  8  7
            //    question = question + ls[temp];
            //    ls.RemoveAt(temp);   // 0 2 3 4 5 6 7 8 9
            //}
            //Console.WriteLine(question);

            // 方法B
            string demo = "0123456789";
            for (int i = 0; i < 4; i++)
            {
                int temp = r.Next(0, demo.Length);
                question = question + demo.Substring(temp, 1);
                demo = demo.Replace(demo.Substring(temp, 1), "");
            }
            Console.WriteLine($"解答 :{question}");
            Console.WriteLine("---------------------------");


            // 20. 判斷
            //     a. 成功
            //     b. 輸入 1233 檢查使用者輸入是否有符合規則
            //     c. 幾A幾B
            string flag = "N";

            while (flag == "N")
            {
                Console.Write("\n請輸入四個不重複的數字:");
                string ans = Console.ReadLine();  // 1231 
                //Console.WriteLine($"檢查: {ans}");

                // 檢查使用者輸入是否有符合規則
                char[] apple = ans.ToCharArray(); // ['1','2','3','1']
                //foreach (var item in apple)
                //{
                //    Console.Write($"{item}  "); // 1   2   3   1
                //}
                List<char> ls2 = new List<char>();
                //ls2.Add(apple[0]); // 1
                //ls2.Add(apple[1]); // 2
                //ls2.Add(apple[2]); // 3
                //ls2.Add(apple[3]); // 1
                for (int i = 0; i < apple.Length; i++)
                {
                    // 判斷 List 裡面是否有包含即將要加入的值 => 如果沒有才要加入
                    if (!ls2.Contains(apple[i]))
                    {
                        ls2.Add(apple[i]); // 1 2 3
                    }
                }
                bool ck = ls2.Count == 4; // false

                // 判斷開始
                if (question == ans)
                {
                    Console.WriteLine("==> 恭喜答對了!");
                    flag = "Y";
                }
                else if (ck == false || ans.Length != 4)
                {
                    // 檢查使用者輸入是否有符合規則
                    Console.WriteLine($"==> 數值不可重複 | 字串長度必須為4: {ans}");
                }
                else
                {
                    // 幾A幾B的判斷
                    int a = 0, b = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (question.IndexOf(apple[i]) == i)
                        {
                            a++;
                        }
                        else if (question.IndexOf(apple[i]) > -1)
                        {
                            b++;
                        }
                    }

                    Console.WriteLine($"==> {a}A{b}B ");

                }
            }

        }
    }
}
