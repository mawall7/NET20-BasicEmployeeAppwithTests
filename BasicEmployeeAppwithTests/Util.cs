using System;

namespace BasicEmployeeAppwithTests
{
    internal static class Util
    {
        // statisk klass kan inte deklarera några instansvariabler.
        internal static string AskForString(string v)
        {
            bool success = false;
            string answer;
            do
            {
                Console.WriteLine(v);
                answer = Console.ReadLine();
                if (string.IsNullOrEmpty(answer))
                {
                    success = true;
                }
               

            } while (!success);

            return answer;  //deklareras answer i do while loopen ligger det utanför scoopet
        }
    }
}