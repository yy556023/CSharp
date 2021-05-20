using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "1231";
            //bool ck = ans.Distinct().Count() == 4;
            bool ck = Regex.IsMatch(ans, @"([0-9]).*\1"); //([0-9])只能輸入 這些數字
            Console.WriteLine(ck);
        }
    }
}
