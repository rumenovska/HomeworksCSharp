using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1/Test
            Console.WriteLine(Factoriel(10));
            #region DateTime Task2
            ////Create datetime            
            //DateTime dt = new DateTime(2018, 02, 21, 18, 50, 23, 230);

            ////Example how it looks like in the output
            //var t = String.Format("{0:t}", dt); // "18:50" ShortTime

            //Console.WriteLine(t);
            //var d = String.Format("{0:d}", dt); // 21.02.2018
            //Console.WriteLine(d);
            //var T = String.Format("{0:T}", dt); // 18:50:23
            //Console.WriteLine(T);
            //var D = String.Format("{0:D}", dt); // среда, 21 февруари 2018
            //Console.WriteLine(D);
            //var f = String.Format("{0:f}", dt); // среда, 21 февруари 2018 18:50
            //Console.WriteLine(f);
            //var F = String.Format("{0:F}", dt); // среда, 21 февруари 2018 18:50:23
            //Console.WriteLine(F);
            //var g = String.Format("{0:g}", dt); // 21.02.2018 18:50
            //Console.WriteLine(g);
            //var G = String.Format("{0:G}", dt); // 21.02.2018 18:50:23
            //Console.WriteLine(G);
            //var m = String.Format("{0:m}", dt); // 21 Февруари
            //Console.WriteLine(m);
            //var y = String.Format("{0:y}", dt); // Февруари 2018
            //Console.WriteLine(y);
            //var r = String.Format("{0:r}", dt); // Wed, 21 Feb 2018 18:50:23 GMT
            //Console.WriteLine(r);
            //var s = String.Format("{0:s}", dt); // 2018-02-21T18:50:23
            //Console.WriteLine(s);
            //var u = String.Format("{0:u}", dt); // 2018-02-21 Z18:50:23
            //Console.WriteLine(u);

            //Console.WriteLine("--------------");

            //DateTime TimeNow = DateTime.Now;
            //DateTime TimeUtc = DateTime.UtcNow;
            //DateTime TimeToday = DateTime.Today;
            //Console.WriteLine("Current DateTime: {0} ", TimeNow);  	// Current DateTime: 11.03.2019 10:31:01
            //Console.WriteLine("UTC DateTime:     {0} ", TimeUtc); 	// UTC DateTime: 11.03.2019 09:31:01
            //Console.WriteLine("Today:            {0} ", TimeToday); // Today: 11.03.2019 00:00:00
            //Console.WriteLine();

            //DateTime yesterday;
            //yesterday = TimeNow.AddDays(-1);
            //Console.WriteLine("Yesterday: {0}", yesterday);								// Yesterday: 10.03.2019 10:31:01
            //Console.WriteLine("The day before yesterday {0}", yesterday.TimeOfDay);		// The day before yesterday 10:31:01.7019858
            //Console.WriteLine("Minus 2 hours: {0}", TimeNow.AddHours(-2));              // Minus 2 hours: 08:31:01

            //int mDays = DateTime.DaysInMonth(2016, 2);
            //Console.WriteLine("Month Feb, 2016 has {0} days.", mDays);							// Month Feb, 2016 has 29 days.
            //Console.WriteLine("Month Feb, 2018 has {0} days.", DateTime.DaysInMonth(2018, 2));  // Month Feb, 2018 has 28 days.
            #endregion

            // Task 3
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            int countWord = text.Split().Length;
            int countSpaces = text.Count(Char.IsWhiteSpace);
            Console.WriteLine(WordCount(text));
            Console.WriteLine($"'{text}': Contains: {countWord} words and {countSpaces} spaces");
            Console.WriteLine(text.Length);

        }
        // Task 1
        public static double Factoriel(double number)
        {
            if(number == 0 || number == 1)
            {
                return 1;
            }
            return number * Factoriel(number - 1);
        }
        // Task 3


        public static int WordCount( string text)
        {
            string textTrim = text.Trim();
            int wordCount = 0, index = 0;

            while (index < textTrim.Length)
            {

                while (index < textTrim.Length && !char.IsWhiteSpace(textTrim[index]))
                    index++;

                 wordCount++;


                while (index < textTrim.Length && char.IsWhiteSpace(textTrim[index]))
                    index++;
            }
            return wordCount;
            
        }

       
    }
}
