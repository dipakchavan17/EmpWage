using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage123
{
    internal class EmpWage
    {
        public static void EmpAttendance()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHr = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHr = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }
            empWage = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage" + empWage);
            Console.ReadLine();

        }


    }
    }



           

    

