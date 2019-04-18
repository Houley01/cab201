using System;

public class Permutations
{
    // Helper method for outputting an array.
    private static void PrintArray(string[] array)
    {
        foreach (string element in array)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();
    }

    private static void Generate(int size, string[] array) {
        int postionSwap;
        
        if (size.Equals(1)) {
            PrintArray(array); 
        }
        else {
            for (int i = 0; i < size - 1; i++) 
            { 
                Generate(size - 1, array); 
                // checks to see if the number is even
                if (size % 2 == 0)  { 
                    postionSwap = i;
                } 
                else { 
                    postionSwap = 0; 
                }
                var temp = array[postionSwap]; 
                array[postionSwap] = array[size - 1]; 
                array[size - 1] = temp;
            } 
            Generate(size - 1, array); 
        }
    } 

    // Helper method for invoking Generate.
    private static void Generate(string[] array)
    {
        Generate(array.Length, array);
    }


    public static void Main(string[] args)
    {
        Permutations.Generate(args);
        // Permutations.PrintArray(args);
    }
}