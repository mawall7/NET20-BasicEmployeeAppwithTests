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
                if (!string.IsNullOrEmpty(answer))
                {
                    success = true;
                }
               

            } while (!success);

            return answer;  //deklareras answer i do while loopen ligger det utanför scoopet
        }

        internal static int AskForInt(string v)
        {
            bool success = false;
            int answer;
            do
            {
                string Input = AskForString(v);
                success = int.TryParse(Input, out answer);
                if(!success)
                {
                    Console.WriteLine("Wrong format"); //Obs är låst till consolen använd interface ist.
                } //check om strängen är en siffra, bara Parse behöver error validering
            
            } while (!success);
            return answer;
        }
    }
}