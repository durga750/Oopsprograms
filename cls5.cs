using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProGrams
{
    class Company
    {
        int numOfEmps;
        string comName;
        string addOfCom;

        public void SetComInfo(int nofemp,string comname,string addofcom)
        {
            numOfEmps = nofemp;
            comName = comname;
            addOfCom = addofcom;
        }

        public void GetComInfo()
        {
            Console.WriteLine(numOfEmps);
            Console.WriteLine(comName);
            Console.WriteLine(addOfCom);
        }
    }
    class Progrsm2
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            c.SetComInfo(2000, "Ojas", "dfghjk");
            c.GetComInfo();

        }
    }
}
