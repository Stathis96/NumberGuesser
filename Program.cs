// See https://aka.ms/new-console-template for more information

GetAppInfo();
GreetUser();

while (true)
{

    //Set correct number
    //int correctNumber = 7;
    Random random = new Random();
    int correctNumber = random.Next(1, 11);

    //Init guess var
    int guess = 0;
    Console.WriteLine("Guess a number between 1-10");

    while (guess != correctNumber)
    {
        string input = Console.ReadLine();

        //Make sure its a number
        if (!int.TryParse(input, out guess))
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Please enter a valid number");

            Console.ResetColor();

            //Keep going
            continue;
        }

        //Cast to int and put it to guess
        guess = Int32.Parse(input);

        //Match guess to correct number
        if (guess != correctNumber)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Wrong number, Try again!");

            Console.ResetColor();
        }
    }

    //Output success message
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("Congratulations! That was the right number!");

    Console.ResetColor();

    //Ask to play again
    Console.Write("Do you want to play again? ( Y or N)");
    string answer = Console.ReadLine().ToUpper();

    if (answer == "Y")
    {
        continue;
    }
    else if (answer == "N") 
    {
        return;
    }
    else
    {
        return;
    }
}

static void GetAppInfo()
{
    string appName = "Number Guesser Game";
    string appVersion = "1.0.0";
    string appAuthor = " Stathis Io";

    //Change textcolour
    Console.ForegroundColor = ConsoleColor.Green;

    //Basic stuff for app info
    Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);

    //rechange back to normal
    Console.ResetColor();

}

static void GreetUser()
{
    //ask user's name
    Console.WriteLine("What is your name");
    string nameGiven = Console.ReadLine();
    Console.WriteLine("Hello {0}, lets play a guessing game !!", nameGiven);
}