using System;
class MilesPerHourTable
{
    public static void Main()
    {
        bool quit = false;
        string temp_number_of_rows;
        double conversion_rates = 0.62137;
        double kms;
        int number_of_rows = 0, miles = 15;
        char quit_char;

        while (quit == false)
        {
            Console.Write("Enter row count or quit(q): ");
            temp_number_of_rows = Console.ReadLine();
            if (int.TryParse(temp_number_of_rows, out number_of_rows))
            {
                miles = 15;
                Console.WriteLine("MPH\tKPH");
                for (int i = 1; i <= number_of_rows; i++)
                {
                    kms = miles / conversion_rates;
                    Console.WriteLine("{0}\t{1:f2}", miles, kms);

                    miles = miles + 10;
                }
            }
            if (char.TryParse(temp_number_of_rows, out quit_char))
            {
                quit = true;
            }
        }
    }
}