using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//для работников  с фиксированной  оплатой: 
//«среднемесячная заработная плата = фиксированная месячная оплата»;



namespace C2HW2
{
    class SalaryEmployee : BaseEmployee
    {
        public SalaryEmployee(double salary) :base(salary)
        {
        }

        public override double Salary()
        {
            return salary;
        }
    }
}
