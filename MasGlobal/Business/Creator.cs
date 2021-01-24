using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal
{
    public class Creator
    {
        public static Employees CreatorSalary(string ContracType)
        {

            switch (ContracType)
            {
                case "HourlySalaryEmployee":
                    return new HourlySalary();
                case "MonthlySalaryEmployee":
                    return new MonthlySalary();
                default: return null;

            }

        }
    }
}
