using System;


namespace AIE
{
    class Program
    {
        static void Main()
        {
            //Arrays
            char singleChar = 'a';

            char[] characters = { 'A', 'B', 'C' };
            char[] blankCHars = new char[3];

            Console.WriteLine(characters[0]);
            characters[1] = '!';
            Console.WriteLine(characters[1]);


            //Loops

            //      for(int i = 0; i < characters.Length; i++)
            //      {
            //          Console.WriteLine(characters[i]);
            //      }
            //
            foreach (char curChar in characters)
            {
                Console.WriteLine(curChar);
            }

            for (int i = characters.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(characters[i]);
            }

            //Array Sum
            int[] arrayToCombine = { 1, 2, 3, 4 };
            AddArray(arrayToCombine);

            //Array Sort and Reverse

            int[] unsortedArray = { 4, 5, 1, 7 };
            ReverseArray(unsortedArray);

            //Adding Two Numbers
            float firstNumber = 1.3f;
            float secondNumber = 2.6f;

            AddNumbers(firstNumber, secondNumber);

            //Three numbers

            Console.WriteLine("Gimme three numbers");
            Console.WriteLine("What's the first number?");
            string firstNum = Console.ReadLine();
            Console.WriteLine("What's the second number?");
            string secondNum = Console.ReadLine();
            Console.WriteLine("What's the third number?");
            string thirdNum = Console.ReadLine();

            string[] threeNums = { firstNum, secondNum, thirdNum };

            foreach (String str in threeNums)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("");


            // FIZZ BUZZ

            int[] fizzBuzzNums = new int[21];

            for (int i = 0; i < fizzBuzzNums.Length; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("");

            //FIBONACCI

            int[] fiboNums = { 1, 2, 5, 11 };

            int currentNum = 0;

            for (int i = 0; i < fiboNums.Length; i++)
            {

                currentNum = currentNum + fiboNums[i];
                Console.WriteLine(fiboNums[i]);
                Console.WriteLine(currentNum);
            }

            Console.WriteLine("");


            //GRID

            Console.WriteLine("Give me the length for a grid");
            string gridLength = Console.ReadLine();
            Console.WriteLine("Give me the width for a grid");
            string gridWidth = Console.ReadLine();

            int userLength = 0;
            int.TryParse(gridLength, out userLength);

            int userWidth = 0;
            int.TryParse(gridWidth, out userWidth);

            int[] lengthNum = new int[userLength];
            int[] widthNum = new int[userWidth];

            string draw = "";

            foreach (int width in widthNum)
            {
                draw += "X";
            }

            foreach (int length in lengthNum)
            {
                Console.WriteLine(draw);
            }


            //GUESS THE NUMBER

            Random rnd = new Random();
            int answer = rnd.Next(1, 10);

            int[] attempts = new int[4];


            Console.WriteLine("I'm thinking of a number between 1 and 10. Try to guess it!");

            bool isCorrect = false;

            for (int i = attempts.Length; i >= 0; i--)
            {
                string userAnswer = Console.ReadLine();
                int userInput = 0;

                int.TryParse(userAnswer, out userInput);

                if (userInput == answer)
                {
                    Console.WriteLine("You are correct!");
                    isCorrect = true;
                    i = -1;
                }
                else if (userInput > answer)
                {
                    Console.WriteLine("WRONG! Too high.");
                }
                else if (userInput < answer)
                {
                    Console.WriteLine("WRONG! Too low.");
                }
            }

            if (isCorrect == true)
            {
                Console.WriteLine("CONGRAGULATIONS!!!");
            }
            else
            {
                Console.WriteLine("FAILURE!!!");
            }
        }

        static int AddArray(int[] array)
        {
            Console.WriteLine(array.Sum());
            return array.Sum();
        }

        static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Array.Sort(array);
            Array.Reverse(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static int AddNumbers(float numberOne, float numberTwo)
        {
            int sum = ((int)(numberOne + numberTwo));

            Console.WriteLine("The sum of the floats as a whole number is " + sum);
            return sum;
        }
    }
}