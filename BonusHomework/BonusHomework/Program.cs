using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TestFunction
            // Task 1 Test
            //Console.WriteLine(IsPalindome("Room"));
            //Console.WriteLine(IsPalindome("R"));
            //Console.WriteLine(IsPalindome("RAdar"));

            // Task 2 Test
            //int[] array = { 1, 5, 2, 7 };
            //Console.WriteLine(MaxInArr(array));
            //Console.ReadLine();

            //Task 3 Test
            //Console.WriteLine(CountVowels("One 1 two 2 three 3 four 4"));
            //Console.WriteLine(CountDigitsInString("One 1 two 2 three 3 four 4"));

            //Task 4 Test
            //Console.WriteLine(UppLowCase("hI hOW aRE yOU"));

            //Task 5 Test
            //Console.WriteLine("HI");
            //Console.WriteLine("hi");
            //Console.WriteLine("2283heh3uih3");

            // Task 6 Test
            //Console.WriteLine(CountSubstring("The quick brown fox jumps over the lazy dog", "fox"));
            //Console.WriteLine(CountSubstring("The quick brown fox jumps over the lazy dog", "the"));

            // Task 7 Test
            //Console.WriteLine(CalcuOfPower(2, 0));
            //Console.WriteLine(CalcuOfPower(2, 1));
            //Console.WriteLine(CalcuOfPower(5, 3));

            

            #endregion
        }
        #region Functions
        // Task 1
        public static bool IsPalindome(string value)
        {
            string p = value.ToLower();
            if (p.Length == 1 || p.Length == 0) 
                return true;
            if (p[0] != p[p.Length - 1])
                return false;

            return IsPalindome(p.Substring(1, p.Length - 2));
            
        }
        // Task 2
        public static int MaxInArr(int[] arr)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
        // Task 3
        public static int CountVowels(string s)
        {
            string sentence = s.ToLower();
            int total = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    total++;
                }
            }

            return total;
        }

        public static int CountDigitsInString(string s)
        {
            int counter = 0;

            foreach (char c in s.ToCharArray())
            {
                if (c >= '0' && c <= '9')
                {
                    ++counter;
                }
            }

            return counter;
        }
        // Task 4
        public static string UppLowCase(string s)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                if (Char.IsLower(c))
                {
                    sb.Append(char.ToUpper(c));

                }
                else
                {
                    sb.Append(char.ToLower(c));
                }

            }

            string newString = sb.ToString();
            return newString;
        }

        // Task 5
        public static bool IsAlphabet(string s)
        {


            foreach (char c in s)
            {
                if (Char.IsLetter(c))
                {
                    if (Char.IsUpper(c))
                    {
                        Console.WriteLine("The character  is uppercase.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("The character is lowercase.");
                        return true;
                    }
                }
                else
                {
                    return false;
                }

            }
            return false;
        }
        // Task 6
        public static int CountSubstring(string text, string value)
        {
            int count = 0, minIndex = text.IndexOf(value, 0);
            while (minIndex != -1)
            {
                minIndex = text.IndexOf(value, minIndex + value.Length);
                count++;
            }
            return count;
        }

        // Task 7
        public static int CalcuOfPower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalcuOfPower(x, y - 1);
        }
       

    #endregion
}
}
