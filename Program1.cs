using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingThisKeyward
{
    class Teacher
    {
        string name;
        string sub;
        
        public void SetDetails(string name,string sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public void Getdetails()
        {
            Console.WriteLine(name);
            Console.WriteLine(sub); 
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            t.SetDetails("mahi", "maths");
            t.Getdetails();
        }
    }
}
