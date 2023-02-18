using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class ComputeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public void calculateWage(string company, int empRatePerHrs, int noOfWorkingDays, int maxHrsPerMonth)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;

            Console.WriteLine("Calculating Employee Wage for the Company: " + company.ToUpper());

            while (totalWorkingDays < noOfWorkingDays && totalEmpHrs < maxHrsPerMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                totalEmpHrs += empHrs;
                empWage = totalEmpHrs * empRatePerHrs;
                totalEmpWage += empWage;

                Console.WriteLine("Day #: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            Console.WriteLine("The Total Employee wage for " + company + " is: " + totalEmpWage );


        }
    }

}
