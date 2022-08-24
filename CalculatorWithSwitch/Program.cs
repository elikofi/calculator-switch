//using do while loop
do
{
    //creating the variables
    double num1, num2, result = 0;

    //header
    Console.WriteLine("__________________");
    Console.WriteLine("Console Calculator");
    Console.WriteLine("__________________");

    //taking user input for calculation
    Console.Write("Enter a number: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter another number: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    //operator options
    Console.WriteLine("__________________");
    Console.WriteLine("Choose an operator;");
    Console.WriteLine("\t+ : Addition");
    Console.WriteLine("\t- : Subtraction");
    Console.WriteLine("\t* : Multiplication");
    Console.WriteLine("\t/ : Division");
    Console.WriteLine("\t^ : Exponent");
    Console.Write("Enter an operator: ");

    //switch statement
    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"The result: {num1} + {num2} = {result}");
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"The result: {num1} - {num2} = {result}");
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"The result: {num1} * {num2} = {result}");
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"The result: {num1} / {num2} = {result}");
            break;
        case "^":
            result = Math.Pow(num1, num2);
            Console.WriteLine($"The result: {num1} ^ {num2} = {result}");
            break;
        default:
            Console.WriteLine("You chose an invalid operator.");
            break;
    }
    Console.WriteLine("Will you do another calculation? (Y = Yes, N = No)");

} while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("Thanks for using me! BYE!!!");