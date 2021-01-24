using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal
{
    class MonthlySalary: Employees
    {
        public override double AnualSalary(double SalaryH, double SalaryM)
        {
            return SalaryM * 12;
        }
    }
}
