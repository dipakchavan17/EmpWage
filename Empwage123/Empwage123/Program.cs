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
            EmpWage.computeEmpWage("Reliance", 20, 4, 20);
            EmpWage.computeEmpWage("dmart", 20, 2, 10);

            Console.ReadLine();
        }
    }
}
