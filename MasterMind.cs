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

        //public int[] UserCode()
        //{
        //    MasterMind UserCode = new MasterMind();
        //    int[] inputCode = new int[] { 1, 2, 3, 4 };
        //    Console.ReadLine(inputCode[]);
        //    for (int i = 0; i < masterCode.Length; i++)
        //    {
        //        masterCode[i] = HiddenCode.RandomCode(1, 5);
        //    }
        //    return masterCode;
        //}

        static void Main(string[] args)
        {
            MasterMind StoredCode = new MasterMind();
            int[] codeDisplay = StoredCode.MasterCode();

            Console.WriteLine("Crack the Code!");

           
            Console.WriteLine(String.Join(" ", codeDisplay));

            double val = 0;
            string num = "";
            Console.Write("Enter Number: ");
            ConsoleKeyInfo chr;
            do
            {
                chr = Console.ReadKey(true);
                if (chr.Key != ConsoleKey.Backspace)
                {
                    bool control = double.TryParse(chr.KeyChar.ToString(), out val);
                    if (control)
                    {
                        num += chr.KeyChar;
                        Console.Write(chr.KeyChar);
                        if (string.IsNullOrEmpty(num))
                        {
                            Console.WriteLine("Name can't be empty! Input your name once more");
                            num = Console.ReadLine();
                        }
                    }
                }
                else

                {
                    if (chr.Key == ConsoleKey.Backspace && num.Length > 0)
                    {
                        num = num.Substring(0, (num.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (chr.Key != ConsoleKey.Enter);
            Console.ReadKey();
        }
    }
}
