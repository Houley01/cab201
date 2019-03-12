using System;

class IncomeTax
{
    public static void Main()
    {
        // Var 
        bool income_valid = false, children_valid = false;
        string temp_total_income, temp_number_of_children;
        int total_income, number_of_children;
        double tax_ammount = 0;

        // Total income
        while(income_valid == false) {
            Console.Write("What is your total income: ");
            temp_total_income = System.Console.ReadLine();
            
            if (int.TryParse(temp_total_income, out total_income))
            {
                if (total_income < 0 )
                {
                    Console.WriteLine("Your income cannot be negative");
                }
                else {
                    income_valid = true;
                    globe total_income = total_income;
                }
            }
            else {

                Console.WriteLine("Enter your income as a whole-dollar figure.");
            }
        }
            Console.WriteLine(total_income);

        // Total number of children
        while (children_valid == false)
        {
            Console.Write("How many children do you have: ");
            temp_number_of_children = System.Console.ReadLine();

            if (int.TryParse(temp_number_of_children, out number_of_children))
            {
                if (number_of_children < 0)
                {
                    Console.WriteLine("You cannot have negative number of children");
                }
                else
                {
                    children_valid = true;
                }
            }
            else
            {
                Console.WriteLine("You must enter a vaild number.");
            }
        }
        Console.WriteLine(tax_ammount);
    //     if (total_income >= 0)
    //     {
    //         Console.WriteLine("You owe no tax");   
    //     } else {
    //         Console.WriteLine("You owe a total of ${0} tax", tax_ammount);
    //     }
    //       // System.Console.WriteLine(total_income);
    }
}