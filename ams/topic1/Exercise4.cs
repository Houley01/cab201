using System;
public class Matrix
{
    public static void Main()
    {
        String temp_row_size, temp_column_size, temp_search_for_location; // string varibles
        int row_size, column_size, search_for_location, count = 0, x_axis = 0, y_axis = 0; // Int varibles

        // Get user input after questions
        Console.WriteLine("What is the matrix row size?");
        temp_row_size = Console.ReadLine();

        Console.WriteLine("What is the matrix column size?");
        temp_column_size = Console.ReadLine();

        Console.WriteLine("What is your number ?");
        temp_search_for_location = Console.ReadLine();


        // converter the string to int 
        row_size = Convert.ToInt32(temp_row_size);
        column_size = Convert.ToInt32(temp_column_size);
        search_for_location = Convert.ToInt32(temp_search_for_location);

        int[,] matrix_array = new int[row_size, column_size]; // Delclaring the size of the array based on userinput

        for (int row_count = 0; row_count < row_size; row_count++) //Outer loop (Rows)
        {
            for (int column_count = 0; column_count < column_size; column_count++) // Inner loop (column)
            {
                matrix_array[row_count, column_count] = count;
                if (count == search_for_location) // Checking if the number is found while building the array
                {
                    x_axis = row_count;
                    y_axis = column_count;
                }
                count++;
            }
        }

        // print the location of your number
        Console.WriteLine("{0} is in row {1} and column {2}", search_for_location, x_axis, y_axis);



        //  Stop the program from exiting
        Console.ReadLine();
    }
}