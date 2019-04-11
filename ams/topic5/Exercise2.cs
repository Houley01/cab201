using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DieRoller
{
    /// <summary>
    /// Represents one die (singular of dice) with faces showing values between
    /// 1 and the number of faces on the die.
    /// </summary>
    public class Die
    {
        // Implement your 'Die' class here
        private int numFaces;
        private int faceValue;

        public int NumFaces {
            get; set;
        }

        public int FaceValue {
            get; set;
        }

        public Die() {
            NumFaces = 6;
            FaceValue = 1;
        }

        public Die(int faces) {
            NumFaces = 6;
            if (faces >= 3)
            {                
                NumFaces = faces;
            } 
            FaceValue = 1;
        }

        Random Roll = new Random();
        public void RollDie() {
            FaceValue = Roll.Next(1, NumFaces+1);
        }

        public int GetFaceValue() {
            return FaceValue;
        }

        public int GetNumFaces() {
            return NumFaces;
        }

    }// end Class Die

    public class Program
    {
        public static void Main()
        {
            // This will not be called by the AMS, however you may want to test your Die class here.
            Die myDie = new Die(6);

            for (int i = 0; i < 100; i++)
            {
                myDie.RollDie();
                Console.Write("{0}, ", myDie.GetFaceValue());
                
            }


            Console.WriteLine("\nPress enter to exit.");
            Console.ReadLine();
        }
    }
}

