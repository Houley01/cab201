using System;

class IncomeTax
{
    public static void Main()
    {
        // Var 
        bool income_valid = false, children_valid = false;
        string temp_total_income = "0", temp_number_of_children = "0";
        int total_income, number_of_children;
        double tax_ammount = 0;
        int deductions_per_kid = 2000, standard_deduction = 10000;
        // Total income
        while (income_valid == false)
        {
            Console.Write("What is your total income: ");
            temp_total_income = System.Console.ReadLine();

            if (int.TryParse(temp_total_income, out total_income))
            {
                if (total_income < 0)
                {
                    Console.WriteLine("Your income cannot be negative.");
                }
                else
                {
                    income_valid = true;
                }
            }
            else
            {

                Console.WriteLine("Enter your income as a whole-dollar figure.");
            }
        }

        // Total number of children
        while (children_valid == false)
        {
            Console.Write("How many children do you have: ");
            temp_number_of_children = System.Console.ReadLine();

            if (int.TryParse(temp_number_of_children, out number_of_children))
            {
                if (number_of_children < 0)
                {
                    Console.WriteLine("You must enter a positive number.");
                }
                else
                {
                    children_valid = true;
                }
            }
            else
            {
                Console.WriteLine("You must enter a valid number.");
            }
        }

        // Convert all to ints numbers
        total_income = Convert.ToInt32(temp_total_income);
        number_of_children = Convert.ToInt32(temp_number_of_children);

        // How much tax is owed
        total_income = total_income - (standard_deduction + (deductions_per_kid * number_of_children));
        if (total_income <= 0)
        {
            Console.WriteLine("You owe no tax.");
        }
        else
        {
            tax_ammount = total_income * 0.02;
            Console.WriteLine("You owe a total of ${0:F2} tax", tax_ammount);
        }
        Console.WriteLine("\n\n Hit Enter to exit.");
        Console.ReadLine();
    }
}