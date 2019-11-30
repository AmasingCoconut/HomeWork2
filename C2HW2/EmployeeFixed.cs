using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2HW2
{
    class EmployeeFixed : Employee
    {
        public EmployeeFixed(double salary) :base(salary)
        {
        }

        public override double Salary()
        {
            return salary;
        }
    }
}
