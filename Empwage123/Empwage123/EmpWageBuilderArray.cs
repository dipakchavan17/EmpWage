using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage123
{
    public class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
        private int numOfCompany = 0;
        private EmpWage[] EmpWageArray;
        public EmpWageBuilderArray()
        {
            this.EmpWageArray = new EmpWage[5];
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            EmpWageArray[this.numOfCompany] = new EmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                EmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.EmpWageArray[i]));
                Console.WriteLine(this.EmpWageArray[i].toString());
            }
        }
        private int computeEmpWage(EmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Employee Hours : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}

    

