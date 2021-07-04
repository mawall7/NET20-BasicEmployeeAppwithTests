using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BasicEmployeeAppwithTests
{
    public class Employee
    {
        public string Name { get; set; }
        //public int Salary { get; set; }
        private int salary; //ett fält behövs om man skriver egen implementation av property
        public int Salary  //validation for salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0) 
                {

                    throw new ArgumentOutOfRangeException("integer Less Than zero Exception"); 
                }
                else
                {
                    salary = value;
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
