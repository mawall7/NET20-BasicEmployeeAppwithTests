Test (och statiska klasser eller fält)

automatiserad testning för konsolapplikationer - starta nytt projekt ms Test projekt(.NET Core)
N-Unit eller X-Unit spelar ingen roll här. har bara lite olika attribut.

-interface krävs för att testa vissa metoder etc.  
-använda moq library som hjälper till att skapa fakeobjekt

-finns två olika tester: unit och integrations tester. det första vi gjorde var unittester.

 den andra typen testar hur de olika delarna i applikationer fungerar ihop hela systemet
 som man också ska göra. 
 
(det jag är van med sen tidigare att skriva in värden i consolen etc. kallas manuellt test)

skapa nytt projekt högerklicka på solution på projektet som ska testas- add new project test Projekt c# 
skapa en referens i testprojektet till det du vill testa . högerklicka på Dependencies och add referens.

obs för internal klasser som ej är publika kommer de ju inte att synas
gör t.ex. då ett attribut i klassen du vill ju inte ändra access nivå.
[assembly:InternalsVisibleTo("EmployeeAppTests")] ovanför namespace 

t.ex. hur testa console.readLine()? kör man det kommer den ju vänta
på input. begränsningar med statiska klasser och testa på problem
för en sådan klass.

det som behöver testas är det med logik men, även andra saker kan testas. man skapar allt från början så 
man vet vad som händer och jämför värdet, med ett förväntat resultat som en metod ska
returnera etc. med Assert t.ex. Assert.Equal(4, timestwo(2)); eller Assert.IsTrue(String.IsNullOrEmpty(""))

I employee get metoden, payroll listan med Employees skulle kunna testas, override to string, Ask for string. 

kör testet i testexplorer. klasserna skap vara public ha attributet TestClass, metoderna ha attributet TestMethod


för readLine() metoder. extrahera ett IUI från ett ConsoleUI som har en Getinput metod och en Print metod som returnerar Console.WriteLine(message) och ReadLine

-ladda ner moq nuget. till testprojektet (moq är ett ramverk)

annat exempel att vår applikation använder en annan del ett api som inte är färdig skrivet. vi använder då en stubb
som returnerar någon fakedata för att simulera det du förväntar dig få tillbaka. då underlättar det att jobba med
abstraktioner och interface. 


(att använda ui interfacet i uppgiften kan man göra på olika sätt

 - i en statisk klass Util som måste ha statiska metoder. dock får konst-
   ruktorn i en statisk klass ha parametrar. och man måste då t.ex.
   ta in det via en annan statisk metod i klassen som tar new ConsoleUI() som parameter
   och sparar det som et privat statiskt fält av typen IUI)

 - kan göra en vanlig klass (men inte heller så snyggt)Util men med ett statiskt fält IUI ui vi vill ju
   kunna skriva bara Util.ui för att få ui:t. Sedan skriva en konstruktor
   public Util(IUI ui) och i bodyn skriva Util.ui = ui (behöver skriva så 
   för att komma åt det statiska fältet)
   nackdelen är att vi måste instantiera Util klassen nu och där vi använder den i test.

- bästa sättet var att behålla den statiska klassen men, ta bort fältet utan direkt 
   skicka in ett ui i metoderna . t.ex. i AskForString(string prompt, IUI ui)