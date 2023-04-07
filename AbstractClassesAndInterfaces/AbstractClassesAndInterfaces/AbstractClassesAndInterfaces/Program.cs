using AbstractClassesAndInterfaces;
using AbstractClassesAndInterfaces.Entities;

Developer Krste = new Developer("Krste Krstevski" , 30 ,07123678 , new List<string> { "HTML" , "CSS" , "JAVASCRIPT" ,"C#"} , 1 );
Krste.Greet("Marko");
Krste.Code();
string InfoKrste = Krste.GetInfo();
Console.WriteLine(InfoKrste);
Console.WriteLine("-------------------------------------------");

Tester marko = new Tester("Marko", 20, 2587462, 15);
string infoMarko = marko.GetInfo();
Console.WriteLine("-------------------------------------------");

DevOps jon = new DevOps("Jon Polen" ,40, 256789, false, true);
jon.Greet("Johan");
Console.WriteLine(jon.CheckInfrastructure(50));
Console.WriteLine(jon.GetInfo());
jon.Code();