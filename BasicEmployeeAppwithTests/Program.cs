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

            Console.WriteLine("Add a new employee, Q=quit ");

            do
            {
                string name = Util.AskForString("Name: ");
           
            } while (true && name!="q");

            Employee[] employees = payroll.GetEmployees();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee); //ref to override of ToString method gör då samma som bortkommenterade raden nedanför;
               //Console.WriteLine($"Name:{employee.Name},Salary:{employee.Salary}");
            }

            //alt. oneliner syntax därför returnerades en array i GetEmployees()
            Array.ForEach(employees, e => Console.WriteLine(e));
            //alt. oneliner och employees arrayen rad 12 behövs ej.
            Array.ForEach(payroll.GetEmployees(), e => Console.WriteLine(e));
            

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
