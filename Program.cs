using System;
using System.Collections.Generic;

namespace MasterMind
{
    class Program
    {
        public int RandomCode(int a, int b)
        {
            Random crackCode = new Random();
            int randCode = crackCode.Next(a, b);
            return randCode;
        }

        public int[] MasterCode()
        {
            Program HiddenCode = new Program();
            int[] masterCode = new int[] { 1, 2, 3, 4 };
            for (int i = 0; i < masterCode.Length; i++)
            {
                masterCode[i] = HiddenCode.RandomCode(1, 5);
            }
            return masterCode;
        }
        static void Main(string[] args)
        {
            Program StoredCode = new Program();
            int[] codeDisplay = StoredCode.MasterCode();

            Console.WriteLine("Crack the Code!");

           
            Console.WriteLine(String.Join(" ", codeDisplay));

        }
    }
}
