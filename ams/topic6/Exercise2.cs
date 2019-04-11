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

    // Helper method for invoking Generate.
    private static void Generate(string[] array)
    {
        Generate(array.Length, array);
    }

    public static void Main(string[] args)
    {

    }
}