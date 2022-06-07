using System;
using System.Collections.Generic;

namespace MasterMind
{
    class MasterMind
    {
        public int RandomCode(int a, int b)
        {
            Random CrackCode = new Random();
            int randCode = CrackCode.Next(a, b);
            return randCode;
        }

        public int[] MasterCode()
        {
            MasterMind HiddenCode = new MasterMind();
            int[] masterCode = new int[] { 1, 2, 3, 4 };
            for (int i = 0; i < masterCode.Length; i++)
            {
                masterCode[i] = HiddenCode.RandomCode(1, 5);
            }
            return masterCode;
        }
        static void Main(string[] args)
        {
            MasterMind StoredCode = new MasterMind();
            int[] codeDisplay = StoredCode.MasterCode();

            Console.WriteLine("Crack the Code!");

           
            Console.WriteLine(String.Join(" ", codeDisplay));

        }
    }
}
