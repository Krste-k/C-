using System.Security.Cryptography;

List<int> numbers = new List<int>()
{
    254,2658,12,54,32,54
};
List<string> names = new List<string>()
{
    "Bojan","elena","Slave","Kiril","Leo"
};
List<bool> bools = new List<bool>()
{
    true, false, false, false, false,  true , false , false , false , false ,
};
//void PrintNumbers (List<int> listOfNumbers)
//{
//    foreach (int number in listOfNumbers)
//    {
//        Console.WriteLine(number);
//    }
//}
//void PrintString(List<string> listOfString)
//{
//    foreach (string number in listOfString)
//    {
//        Console.WriteLine(number);
//    }
//}

void PrintEveryType<Nesto>(List<Nesto> someList)
{
    foreach (Nesto item in someList)
    {
        Console.WriteLine(item);
    }

}

PrintEveryType(numbers);
Console.WriteLine("\n");
PrintEveryType(names);
Console.WriteLine("\n");
PrintEveryType(bools);
