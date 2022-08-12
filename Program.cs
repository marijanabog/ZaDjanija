// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello,Djani");

//Console.WriteLine("PLEASE Enter your first name: ");
//string firstName = Console.ReadLine();
//firstName = firstName.ToLower();

//Console.WriteLine("Please, Enter your last name: ");
//String lastName = Console.ReadLine();
//lastName = lastName.ToUpper();

//Console.WriteLine($"Nice to meet you {firstName} {lastName}!");

Console.WriteLine("Enter a value: ");
int max = int.Parse(Console.ReadLine());
int i = 0;


    while (i < max) 
    { 
        Console.WriteLine(i);
    i++; 
}

Console.WriteLine("Loop finished!");
