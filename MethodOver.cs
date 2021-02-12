using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisam
{
    class Examp
    {
        public virtual void show()
        {
            Console.WriteLine("Show Exam class info");
        }
        public virtual void display()
        {
            Console.WriteLine("display Exam class info");
        }     
    }

    class Pro:Examp
    {
      public override  void display()
        {
            Console.WriteLine("display pro class info");
        }
        public override void show()
        {
            Console.WriteLine("Show Pro class info");
        }

    }
    class MethodOver
    {
        static void Main(string[] args)
        {
          Examp e = new Examp();
            e.show();
            e.display();
            e = new Pro();
            e.show();
            e.display();
            
        }
    }
}
