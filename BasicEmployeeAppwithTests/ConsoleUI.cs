using System;
using System.Collections.Generic;
using System.Text;

namespace BasicEmployeeAppwithTests
{
    public class ConsoleUI : IUI
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
