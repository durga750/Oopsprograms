


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProGrams
{

    class Employee
    {
        int empId;                   //instance variables
        string empName;
        int empSalary;
        public void SetInfo(int id,string name,int sal)    //local variables
        {
            empId = id;                //local var assigning to instance var
            empName = name;
            empSalary = sal;

        }

        public void ShowInfo()
        {
            Console.WriteLine(empId);
            Console.WriteLine(empName);
            Console.WriteLine(empSalary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();      //creating obj bcz of Employee is a Instance class
            e.SetInfo(123, "dfghj", 50000);
            e.ShowInfo();
        }
    }
}
