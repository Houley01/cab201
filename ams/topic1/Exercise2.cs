using System;

public class HelloWorldV2
{
    public static void Main()
    {
        // Declare a 'string' variable called 'name' to hold the user's name
        System.String name;
        // Display the message "Please enter your name:  ".
        // (hint: Use Console.Write instead of WriteLine for this)
        System.Console.Write("Please enter your name:  ");


        // Use Console.ReadLine to read what the user types into the 'name' variable
        name = System.Console.ReadLine();

        // Write a single blank line
        System.Console.WriteLine("");

        // Write "Hello (name goes here), and welcome to CAB201" on a line by itself.
        // Instead of (name goes here) you should put in the name the user gave you.
        System.Console.WriteLine("Hello {0}, and welcome to CAB201", name);

        // Write "Press enter to exit" on a line by itself
        System.Console.WriteLine("Press enter to exit");

        // Wait for the user to press the enter key
        System.Console.ReadLine();
    }
}