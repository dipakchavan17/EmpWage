﻿using System;
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
            EmpWage e=new EmpWage();
            e.MonthlyEmpWage();
            Console.ReadLine();
        }
    }
}
