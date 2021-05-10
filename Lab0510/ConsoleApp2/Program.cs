using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "    microsoft visual studio          ";
            Console.WriteLine(str.Length);
            Console.WriteLine(str.Trim().Length);
            Console.ReadKey();
        }
    }
}
