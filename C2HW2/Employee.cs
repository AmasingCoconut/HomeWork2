using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы.
 

namespace C2HW2
{
    abstract class EmployeeBase
    {
        protected double salary;
        public EmployeeBase(double salary)
        {
            this.salary = salary;
        }

        public abstract double Salary();
    }
}
