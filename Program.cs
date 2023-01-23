using Circle_Objects_Lab;

Console.WriteLine("Welcome to the Circle Tester!");

bool runProgram = true;
while (runProgram)
{

    Console.WriteLine("Please enter a radius. (Allows Decimal): ");

    double userNum = double.Parse(Console.ReadLine());

   
    if (userNum > 0)
    {
        Circle myCircle = new Circle(userNum);
        Console.WriteLine($"The circumference is {myCircle.CalculatedFormattedCircumference()}");
        Console.WriteLine("");
        Console.WriteLine($"The area is {myCircle.CalculatedFormattedArea()}");
    }
    else if(userNum < 0)
    {
        Console.WriteLine("Invaild input please try again!"); 
    }

    Console.WriteLine("Would you like to try again? y/n");
    string choice = Console.ReadLine().ToLower().Trim();
    if(choice == "y" || choice == "yes")
    {
        runProgram = true;
    }
    else if(choice == "n" || choice == "no")
    {
        runProgram = false;
        Console.WriteLine("Thanks for playing!");
    }

}

