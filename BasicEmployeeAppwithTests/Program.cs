using System;

namespace BasicEmployeeAppwithTests
{
    class Program
    {
        static Payroll payroll = new Payroll(); //ligger ej i main och ger då tillgång till payroll i hela klassen.
        static void Main(string[] args)
        {
            //Payroll payroll = new Payroll();
            SeedData();
            Employee[] employees = payroll.GetEmployees();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee); //ref to override of ToString method gör då samma som bortkommenterade raden nedanför;
               //Console.WriteLine($"Name:{employee.Name},Salary:{employee.Salary}");
            }
            

        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 15000);
            payroll.AddEmployee("Nissse", 12000);
            payroll.AddEmployee("Lisa", 15000);
            payroll.AddEmployee("Per", 10000);
            payroll.AddEmployee("Malin", 13000);
        }
    }
}
