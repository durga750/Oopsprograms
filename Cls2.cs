using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProGrams
{

    class Student
    {
        int rollNum;                                //instance cls var and methods
        string stuName;
        int marks;

        public void SetStuInfo(int rNum,string sName,int mar)
        {
            rollNum = rNum;
            stuName = sName;
            marks = mar;
        }

        public void GetStuInfo()
        {
            Console.WriteLine(rollNum);
            Console.WriteLine(stuName);
            Console.WriteLine(marks);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Student s = new Student();      //creating obj
            s.SetStuInfo(1234, "durga", 95);
            s.GetStuInfo();

        }
    }
}
