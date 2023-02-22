using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IComputeEmgWage
    {
        public void addCompanyEmpWage(string company, int empRate, int workingDays, int maxHours);
        public void computeEmpWage();    
    }
}
