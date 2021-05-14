using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //List ArrayList ...陣列
            List<int> x = new List<int>();

            x.Add(1);
            x.Add(3);
            x.Add(5);
            x.Add(2);
            x.Add(4);
            x.Add(6);

            //x.Remove(value);
            //x.RemoveAt(index);
            //x.Insert(val,index);

            Console.WriteLine($"{x.IndexOf(1)}");

            foreach (int item in x)
            {
                Console.WriteLine(item);
            }

            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");
            myAL.Add(123);

            foreach (var item in myAL)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, string> y = new Dictionary<string, string>();
            y.Add("L", "Large");
            //y.Add("L", "XXL"); // console.write 時 error.Msg 已經加入含有相同的索引建
            y.Add("S", "Small");

            foreach (var item in y)
            {
                Console.WriteLine(item.Key);
            }

            foreach (KeyValuePair<string,string> item in y)
            {
                Console.WriteLine(item);  //L,Large ; S, Small
            }

            foreach (var item in y.Keys)
            {
                Console.WriteLine(item); // L,S
            }

            foreach (var item in y.Values)
            {
                Console.WriteLine(item); // Large, Small
            }

            Hashtable z = new Hashtable();
            z.Add("B", 99);
            z.Add("K", 49);


            foreach (DictionaryEntry item in z)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
