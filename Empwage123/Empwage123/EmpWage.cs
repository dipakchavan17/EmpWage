using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage123
{
    internal class EmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void EmpAttendance()
        {
          
       

            int empHr = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHr = 4;
                    break;
                case IS_FULL_TIME:
                    empHr = 8;
                    break;
                default:
                    empHr = 0;
                    break;
            }
            empWage = empHr * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage" + empWage);
            Console.ReadLine();
        }

    }


}
    



           

    

