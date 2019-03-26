using System;

namespace RandomArray
{
    public class RandomArrayNoDuplicates
    {
        public static void Main()
        {
            MatrixToString(ArrayWithNoDuplicates(25));
        }
        static Random rng = new Random();
        /// <summary>
        /// Creates an array with each element a unique integer
        /// between 1 and 45 inclusively.
        /// </summary>
        /// <param name="size"> length of the returned array < 45
        /// </param>
        /// <returns>an array of length "size" and each element is
        /// a unique integer between 1 and 45 inclusive </returns>
        public static string MatrixToString(int[] matrix)
        {
            string cell;
            for (int left_side = 0; left_side < matrix.Length; left_side++)
            {
                cell = Convert.ToString(matrix[left_side]);
                Console.Write(string.Format("{0}\n", cell)); ;
            }
            return null;
        }
        public static int[] ArrayWithNoDuplicates(int LengthOfArray)
        {
            int[] array_with_no_duplicates = new int[LengthOfArray];
            int randomNum, i = 0;
            bool arraySize = false;
            // for (int i = 0; i < array_with_no_duplicates.Length; i++)
            while (arraySize == false)
            {
                randomNum = rng.Next(0, 45);
                // Console.WriteLine(randomNum);
                if (i == LengthOfArray)
                {
                    arraySize = true;
                    break;
                }
                if (!Array.Exists(array_with_no_duplicates, element => element == randomNum))
                {
                    array_with_no_duplicates[i] = randomNum;

                    i += 1;
                }
            }
            // Array.Sort(array_with_no_duplicates);
            // MatrixToString(array_with_no_duplicates);
            return array_with_no_duplicates;
        }
    }
}
