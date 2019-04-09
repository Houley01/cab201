using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceRoller
{

    public class Die
    {
        // You should include your Die class from the previous exercise here
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
    }// end class Die

    public class Dice
    {
        // Implement your 'Dice' class here
        // ...
        private int[] dice;

        public int[] ArrayDice {
            get; set;
        }

        // private int numFaces;

        // public int NumFaces {
        //     get; set;
        // }


        public Dice(int dice) {
            ArrayDice = new int[dice];
            NumFaces = 6;
            FaceValue = 1;
        }

        public Dice(int dice, int faces) {
            ArrayDice[dice];
            Die.NumFaces = face;
            FaceValue = 1;
        }

        public void RollDice() {
            for (int i = 0; i < ArrayDice.Length; i++)
            {
                ArrayDice[i] = Die.RollDie();
            }
        }

        public int GetFaceValue() {
            int sum = 0;
            for (int i = 0; i < ArrayDice.Length; i++)
            {
                sum += ArrayDice[i];
            }
            return sum;
        }

    }// end class Dice

    public class Program
    {
        public static void Main()
        {
            // This will not be called by the AMS, however you may want to test your Die class here.
            Die myDice = new Dice(2,4);

            // for (int i = 0; i < 100; i++)
            // {
                myDice.RollDie();
                Console.Write("{0} ", myDice.GetFaceValue());
                
            // }


            Console.WriteLine("\nPress enter to exit.");
            Console.ReadLine();
        }
    }
}
