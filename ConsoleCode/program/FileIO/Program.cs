using System;
using System.IO;

namespace AIE
{
    class Program
    {
        static void Main()
        {
            //
            // System.IO.File
            //

            // write to a file using System.IO.File
            string bio = "John Madden.\nPretty cool guy.";
            File.WriteAllText(@"C:\Secrets\aboutJohnMadden.txt", bio);

            // read from a file using System.IO.File
            string content = File.ReadAllText(@"C:\Secrets\aboutJohnMadden.txt");

            //
            // StreamWriter/StreamReader
            //

            // writing text to a file
            using (StreamWriter writer = new StreamWriter("aboutTerryNguyen.txt"))
            {
                writer.WriteLine("Jonathan Arzate.");
                writer.WriteLine("Likes oranges.");
                writer.WriteLine("Favorite color? Orange.");
                writer.WriteLine("Favorite number? 5.");
            }

            // reading text from a file
            using (StreamReader reader = new StreamReader("aboutTerryNguyen.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }

            //
            // Hello Save File
            //
            using (StreamReader reader = new StreamReader("saveData.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split('=');

                    int num = 0;
                    int.TryParse(parts[1], out num);

                    Console.WriteLine(parts[0] + " is " + num);
                }
            }
        }
    }
}