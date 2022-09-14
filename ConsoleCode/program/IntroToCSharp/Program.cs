namespace AIE
{
    class Program
    {
        static void Main(string[] args)
        {
            //introduction
            Console.WriteLine("Hello World!");
            Console.WriteLine("Jonathan Arzate");
            Console.WriteLine("My favorite candy is M&Ms");
            Console.WriteLine("What vegtable would I be? I dunno. Cabbage.");
            Console.WriteLine("I've been playing games since I was little.");
            Console.WriteLine("The first game I've played is Halo.");


            int age = 18;

            Console.WriteLine(age);

            //interview
            Console.WriteLine("What's your favorite candy?");
            string favCandyInput = Console.ReadLine();
            Console.WriteLine("So " + favCandyInput + " is your favorite candy?");

            if (favCandyInput == "Skittles")
            {
                Console.WriteLine("I prefer M&Ms.");
            }

            else if (favCandyInput == "M&Ms")
            {
                Console.WriteLine("Cool");
            }

            else
            {
                Console.WriteLine("That candy doesn't exist.");
            }

            Console.WriteLine("What's your favorite color");
            string colorInput = Console.ReadLine();
            Console.WriteLine(colorInput + " is a great color, but I like purple.");

            Console.WriteLine("Pick two numbers for the length and width of a rectangle.");
            Console.WriteLine("Choose the length");
            string length = Console.ReadLine();
            Console.WriteLine("Now choose the width");
            string width = Console.ReadLine();
            int userLength = 0;
            int.TryParse(length, out userLength);
            int userWidth = 0;
            int.TryParse(width, out userWidth);
            int area = userLength * userWidth;
            Console.WriteLine("The area of your rectangle is " + area);



            Console.WriteLine("Give me a random number");
            string numberInput = Console.ReadLine();
            int userNumber = 0;
            int.TryParse(numberInput, out userNumber);
            Console.WriteLine("You have chosen the number " + userNumber);
            Console.WriteLine("Hold on, is your number actually " + userNumber * userNumber + "?");

            //quiz
            Console.WriteLine("QUIZ TIME!");
            int currentPoints = 0;
            int maxpoints = 8;

            Console.WriteLine("Who am I?");
            string nameInput = Console.ReadLine();
            Console.WriteLine("You chose " + nameInput + "...");



            if (nameInput == "sam")
            {
                Console.WriteLine("you are CORRECT!");
                currentPoints += 1;
            }
            else
            {
                Console.WriteLine("you are WRONG!");
            }

            Console.WriteLine("What's my favorite game?");
            string gameInput = Console.ReadLine();
            Console.WriteLine("You chose " + gameInput + "...");

            if (gameInput == "doom eternal")
            {
                Console.WriteLine("you are CORRECT!");
                currentPoints += 1;
            }
            else
            {
                Console.WriteLine("you are WRONG!");
            }

            Console.WriteLine("What class do I main in Team Fortress 2?");
            string tf2ClassInput = Console.ReadLine();
            Console.WriteLine("You chose " + tf2ClassInput + "...");

            if (tf2ClassInput == "pyro")
            {
                Console.WriteLine("you are CORRECT!");
                currentPoints += 1;
            }
            else
            {
                Console.WriteLine("you are WRONG!");
            }

            Console.WriteLine("Which Dungeons and Dragons class is my favorite");
            string dndClassInput = Console.ReadLine();
            Console.WriteLine("You chose " + dndClassInput + "...");

            if (dndClassInput == "rogue")
            {
                Console.WriteLine("you are CORRECT!");
                currentPoints += 1;
            }
            else
            {
                Console.WriteLine("you are WRONG!");
            }

            Console.WriteLine("Am I into Horror");
            string horrorInput = Console.ReadLine();
            Console.WriteLine("You chose " + horrorInput + "...");

            if (horrorInput == "yes")
            {
                Console.WriteLine("you are CORRECT!");
                currentPoints += 1;
            }
            else
            {
                Console.WriteLine("you are WRONG!");
            }

            Console.WriteLine("Am I a dog or cat person?");
            string dogInput = Console.ReadLine();
            Console.WriteLine("You chose " + dogInput + "...");

            if (dogInput == "dog person")
            {
                Console.WriteLine("you are CORRECT!");
                currentPoints += 1;
            }
            else
            {
                Console.WriteLine("you are WRONG!");
            }

            Console.WriteLine("Do I have siblings");
            string broInput = Console.ReadLine();
            Console.WriteLine("You chose " + broInput + "...");

            if (broInput == "yes")
            {
                Console.WriteLine("you are CORRECT!");
                currentPoints += 1;
            }
            else
            {
                Console.WriteLine("you are WRONG!");
            }

            Console.WriteLine("And finally...do I like souls games?");
            string soulsInput = Console.ReadLine();
            Console.WriteLine("You chose " + soulsInput + "...");

            if (soulsInput == "yes")
            {
                Console.WriteLine("you are CORRECT!");
                currentPoints += 1;
            }
            else
            {
                Console.WriteLine("you are WRONG!");
            }

            Console.WriteLine("You got " + currentPoints + " out of " + maxpoints + " questions correct");


            //calculator
            Console.WriteLine("Gimme two numbers");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            int numberOne = 0;
            int.TryParse(firstNumber, out numberOne);
            int numberTwo = 0;
            int.TryParse(secondNumber, out numberTwo);

            Console.WriteLine("Which operation should I use?");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine(numberOne + numberTwo);
            }

            else if (op == "-")
            {
                Console.WriteLine(numberOne - numberTwo);
            }

            else if (op == "*")
            {
                Console.WriteLine(numberOne * numberTwo);
            }

            else if (op == "/")
            {
                Console.WriteLine(numberOne / numberTwo);
            }

            else
            {
                Console.WriteLine("That's not an operation...anyways...");
            }
        }
    }
}