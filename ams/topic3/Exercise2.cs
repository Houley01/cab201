using System;


class MatrixLibrary
{
    public static void Main()
    {
        // int[,] array_1 =
        // {
        //     {1, 4, 2},
        //     {2, 5, 1}
        // };
        // int[,] array_2 = new int[,]
        // {
        //     {10, 5, 2},
        //     {2, 34, 2},
        //     {2, 25, 2}
        // };
        // int[,] array_2 =
        // {
        //     {3, 4, 2},
        //     {3, 5, 7},
        //     {1, 2, 1}
        // };
        // MatrixToString(array_2);

        int[,] ams =
        {
            {184, 579, 531, 325},
            {129, 611, 421, 184},
            {199, 779, 657, 360}
        };
        // Console.WriteLine(MatrixToString(ams));
        // MatrixToString(ams);


        int[,] array_1 = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
        };
        int[,] array_2 =
        {
            {7, 8},
            {9, 10},
            {11, 12},
        };

        MatrixMultiply(array_1, array_2);
        Console.ReadLine();

    }
    public static string MatrixToString(int[,] matrix_2d)
    {
        string cell;
        string finalFormat = "";
        for (int left_side = 0; left_side < matrix_2d.GetLength(0); left_side++)
        {
            for (int right_side = 0; right_side < matrix_2d.GetLength(1); right_side++)
            {
                cell = Convert.ToString(matrix_2d[left_side, right_side]);
                finalFormat += string.Format("{0, -4}", cell);
                // Console.Write(matrix_2d[left_side, right_side]);
            }
            finalFormat += "\n";
        }
        return finalFormat; // string.Format("{0, -4}", cell);

    }

    public static int[,] MatrixMultiply(int[,] matrix_a, int[,] matrix_b)
    {
        // Matrix_a (Rows) Need to match Matrix_b (columns)
        // array.GetLength(0) 0 == row count
        // array.GetLength(1) 1 == column count
        // Console.WriteLine("Matrix_a row count: {0}", matrix_a.GetLength(0));
        // Console.WriteLine("Matrix_b column count: {0}", matrix_b.GetLength(1));
        int row, column, numberForArray;
        row = matrix_a.GetLength(0);
        column = matrix_b.GetLength(1);
        int[,] c = new int[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                numberForArray = 0;
                for (int z = 0; z < matrix_b.GetLength(0); z++)
                {
                    numberForArray += (matrix_a[i,z] * matrix_b[z,j]);
                }
                c[i, j] = numberForArray;
            }
        }
        // Console.WriteLine(MatrixToString(c));
        // MatrixToString(c);
        return c;
    }
}
