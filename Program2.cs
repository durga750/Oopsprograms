using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingThisKeyward
{

    class Doctor
    {
        string dName;
        string speciality;
        int fee;

        public void SetInfo(string dName,string speciality,int fee)
        {
            this.dName = dName;
            this.speciality = speciality;
            this.fee = fee;
        }

        public void GetInfo()
        {
            Console.WriteLine(dName);
            Console.WriteLine(speciality);
            Console.WriteLine(fee);
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Doctor d = new Doctor();
            d.SetInfo("mani", "cardi", 1000);
            d.GetInfo();

        }
    }
}
