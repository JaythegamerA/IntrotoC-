namespace AIE
{
    class Program
    {
        static void Main()
        {
            //writing text to a file
            using (StreamWriter writer = new StreamWriter("aboutJonathanArzate.txt"))
            {
                writer.WriteLine("Jonathan Arzate");
                writer.WriteLine("Favorite color? Crimson Red");
                writer.WriteLine("Favorite Number? 26.");
            }

            //reading text from a file
            using (StreamReader reader = new StreamReader("aboutJonathanArzate.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }

            /*
             *      level=5
             *      exp=10
             *      atk=2
             */

            //
            // hello save file
            //
            //writing text to a file
            using (StreamWriter writer = new StreamWriter("saveData.txt"))
            {
                writer.WriteLine("level=2");
                writer.WriteLine("exp=5");
                writer.WriteLine("atk=1");
            }

            //reading text from a file
            using (StreamReader reader = new StreamReader("saveData.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split('=');
                    Console.WriteLine(parts[0] + " is " + parts[1]);
                }
            }
        }
    }

}