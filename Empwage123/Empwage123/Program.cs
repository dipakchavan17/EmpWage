using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
           
            EmpWage dMart = new EmpWage("DMart", 20, 2, 10);
            EmpWage reliance = new EmpWage("Reliance", 10, 4, 10);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());

            Console.ReadLine();
        }
    }
}
