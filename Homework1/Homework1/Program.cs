using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("What is behind door number:1,2,3");
            int caseSwitch = int.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("You got a new car!");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane!");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            // Task 2
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the fourth number");
            int d = int.Parse(Console.ReadLine());

            int result = (a + b + c + d) / 4;
            Console.WriteLine($"The average of {a}, {b}, {c} and {d} is: {result}");

            // Bonus
            Console.WriteLine("Enter temperature:");
            int temp = int.Parse(Console.ReadLine());

            if (temp < 0)
            {
                Console.WriteLine("Freezing weather!");
            }
            if (temp >= 0 && temp < 10)
            {
                Console.WriteLine("Very Cold weather!");
            }
            if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("Cold weather!");
            }
            if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("Normal in Temp!");
            }
            if (temp >= 30 && temp < 40)
            {
                Console.WriteLine("It's Hot!");
            }
            else
            {
                Console.WriteLine("It's very Hot!");
            }


            Console.ReadLine();
        }
    }
}
