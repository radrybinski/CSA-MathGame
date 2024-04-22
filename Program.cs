// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! \n This is a MathGame from C#-Academy. \n Choose what you want to do (1-4) from list below:");
Console.WriteLine(" 1. Add numbers \n 2. Substract numbers \n 3. Multiply numbers \n 4. Divide numbers");

bool correctNumber = false;

do
{
    ConsoleKeyInfo userInput = Console.ReadKey();
    if (userInput.KeyChar == 1)
    {
        correctNumber = true;
        Console.WriteLine("You choosed number 1. Type 2 number you want to add. First number:");
        var number1 = Console.ReadKey();
        Console.WriteLine("Now type second number:");
        var number2 = Console.ReadKey();
        double output = Convert.ToDouble(number1) + Convert.ToDouble(number2);
        Console.WriteLine("Sum of these 2 numbers is: " + output);
    }
    if (userInput.KeyChar == 2)
    {
        correctNumber = true;

        Console.WriteLine("You choosed number 2");

    }
    if (userInput.KeyChar == 3)
    {
        correctNumber = true;
        Console.WriteLine("You choosed number 3");

    }
    if (userInput.KeyChar == 4)
    {
        correctNumber = true;
        Console.WriteLine("You choosed number 4");
    }
    else
    {
        correctNumber = false;
        Console.WriteLine("Please enter correct number!");
        //userInput = Console.ReadKey();

    }

}
while (correctNumber != true);






