using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BasicEmployeeAppwithTests
{
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        //public int Salary  //validation for salary
        //{
        //    get
        //    {
        //        if (salary < 0)
        //        {
        //            return 0;
        //        }
        //        else
        //        {
        //            return Salary;
        //        }
        //    }
        //    set
        //    {
        //        salary = value;
        //    }
        //}
        
            
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
            Salary = salary; 
            Name = name;
        }

        //public SalaryLevel GetSalaryLevel() //method alt.to Salarylevel 
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
