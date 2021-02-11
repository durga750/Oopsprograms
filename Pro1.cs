using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisam
{
    class Maths
    {
        public void AreaOfSquare(int side)
        {
            int area = side * side;
            Console.WriteLine(area);
        }

        public void AreaOfRect(int length,int bredth)
        {
            int area = length * bredth;
            Console.WriteLine(area);
        }

        public void AreaOfcircle(int radius)
        {
            float pi=3.141f;
            float area = pi * radius * radius;
            Console.WriteLine(area);
        }
    }
    class Pro1
    {
        static void Main(string[] args)
        {
            Maths m = new Maths();
            m.AreaOfSquare(5);
            m.AreaOfRect(3,4);
            m.AreaOfcircle(2);

        }
    }
}
