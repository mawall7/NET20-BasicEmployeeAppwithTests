using System;

namespace BasicEmployeeAppwithTests
{
    internal static class Util
    {
        // statisk klass kan inte deklarera några instansvariabler och man kan därför ej använda this
        //private static IUI ui; kan tas bort och direkt tas genom parameter i metoderna

        //static Util()
        //{
        //    SetUp(new ConsoleUI()); //ska ändas eftersom det finns ett beroende här till console Uit om vi vill ha en applikation som är oberoende av vilket UI vi vill använda
        //}

        //public static void SetUp(IUI userInterface)
        //{
        //    ui = userInterface;

        //}

        internal static string AskForString(string v, IUI ui) 
        {
            bool success = false;
            string answer;
            do
            {
                //Console.WriteLine(v);
                //answer = Console.ReadLine(); //vi använder istället ett interface iui för att göra metoden testbar vi fejkar då console.readline hoppar över den  
                ui.Print(v);
                answer = ui.GetInput(); //vilken klass som helst som implementerar(ärver) interfacet är av iui typen, vi kan t.ex. skicka in ett ConsoleUI med egen implementation av metoderna, t.ex. görs det här i Program via en Startup Klass (gör att även Program blir löst kopplad och vi kan välja vilket ui vi ska välja via en annan klass). Eftersom GetInput returnerar Console.ReadLine om vi skickar in ConsloeUI så mockar:ar vi metoden och säger vad den ska reurnera vid test av metoden(i BasicEMployeeAppTests/UtilClassTests.cs)
                if (!string.IsNullOrEmpty(answer))
                {
                    success = true;
                }
               

            } while (!success);

            return answer;  //deklareras answer i do while loopen ligger det utanför scoopet
        }

        internal static int AskForInt(string v, IUI ui)//klassen gjord testbar genom att ersätta console.writeline med ui klassen
        {
            bool success = false;
            int answer;
            do
            {
                string Input = AskForString(v, ui);  
                success = int.TryParse(Input, out answer);
                if(!success)
                {
                    ui.Print("Wrong format"); 
                    /*Console.WriteLine("Wrong format");*/ //Obs är låst till consolen använd interface ist.
                } //check om strängen är en siffra, bara Parse behöver error validering
            
            } while (!success);
            return answer;
        }
    }
}