// Reasd a file;
using System;
using System.IO;

class program
{

    static void Main(string[] args)
    {
        string fileLoc = "test.txt";
        if (File.Exists(fileLoc))
        {
            FileStream readfile = new FileStream(fileLoc, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(readfile);


            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }

            reader.Close();
            readfile.Close();
        }
        Console.ReadLine();
    }
}