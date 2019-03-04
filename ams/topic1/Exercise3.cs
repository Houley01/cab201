using System;

public class StringOrder
{
    enum Order { Precedes = -1, Equals = 0, Follows = 1 };

    public static void Main()
    {
        System.String nameA;
        System.String nameB;
        // Name A Part
        Console.WriteLine("What is name A?");
        Console.Write("Name: ");
        nameA = System.Console.ReadLine();
        // System.Console.WriteLine(name1); // Debuging section
        // Name B part
        Console.WriteLine("What is name B?");
        Console.Write("Name: ");
        nameB = System.Console.ReadLine();

        // Compare the names to gether
        // {A} Precedes(Comes Before) {B}
        System.Console.WriteLine("{0} {1} {2}", nameA, (nameA.CompareTo(nameB)).Order, nameB);
        System.Console.ReadLine();
        // {A} Equals {B}
        // System.Console.WriteLine();
        // System.Console.ReadLine();
        // // {A} Follows {B}

        // System.Console.WriteLine();
        // System.Console.ReadLine();
        // So the program does not close
        // System.Console.ReadLine();
    }
}
