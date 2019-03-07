using System;

public class StringOrder
{
    enum Order { Precedes = -1, Equals = 0, Follows = 1 };

    public static void Main()
    {
        System.String nameA;
        System.String nameB;
        int placeOrder;
        // Name A Part
        Console.WriteLine("What is name A?");
        nameA = System.Console.ReadLine();
        // System.Console.WriteLine(name1); // Debuging section
        // Name B part
        Console.WriteLine("What is name B?");
        nameB = System.Console.ReadLine();
        //  Remove Name from user input
        nameA = nameA.Substring(6);
        nameB = nameB.Substring(6);

        // Compare the names to gether
        // {A} Precedes(Comes Before) {B}
        placeOrder = nameA.CompareTo(nameB);
        // Order a=(Order)placeOrder;
        // System.Console.WriteLine(a);
        System.Console.WriteLine("{0} {1} {2}", nameA, (Order)placeOrder, nameB);
        System.Console.ReadLine();
    }
}
