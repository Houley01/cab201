// Writes to a file;
using System;
using System.IO;

class program
{

    static void Main(string[] args)
    {
        // file write
        FileStream outfile = new FileStream("test.txt", FileMode.Create, FileAccess.Write);
        StreamWriter writer = new StreamWriter(outfile);
        for (int i = 0; i < 10; i++)
        {
            writer.WriteLine("line no: " + i);
        }
        writer.Close();
        outfile.Close();
    }
}