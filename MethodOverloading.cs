using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisam
{

    class MathExap
    {
        public void Add(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }

        public void Add(int a,int b,int c)
        {
            int sum = a + b + c;
            Console.WriteLine(sum);
        }

    }
    class MethodOverloading
    {
        static void Main(string[] args)
        {
            MathExap m = new MathExap();
            m.Add(2, 3);
            m.Add(2, 3, 4);

        }
    }
}
