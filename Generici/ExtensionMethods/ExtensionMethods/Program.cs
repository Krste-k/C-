using ExtensionMethods.Helpers;

List<string> Words = new List<string>()
{
    "Hello",
    "Bye",
    "Bmw",
    "Bojan",
    "Kebapi"
};
Words.Print();

List<int> Numbers = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
};

Numbers.Print();
Console.WriteLine("\n");
Words.GetInfo();
Console.WriteLine("\n");
Numbers.GetInfo();

Console.WriteLine("-------------------------------");
Console.WriteLine("Hello ".CapitalizeFirstLetter("Marko"));
Console.WriteLine("-------------------------------");

string text1 = "Thuday is Sutarday and the ewathwe is nice ";
text1.ColorText(ConsoleColor.Gray);
text1.ColorText(ConsoleColor.Blue);

text1.ColorText(ConsoleColor.Red);

ListHelpers.ColorText(text1, ConsoleColor.Cyan);
