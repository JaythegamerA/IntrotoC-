using System.IO;

namespace AIE
{
    class AlpabetizeAFile
    {
        //create a program that will read a plain text file called 'words.txt' containing a list of randomized words.
        //your program must sort these words in alphabetical order and write the ordered list of words to a new file called 
        //'output.txt'
        //the structure of the input file words.txt will be:
        //  first line: integer indicating the number of words in the file
        //  remaining lines contain one word per line
        static void Main()
        {
            int wordCount = 0;
            List<string> words = new List<string>();

            //read the file
            using (StreamReader reader = new StreamReader("words.txt"))
            {
                while (!reader.EndOfStream)
                {
                    //check if the word count has been set
                    if (wordCount == 0)
                    {
                        string line = reader.ReadLine();
                        int.TryParse(line, out wordCount);
                    }
                    words.Add(reader.ReadLine());
                }
            }
            words.Sort();
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                foreach (string s in words)
                {
                    writer.WriteLine(s);
                }
            }
        }
    }

}
