using System;


namespace AIE
{
    class IntroTask
    {
        static void Main()
        {
            Console.WriteLine(AddNumbers(1.1f, 3.89f));

            Console.WriteLine(AddNumbers(5.1f, 3.89f));

            Console.WriteLine(AddNumbers(0.5f, 2.89f));


            Fibonacci();

            FizzBuzz();

        }

        static int AddNumbers(float x, float y)
        {
            return (int)(x + y);
        }


        static void Fibonacci()
        {
            string output = "";
            int length = 0;
            Console.WriteLine("How long would you like the fibonacci sequence to run for?");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out length);
            int[] fibSequence = new int[length];
            for (int i = 0; i < length; i++)
            {
                if (i == 0)
                {
                    fibSequence[i] = 0;
                }
                else if (i == 1)
                {
                    fibSequence[i] = 1;
                }
                else
                {
                    fibSequence[i] = fibSequence[i - 1] + fibSequence[i - 2];
                }
                output += ((fibSequence[i]) + " ");
            }
            Console.WriteLine(output);
        }


        static void FizzBuzz()
        {
            int startingNumber = 1;
            int endingNumber = -1;
            int arrayLength = 0;

            Console.WriteLine("Please provide an ending number: ");
            string userInput = Console.ReadLine();
            int.TryParse((string)userInput, out endingNumber);

            arrayLength = (endingNumber - startingNumber) + 1;
            int[] fizzBuzzArray = new int[arrayLength];
            for (int i = 0; i < fizzBuzzArray.Length; i++)
            {

                fizzBuzzArray[i] = startingNumber + i;
                if (fizzBuzzArray[i] % 3 == 0 && fizzBuzzArray[i] % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (fizzBuzzArray[i] % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (fizzBuzzArray[i] % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(fizzBuzzArray[i] + " ");
                }
            }
        }
    }
}