using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы.
 

namespace C2HW2
{
    abstract class BaseEmployee
    {
        protected double salary;
        public BaseEmployee(double salary)
        {
            this.salary = salary;
        }

        public abstract double Salary();
    }
}
