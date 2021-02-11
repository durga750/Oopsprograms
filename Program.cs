using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingThisKeyward
{
    class Student
    {
        int rollNum;
        string sName;
        int sMarks;

        public void SetDetails(int rollNum,string sName,int sMarks)
        {
            this.rollNum=rollNum;                 
            this.sName=sName;
            this.sMarks=sMarks;

        }

        public void GetDetails()
        {
            Console.WriteLine(rollNum);
            Console.WriteLine(sName);
            Console.WriteLine(sMarks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetDetails(1234, "dfgh", 100);
            s.GetDetails();
        }
    }
}
