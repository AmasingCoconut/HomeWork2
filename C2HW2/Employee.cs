using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2HW2
{
    abstract class Employee
    {
        protected double salary;
        public Employee(double salary)
        {
            this.salary = salary;
        }

        public abstract double Salary();
    }
}
