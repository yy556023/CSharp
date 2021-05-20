using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 討論class
{

    //int i = 99;  //命名空間不能直接包含如欄位或方法等成員

    class Program
    {
        static int i = 99; //需要有物件參考，才可使用非靜態欄位、方法或屬性 'Program.i'

        class TestA
        {
            public string AName = "Apple";
            public void PrintMsg()
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            Teacher t1 = new Teacher("Flower", 901);
            t1.PrintTeacherInfo();

          //第一個學生
            //Student s1 = new Student();
            //s1.StudentName = "Fuck";
            //s1.Chinese = 80;
            //s1.GetStudentID();
            //Console.WriteLine(s1.StudentName);
            //Console.WriteLine(s1.GetStudentID()); //0

            //Student s2 = new Student();
            //s2.StudentName = "You";
            //Console.WriteLine(s2.StudentName);
            //Console.WriteLine(s2.GetStudentID());//0
            //Console.WriteLine(s1.GetStudentID());

            //第三個學生 透過建構子設定學生姓名和成績
            //Student s3 = new Student("Fuck You", 99, 99);
            //Console.WriteLine(s3.StudentName);
            //Console.WriteLine(s3.Chinese);
            //Console.WriteLine(s3.English);

            //第四個學生
            //Student s4 = new Student("Dog", 91, 81, 120);
            //Console.WriteLine(s4.StudentName);
            //Console.WriteLine(s4.Chinese);
            //Console.WriteLine(s4.English);
            //Console.WriteLine(s4.Math);
            
            //第五個學生
            //Student s5 = new Student("B", 54, 46, 87, 120);
            //s5.PrintStudentInfo();
        }
    }

    class TestB
    {
        public string BName = "Bee";
        public void PrintMsg()
        {
            //Console.WriteLine(); //錯誤 CS0103  名稱 'i' 不存在於目前的內容中 
        }

        public enum Test3
        {
            apple
        }
    }
}   

