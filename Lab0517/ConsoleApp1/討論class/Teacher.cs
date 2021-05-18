using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 討論class
{
    class Teacher
    {
        public string TeacherName { get; set; }
        public int TeacherID { get; set; } //有:get set 屬性 沒有:欄位

        public Teacher(string s,int id)
        {
            TeacherName = s;
            TeacherID = id;
        }

        public void PrintTeacherInfo()
        {
            //Console.WriteLine(TeacherName);
            //Console.WriteLine(TeacherID);
            foreach (var item in this.GetType().GetProperties())
            {

                //System.String TeacherName
                //Int32         TeacherID
                Console.WriteLine($"{item.Name} - {item.GetValue(this)}");
            }

        }
        //欄位Field vs 屬性Property
        //把class 裡面的 屬性 逐一讀出


    }
}
