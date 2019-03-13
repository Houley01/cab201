using System;
class MilesPerHourTable
{
    public static void Main()
    {
        bool quit = false;
        string temp_user_input;
        int conversion_rates = 0.62137, user_input; // 1 km = 0.62137

        while (!quit) {
            ("Enter row count or quit(q): ");
            temp_user_input = Console.ReadLine();
            if (int.TryParse(temp_user_input, out user_input))
            {
                
            }
            if (getchar() = 'q')
            {
                quit = true;    
            }
        }
    }
}