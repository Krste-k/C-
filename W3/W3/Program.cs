Console.WriteLine("Enter a num");
static void Func()
{
    int InputNum = Convert.ToInt32(Console.ReadLine());

    if (InputNum > 0 && InputNum < 10)
    {
        string Res = "number is lower then 10 ";

        Console.WriteLine($"{Res} the lenght of the {Res.Length}");
    }
}
Func();

///////////////////////////////////////////////////////////////////////

//   Expected Output :
//   Hello: Alexandra Abramov

Console.WriteLine("Hello enter yuor Name");
string InputName = Console.ReadLine();
Console.WriteLine($"Hello: {InputName}");

///////////////////////////////////////////////////////////////////////
//2. Write a C# Sharp program to print the sum of two numbers.
static void Operation()
{
    Console.WriteLine("Enter a first number ");
    int InputNumberOne = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter an opperadd");
    char InputForOperand = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("Enter a second number");
    int InputForSecondNum = Convert.ToInt32(Console.ReadLine());

    if (InputForOperand == '+')
    {
        Console.WriteLine(InputForSecondNum + InputForSecondNum);
    }
    else if (InputForOperand == '-')
    {
        Console.WriteLine(InputForSecondNum - InputForSecondNum);
    }
    else if (InputForOperand == '*')
    {
        if (InputForSecondNum == 0)
        {
            Console.WriteLine($"{InputNumberOne} is not multiplication by 0");
        }
        Console.WriteLine(InputForSecondNum * InputForSecondNum);
    }
    else if (InputForOperand == '/')
    {
        if (InputForSecondNum == 0)
        {
            Console.WriteLine($"{InputNumberOne} is not divided by 0");
        }
        Console.WriteLine(InputForSecondNum / InputForSecondNum);

    }


    //}
    //Operation();
    //////////////////////////////////////////////////////////////
    //Write a C# Sharp program to swap two numbers.

    using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;
/// 1. Write a C# Sharp program to print Hello and your name in a separate line. Go to the editor
int num1 = 5;
int num2 = 6;
int empty;

empty = num1;
num1 = num2;
num2 = empty;
Console.WriteLine(num1);
Console.WriteLine(num2);

    /////////////////////////////////////////////////////////////////////////////////////
    ///Write a C# Sharp program that takes a number as input and print its multiplication table
    ///
    //Console.WriteLine("Enter number ");
    //int InputNum = Convert.ToInt32(Console.ReadLine());


    switch (InputNum)
    {
        case int:
            Console.WriteLine($"{InputNum} * 0 = " + InputNum * 0);
            Console.WriteLine($"{InputNum} * 1 = " + InputNum * 1);
            Console.WriteLine($"{InputNum} * 2 = " + InputNum * 2);
            Console.WriteLine($"{InputNum} * 3 = " + InputNum * 3);
            Console.WriteLine($"{InputNum} * 4 = " + InputNum * 4);
            Console.WriteLine($"{InputNum} * 5 = " + InputNum * 5);
            Console.WriteLine($"{InputNum} * 6 = " + InputNum * 6);
            Console.WriteLine($"{InputNum} * 7 = " + InputNum * 7);
            Console.WriteLine($"{InputNum} * 8 = " + InputNum * 8);
            Console.WriteLine($"{InputNum} * 9 = " + InputNum * 9);
            Console.WriteLine($"{InputNum} * 10 = " + InputNum * 10);
            break;
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////

    //Write a C# Sharp program that takes four numbers as input to calculate and print the average

    Console.WriteLine("Enter first number");
    int Firstinput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter The second number");
    int SecondInputNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter a third number");
    int ThirdInputNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter a fort number");
    int ForthInputNum = Convert.ToInt32(Console.ReadLine());

    int sum = (Firstinput + SecondInputNum + ThirdInputNum + ForthInputNum) / 4;

    Console.WriteLine($"The average of {Firstinput},{SecondInputNum},{ThirdInputNum},{ForthInputNum} is : {sum}");

    ///////////////////////////////////////////////////////////////
    ///Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. 


    Console.WriteLine("Num X");
    int InputForX = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Num Y");
    int InputForY = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Num Z");
    int InputForZ = Convert.ToInt32(Console.ReadLine());

    int Result = (InputForX + InputForY) * InputForZ;
    Console.WriteLine($" (x+y).z is {Result}");

    Console.WriteLine("-------------------");

    int Result2 = (InputForX * InputForY) + (InputForY * InputForZ);
    Console.WriteLine($" x.y + y.z is  {Result2}");





    ////////////////////////////////////////
    ///loopS
    ///

    int i;
int j;
Console.WriteLine("Vnesi 10");

int rows = Convert.ToInt32(Console.ReadLine());


for (i = rows/2; i <= rows; i += 2)
{
    for (j = 1; j < rows - i; j += 2)
    {
        Console.WriteLine(" ");
    }
    for (j = 1; j <= i; j ++)
    {
        Console.WriteLine("*");
    }
    for (j = 1; j < rows - i; j ++)
    {
        Console.WriteLine(" ");
    }
    for (j = 1; j <= i; j ++)
    {
        Console.WriteLine("*");
    }
  
}
