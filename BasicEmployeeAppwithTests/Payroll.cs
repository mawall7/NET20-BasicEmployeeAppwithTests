using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEmployeeAppwithTests
{
    internal class Payroll
    {
        private List<Employee> payroll;

        public Payroll()
        {
            payroll = new List<Employee>();
        }


        internal void AddEmployee(string name, int salary) 
        {
            payroll.Add(new Employee(name, salary));
        }
    }
    
}
