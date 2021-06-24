using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEmployeeAppwithTests
{
    class Employee
    {
        public string Name { get; set; }
        private int salary;
        public int Salary  //validation for salary
        {
            get
            {
                if (salary < 0)
                {
                    return 0;
                }
                else
                {
                    return salary;
                }
            
            }
        }
        
            
        public SalaryLevel Salarylvl { get; set; }
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
            salary = Salary; 
            Name = name;
        }

        //public SalaryLevel GetSalaryLevel() //alternativ to Salarylevel with get is a method
        //{
            
        //    if (Salary < 1500)
        //    {
        //        Salarylvl = SalaryLevel.junior;
        //    }
        //    else {Salarylvl = SalaryLevel.senior;
        //    }
        //    return Salarylvl;
            
        //}
        
        public override string ToString()
        {
            return $"Name:{Name},Salary:{Salary}";
        }


    }

}
