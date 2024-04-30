// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using System.Xml;
using System.Xml.Linq;

Console.WriteLine("Hello! \n This is a MathGame from C#-Academy. \n Choose what you want to do (1-5) from list below:");

string menuList = " 1. Add numbers \n 2. Substract numbers \n 3. Multiply numbers \n 4. Divide numbers \n 5. History \n 6. Exit";
Console.WriteLine(menuList);



List<string> historyOfGames = new List<string>();



string option1 = "1";
string option2 = "2";
string option3 = "3";
string option4 = "4";
string option5 = "5";
string option6 = "6";


static bool CheckModulo(double numb1, double numb2)
{
    if (numb1 % numb2 == 0)
    {
        return true;

    }
    else
    {
        return false;
    }
}

for (int i = 0; i < 2; i++)
{
    var userInput = Console.ReadLine();
    if (!(userInput.Equals(option1) || userInput.Equals(option2) || userInput.Equals(option3) || userInput.Equals(option4) || userInput.Equals(option5) || userInput.Equals(option6)))
    {
        Console.WriteLine("Please enter number again!");
    }
    if (userInput == "1")
    {

        Console.WriteLine("You choosed number 1. \nType 2 number you want to add. \nFirst number:");
        var number1 = Console.ReadLine();
        Console.WriteLine("Now type second number:");
        var number2 = Console.ReadLine();
        double output = Convert.ToDouble(number1) + Convert.ToDouble(number2);
        Console.WriteLine("Sum of these 2 numbers is: " + output);

        historyOfGames.Add($"You choosed game number 1. First number was: {number1} , second number was: {number2}, output was: {output}");

    }
    if (userInput == "2")
    {

        Console.WriteLine("You choosed number 2. \nType 2 number you want to substract. \nFirst number:");
        var number1 = Console.ReadLine();
        Console.WriteLine("Now type second number:");
        var number2 = Console.ReadLine();
        double output = Convert.ToDouble(number1) - Convert.ToDouble(number2);
        Console.WriteLine("Substraction of these 2 numbers is: " + output);

        historyOfGames.Add($"You choosed game number 2. First number was: {number1} , second number was: {number2}, output was: {output}");
    }
    if (userInput == "3")
    {

        Console.WriteLine("You choosed number 3. \nType 2 number you want to multiply. \nFirst number:");
        var number1 = Console.ReadLine();
        Console.WriteLine("Now type second number:");
        var number2 = Console.ReadLine();
        double output = Convert.ToDouble(number1) * Convert.ToDouble(number2);
        Console.WriteLine("Multiplication of these 2 numbers is: " + output);

        historyOfGames.Add($"You choosed game number 3. First number was: {number1} , second number was: {number2}, output was: {output}");
    }
    if (userInput == "4")
    {


        string number1;

        string number2;



        do
        {
            Console.WriteLine("You choosed number 2. \nType 2 number you want to divide. Second number cannot be bigger than 100.  \nFirst number:");
            number1 = Console.ReadLine();


            do
            {

                Console.WriteLine("Second number:");
                number2 = Console.ReadLine();
                if(Convert.ToDouble(number2) > 100)
                {
                    Console.WriteLine("Only numbers <= 100 are allowed");

                }


            } while (Convert.ToDouble(number2) > 100);

            if(CheckModulo(Convert.ToDouble(number1), Convert.ToDouble(number2) ) == false)
                {
                Console.WriteLine("The result of the operation is not an integer. Enter other numbers.");


                }


        } while (!(CheckModulo(Convert.ToDouble(number1), Convert.ToDouble(number2))));



        double output = Convert.ToDouble(number1) / Convert.ToDouble(number2);
        Console.WriteLine("Quotient of these 2 numbers is: " + output);
        Console.WriteLine("");
        Console.WriteLine("");

        historyOfGames.Add($"You choosed game number 4. First number was: {number1} , second number was: {number2}, output was: {output}");





    }
    if (userInput == "5")
    {
        Console.WriteLine("History of games:");

        if (historyOfGames.Count > 0)
        {
            foreach (string element in historyOfGames)
            {
                Console.WriteLine(element);
            }
        }
        else
        {
            Console.WriteLine("\n0 games in game history \n");
        }



    }
    if (userInput == "6")
    {
        Console.WriteLine("Thank you for playing with me!");
        break;
    }
    else
    {
        Console.WriteLine(menuList);
        //making the loop
        i = 0;

    }

};






