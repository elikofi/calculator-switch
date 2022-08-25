//using do while loop
try
{
    do
    {
        //creating the variables
        double num, num1, num2, result = 0;


        //header
        Console.WriteLine("__________________");
        Console.WriteLine("Console Calculator");
        Console.WriteLine("__________________");

        //operator options
        Console.WriteLine("__________________");
        Console.WriteLine("Choose an operator;");
        Console.WriteLine("\t+ : Addition");
        Console.WriteLine("\t- : Subtraction");
        Console.WriteLine("\t* : Multiplication");
        Console.WriteLine("\t/ : Division");
        Console.WriteLine("\t^ : Exponent");
        Console.WriteLine("\t| : Root");
        Console.Write("Enter an operator: ");
        string operation = Console.ReadLine();

        if (operation == "|")
        {
            Console.Write("Enter the number to find the square root: ");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(num));
        }
        else
        {
            //taking user input for calculation
            Console.Write("Enter a number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            //switch statement
            switch (operation)
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
                    break;
            }
        }
        Console.WriteLine("Will you do another calculation? (Y = Yes, Any other key = No)");

    } while (Console.ReadLine().ToUpper() == "Y");

    Console.WriteLine("Thanks for using me! BYE!!!");
}
catch (Exception ex)
{
    Console.WriteLine("You entered an invalid input.");
}