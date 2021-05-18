using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 討論class
{


    class Student
    {
        public string StudentName; //學生姓名
        //private static int StudentID;   //學生學號
        private int FianlStudentID;
        private static int CurrentStudentID;

        public int Chinese;// 記錄國文成績
        public int English;// 紀錄英文成績
        private int myMath;// 紀錄數學成績
        public int HTML;

        public int Math
        {
            //myMath = 120
            //myMath = value
            get { return myMath; }
            set { myMath = value > 100 ? 100 : value; }
        }

        //方法B
        //public int HTML { get; private set;{ } }


        //建構子(建構函示) + get set
        //    規則：public + 不包含回傳類型 + 必須和class同名。
        public Student()
        {
            Console.WriteLine("----- 建構子 -----");
            //學號++ (坑) ;
            //StudentID++;
            // 1.   沒有加 static: 每個學生都是 1號
            // 2.   有加 static: 每個學生 共享學號
            CurrentStudentID++;
            FianlStudentID = CurrentStudentID;
        }

        public Student(string StudentName,int c,int e)
        {
            //這一個class
            Console.WriteLine("----- 建構子 -----");
            this.StudentName = StudentName;
            Chinese = c;
            English = e;
        }

        //第四個學生 建構子
        public Student(string s, int c, int e, int m)
        {
            StudentName = s;
            Chinese = c;
            English = e;

            //該選擇哪一個 myMayh? math?
            Math = m;
        }

        //第五個學生 建構子
        public Student(string s, int c, int e, int m,int h)
        {
            StudentName = s;
            Chinese = c;
            English = e;

            //該選擇哪一個 myMayh? math?
            Math = m;
            HTML = h >= 100 ? 100 : h;
        }

        public int GetStudentID()
        {
            //return StudentID;
            //return FianlStudentID;
            return CurrentStudentID;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine(StudentName);
            Console.WriteLine(Chinese);
            Console.WriteLine(English);
            Console.WriteLine(Math);
            Console.WriteLine(HTML);
        }
    }
}
