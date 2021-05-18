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
            //收費開始 08:00
            //收費停止 20:00

            //輸入進場離場時間
            string s_t = string.Empty;
            string e_t = string.Empty;

            //是否重新查詢 迴圈用
            string check = "y";

            while(check == "y" || check == "Y")
            {
                Console.WriteLine("=====停車收費試算=====");
                Console.WriteLine("請輸入進場時間：");
                s_t = Console.ReadLine();
                Console.WriteLine("請輸入離場時間：");
                e_t = Console.ReadLine();
                
                //獲取入場時間及離場時間 時 分
                double.TryParse(s_t.Substring(2, 2), out double s_y); 
                double.TryParse(e_t.Substring(2, 2), out double e_y); 
                double.TryParse(e_t.Substring(0, 2), out double e_x); 
                double.TryParse(s_t.Substring(0, 2), out double s_x);

                //經過時間
                double time;

                //計費
                double sum = 0;  
                
                //把經過時間算出來
                time = (e_x - s_x) * 60 + (e_y - s_y); //單位分

                if (time > 90)
                {
                    sum = 60 + (Math.Ceiling(time / 30) - 3) * 30;
                }
                else if (time > 30)
                {
                    sum = (Math.Ceiling(time / 30) - 1) * 20;
                    //0806 0906
                }
                else
                {
                    Console.WriteLine("半小時內離場，免費");
                }

                Console.WriteLine($"\n{s_t} 停放到 {e_t} ===> 收費 {sum:c0}");
                Console.WriteLine("是否要繼續查詢？ Y/N");
                check = Console.ReadLine();
            }
        }
    }
}
