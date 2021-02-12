using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisam
{
    class Mathamatics
    {
        int num1;
        int num2;

        public void SetValues(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void ShowValues()
        {
            Console.WriteLine($"num1={num1}\tnum2={num2}");
        }

        public static Mathamatics operator+(Mathamatics i, Mathamatics j)
        {

            Mathamatics a = new Mathamatics();
            a.num1 = i.num1 + j.num1;
            a.num2 = i.num2 + j.num2;
            return a;
        }
    }

    class OperatorOverLoading
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======m obj====");
            Mathamatics m = new Mathamatics();
            m.SetValues(100, 200);
            m.ShowValues();
            Console.WriteLine("======n obj====");
            Mathamatics n = new Mathamatics();
            n.SetValues(400, 100);
            n.ShowValues();
            Console.WriteLine("======o obj====");
            Mathamatics o = new Mathamatics();
            o = m + n;
            o.ShowValues();
            Console.WriteLine("======q obj====");
            Mathamatics p = new Mathamatics();
            p = o + n;
            p.ShowValues();


        }
    }
}

