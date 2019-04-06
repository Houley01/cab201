using System;

class Sequence
{
    public static string[] Kmers(int k, string dnaSequence)
    {
        int stringLenght = dnaSequence.Length;
        int arrayLength = stringLenght - k;
        arrayLength += 1;
        string[] array_kmers = new string[arrayLength];
        for (int i = 0; i < arrayLength; i++)
        {
            // i = first letter + k for number letter in the string 
            array_kmers[i] = dnaSequence.Substring(i, k);
        }
        return array_kmers;
    }
    public static string ReversComplement(string PreReversString)
    {
        // A with T
        // T with A
        // G with C
        // C with G
        string FilpLetterString = "", reversString ="";
        int stringLenght = PreReversString.Length;
        // string[] reversSting_Array = new string[stringLenght];
        for (int i = 0; i < stringLenght; i++)
        {
            if (PreReversString.Substring(i, 1) == "A")
            {
                FilpLetterString += "T";
            }
            if (PreReversString.Substring(i, 1) == "T")
            {
                FilpLetterString += "A";
            }
            if (PreReversString.Substring(i, 1) == "G")
            {
                FilpLetterString += "C";
            }
            if (PreReversString.Substring(i, 1) == "C")
            {
                FilpLetterString += "G";
            }
        }
        for (int i = FilpLetterString.Length; i == 0 ;i--)
        {
            reversString += FilpLetterString.Substring(i,1);
        }
        return reversString;
    }

    public static bool Dyad(string dyad, int length) { 
        string upstream = "", downstream = "";//, cleanInput ="";

        if (0 < length)
        {
            for (int i = length; i <= dyad.Length/2; i++)
            {
                upstream = dyad.Substring(0,i);

               downstream = dyad.Substring(dyad.Length-i, i);
            }

        }    
            Console.WriteLine(upstream);
            Console.WriteLine(downstream);
            upstream = ReversComplement(upstream);
            downstream = ReversComplement(downstream);
            downstream = ReversComplement(downstream);

            Console.WriteLine();
            Console.WriteLine();
                
                Console.WriteLine(upstream);
                Console.WriteLine(downstream);

            if (upstream == downstream) {
                return true;
            }

        return false;
    }

    public static void Main()
    {
        // Kmers(3, "AGATCGAGTG");
        // Console.WriteLine(ReversComplement("AAGCT"));
        Dyad("TTACGnnnnnnCGTAA", 4);
    }
}