using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisam
{
    class Product
    {
        int price;
        string pName;
        int pId;

        public  Product(int price,string pName,int pId)
        {
            this.price = price;
            this.pName = pName;
            this.pId = pId;
        }

        public void show()
        {
            Console.WriteLine($"{price}\t{pName}\t{pId}");
        }
    }
    class Constructors
    {
        static void Main(string[] args)
        {
            Product p = new Product(200, "soap", 12);
            p.show();
        }
    }
}
