using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEmployeeAppwithTests
{
    class Employee
    {
        public string Name { get; set; }
        private int salary;
        public SalaryLevel Salarylevel {
            get 
            {
                if (salary < 15000)
                {
                    return SalaryLevel.junior;
                }
                else
                {
                    return SalaryLevel.senior;
                }
            }
        }

        public Employee(string name, int salary)
        {
            salary = salary;
            Name = name;
        }
    }
}
