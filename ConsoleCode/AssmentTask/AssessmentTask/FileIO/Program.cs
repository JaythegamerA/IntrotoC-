using System.IO;

namespace AIE
{
    class AlpabetizeAFile
    {
 
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
