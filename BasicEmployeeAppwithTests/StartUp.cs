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
                //Other choices can be added later, UI reading input from webaplication api;
            }
            return result;
        }
    }
}