using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Pay
    {
        private string t1;
        private string t2;
        private string t3;
        private string t4;

        public string s_setime
        {
            get { return t1; }
            set { t1 = int.Parse(value.Substring(0, 2)) < 8 ? "0800" : value; }
        }

        public string s1
        {
            get => t2;
            set => t2 = int.Parse(value.Substring(0, 2)) < 8 ? "0800" : value;
        }

        public string e_setime
        {
            get { return t2; }
            set { t2 = int.Parse(value.Substring(0, 2)) > 22 ? "2000" : value; }
        }

        public Pay(string x, string y)
        {
            s_setime = x;
            e_setime = y;
            t3 = x;
            t4 = y;
        }

        public void Print()
        {
            double.TryParse(t1.Substring(0, 2), out double s_h);
            double.TryParse(t1.Substring(2, 2), out double s_m);
            double.TryParse(t2.Substring(0, 2), out double e_h);
            double.TryParse(t2.Substring(2, 2), out double e_m);

            //經過時間
            double time;

            //計費
            double sum = 0;

            //把經過時間算出來
            time = (e_h - s_h) * 60 + (e_m - s_m); //單位分

            if (time > 90)
            {
                sum = 60 + (Math.Ceiling(time / 30) - 3) * 30;
            }
            else if (time > 30)
            {
                sum = (Math.Ceiling(time / 30) - 1) * 20;
            }
            else
            {
                Console.WriteLine("半小時內離場，免費");
            }
            Console.WriteLine($"\n{t3} 停放到 {t4} ===> 收費 {sum:c0}");           
        }
    }
}
