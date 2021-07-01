using System;

namespace BasicEmployeeAppwithTests
{
    internal class StartUp
    {
        private IUI result;
        internal IUI GetUI(int choice)
        {
            switch (choice)
            {
                case 1:
                    {
                        result = new ConsoleUI();
                        break;
                    }
                //Other choices can be added later, reading input from file etc;
            }
            return result;
        }
    }
}