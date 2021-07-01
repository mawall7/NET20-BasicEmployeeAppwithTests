using System;

namespace BasicEmployeeAppwithTests
{
    class Program
    {
        static Payroll payroll = new Payroll(); //ligger ej i main och ger då tillgång till payroll i hela klassen.
        
        private static IUI ui = new ConsoleUI();
        static void Main(string[] args)
        {
            //Payroll payroll = new Payroll();

            SeedData();

            do
            {
                PrintMenu();

            } while (true);




            //alt. oneliner syntax därför returnerades en array i GetEmployees()
            //alt. oneliner och employees arrayen rad 12 behövs ej.
            //Array.ForEach(payroll.GetEmployees(), e => Console.WriteLine(e));
            //Array.ForEach(employees, e => Console.WriteLine(e));

        }

        private static void PrintMenu()
        {
            //Console.WriteLine("1.Add new Employee");
            //Console.WriteLine("2. Print");
            //Console.WriteLine("Q. Quit");
            ui.Print("1.Add new Employee");
            ui.Print("2. Print");
            ui.Print("Q. Quit");
            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    break;
                    
                case "2":
                    Print();
                    break;
                case "Q":
                    Environment.Exit(0);
                    break;
            }
        }

        private static void Print()
        {
            Employee[] employees = payroll.GetEmployees();
            

            foreach (Employee employee in employees)
            {
                /*Console.WriteLine(employee);*/ //ref to override of ToString method gör då samma som bortkommenterade raden nedanför;
                ui.Print(employee.ToString()); //apply ui interface
                if (employee.Salarylevel.Equals(SalaryLevel.junior))
                {
                    //Console.WriteLine(DoJuniorWork());
                    ui.Print(DoJuniorWork());
                }                                   
                if (employee.Salarylevel.Equals(SalaryLevel.senior))
                {
                    //Console.WriteLine(DoSeniorWork());
                    ui.Print(DoSeniorWork());
                }                                                                        //Console.WriteLine($"Name:{employee.Name},Salary:{employee.Salary}");
            }
        }

        private static string DoSeniorWork()
        {
            return "implement code";
        }

        private static string DoJuniorWork()
        {
            return "code tester";
        }

        private static void Add()
        {
            Console.WriteLine("Add a new employee, Q=quit ");
            do
            {
                string name = Util.AskForString("Name: ");
                if (name == "Q") break;
                int salary = Util.AskForInt("Salary: ");
                payroll.AddEmployee(name, salary);



            } while (true);
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
