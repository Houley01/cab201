using System;

public class CommandLineArgs
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please enter at least one argument.");
            // Console.ReadLine();
            // Environment.Exit(0);
            //return;
        }
        else
        {
            // Argument count is: 3
            Console.WriteLine("Argument count is: {0}", args.Length);
            for (int j = 0; j < args.Length; j++)
            {
                // Console.WriteLine("Arg {0} is: {1}", j, argumentString[j]);
                Console.WriteLine("Arg {0} is: {1}", j, args[j]);

            }
        }
        // Console.ReadLine();
    }
}