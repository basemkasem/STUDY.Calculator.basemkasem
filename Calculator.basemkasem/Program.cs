// Declare variables and then initialize to zero.
double num1 = 0; double num2 = 0;

Console.WriteLine("Console calculator in C#\r");
Console.WriteLine("------------------------\n");

Console.WriteLine("Type a number, then press Enter.");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Type another number, then press Enter.");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(@"Choose an option from the following list:
    a. Add.
    s. subtract.
    m. multiply.
    d. division.
");

switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        break;
    case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        break;
    case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        break;
    case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        break;
}

Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();