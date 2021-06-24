using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEmployeeAppwithTests
{
    class Employee
    {
        public string Name { get; set; }
        public int Salary;
        public SalaryLevel Salarylevel {
            get 
            {
                if (Salary < 15000)
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
            Salary = salary;
            Name = name;
        }


        public override string ToString()
        {
            return $"Name:{Name},Salary:{Salary}";
        }


    }

}
