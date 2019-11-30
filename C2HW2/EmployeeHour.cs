using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////Для «повременщиков» формула для расчета такова: 
//«среднемесячная заработная плата = 20.8 * 8 * почасовая ставка»;

namespace C2HW2
{
    class EmployeeHour : EmployeeBase
    {
        public EmployeeHour(double salary) : base(salary)
        {

        }
        public override double Salary()
        {
            return salary * 20.8 * 8;
        }
    }
}
