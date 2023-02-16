using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeCheck
    {
        public int IS_FULLTIME = 1;
        public int EMP_RATE_PER_HOUR = 20;
        public void CheckEmployee()
        {
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == IS_FULLTIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;

            Console.WriteLine("Employee wage is: " + empWage);
        }
    }
}
