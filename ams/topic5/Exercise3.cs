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

        public int NumFaces
        {
            get; set;
        }

        public int FaceValue
        {
            get; set;
        }

        public Die()
        {
            NumFaces = 6;
            FaceValue = 1;
        }

        public Die(int faces)
        {
            NumFaces = 6;
            if (faces >= 3)
            {
                NumFaces = faces;
            }
            FaceValue = 1;
        }

        Random Roll = new Random();
        public void RollDie()
        {
            FaceValue = Roll.Next(1, NumFaces + 1);
        }

        public int GetFaceValue()
        {
            return FaceValue;
        }

        public int GetNumFaces()
        {
            return NumFaces;
        }
    }// end class Die

    public class Dice
    {
        // Implement your 'Dice' class here
        // ...

        private int dice;
        private int numFaces;
        private int faceValue;

        public int[] ArrayDice
        {
            get; set;
        }

        public int NumFaces
        {
            get; set;
        }

        Random Roll = new Random();
        public Dice(int dice)
        {
            this.dice = dice;
            numFaces = 6;
            faceValue = dice;
        }

        public Dice(int dice, int faces)
        {
            this.dice = dice;
            if (faces >= 3)
            {
                numFaces = faces;
            }
            else
            {
                numFaces = 6;
            }
            faceValue = dice;
        }

        public void RollDice()
        {
            int DIEROLL = 0;
            for (int i = 0; i < dice; i++)
            {
                DIEROLL = Roll.Next(numFaces) + 1;
                // Console.WriteLine("ROLL {0} is:{1}", i, DIEROLL);
                faceValue += DIEROLL;
            }
        }

        public int GetFaceValue()
        {
            return faceValue;
        }

    }// end class Dice

    public class Program
    {
        public static void Main()
        {
            Dice myDice = new Dice(1, 5);


            myDice.RollDice();
            Console.WriteLine("Total for Each Roll: {0}\n", myDice.GetFaceValue());


            Console.WriteLine("\nPress enter to exit.");
            Console.ReadLine();
        }
    }
}
