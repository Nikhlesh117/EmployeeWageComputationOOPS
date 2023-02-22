using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class ComputeWage : IComputeEmgWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private ArrayList companyEmpWageList;

        public ComputeWage()
        {
            this.companyEmpWageList = new ArrayList();
        }

        public void addCompanyEmpWage(string company, int empRate, int workingDays, int maxHours)
        {
            this.companyEmpWageList.Add(new CompanyEmpWage(company, empRate, workingDays, maxHours));
        }

        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHours && totalWorkingDays < companyEmpWage.workingDays)
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
                Console.WriteLine("Days: " + totalWorkingDays + " Emp Hours: " + empHrs);
            }

            return totalEmpHrs * companyEmpWage.empRate;
        }
    }
}