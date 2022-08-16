// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,Djani");

//Console.WriteLine("PLEASE Enter your first name: ");
//string firstName = Console.ReadLine();
//firstName = firstName.ToLower();

//Console.WriteLine("Please, Enter your last name: ");
//String lastName = Console.ReadLine();
//lastName = lastName.ToUpper();

//Console.WriteLine($"Nice to meet you {firstName} {lastName}!");

//Console.WriteLine("Enter a value: ");
//int max = int.Parse(Console.ReadLine());
//int i = 0;


//    while (i < max) 
//    { 
//        Console.WriteLine(i);
//    i++; 
//}

//Console.WriteLine("Loop finished!");

//static void printEvenNumbers()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        if (i % 2 == 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

//static void printOddNumbers()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        if (i % 2 != 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

Console.WriteLine("Coose an even or odd number:");
string UserImput = Console.ReadLine();


//if (UserImput == "even")
//{
//    printEvenNumbers();
//}
//else if (UserImput == "odd")
//{
//    printOddNumbers();
//}
//else
//{
//    Console.WriteLine("invalid selection");
//}



//static void printEvenNumbers()
//{
//    int Sum = 0;
//    for (int i = 0; i < 100; i++)
//    {
//        if (i % 2 == 0)
//        {
//            Sum = Sum + i;
//         }
//    }
//    Console.WriteLine(Sum/2);
//}

//static void printOddNumbers()
//{
//    for (int i = 0; i < 100; i++)
//    {
//        if (i % 2 != 0)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}



static void PrintEvenNumbers()
{
    int Sum = 0;
    int TotalNumber=0;

    for (int i = 0; i < 100; i++) 
    {
        if (i % 2 == 0) 
        {
            Console.WriteLine(Sum/2);
            Sum = Sum + i;
            TotalNumber++; 
        }
    }
    Console.WriteLine(Sum/TotalNumber); 
}

static void PrintOddNumbers()
{
    int Sum = 0;
    int TotalNumber = 0;

    for (int i = 0; i < 100; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
            Sum = Sum + i;
            TotalNumber++; 
        }

    }
    Console.WriteLine(Sum/TotalNumber);        

}
//static void SumOddNumbers()
//{
//    PrintOddNumbers();
//};

//SumOddNumbers();

if (UserImput == "even")
{
    PrintEvenNumbers(); 
}
else if (UserImput == "odd")
{
    PrintOddNumbers();
}
else
{
    Console.WriteLine("invalid selection");
}