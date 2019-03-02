using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.Write("Enter number > 2:");
            int num1 = int.Parse(Console.ReadLine());
            
            for(int i=1; i<=num1; i++)
            {
                if(i%3!= 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            // Task 2
            Console.Write("Enter number > 5:");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num2; i++)
            {
                if (i % 3 != 0 || i%2 != 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            // Task 3
            Console.Write("Enter number:");
            int num3 = int.Parse(Console.ReadLine());
            int length = num3.ToString().Length;
            if(length == 1)
            {
                Console.WriteLine(num3);
            }
            else
            {
                int result = (num3 % 10) * (num3 / 10);
                Console.WriteLine($"Result: {result}");

            }

            // Task 4
            int sum1 = 0;
            Console.Write("Enter number:");
            int num4 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num4; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                else
                {
                    sum1 += i;
                }

           
            }
            Console.WriteLine($"Sum of all even numbers: {sum1}");

            // Task 5
            int sum2 = 0;
            Console.Write("Enter number:");
            int num5 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num5; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    sum2 += i;
                }


            }
            Console.WriteLine($"Sum of all odd numbers: {sum2}");

            // Task 6
            int sum3 = 0;
            Console.Write("Enter number:");
            int num6 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num6; i++)
            {
                if (i % 5 != 0)
                {
                    continue;
                }
                else
                {
                    sum3 += i;
                }
           
            
            }
            Console.WriteLine($"Sum of all numbers that divide 5 is {sum3}");

            // Task 7
            string[] array = { "a", "b", "c", "d" };
            Array.Reverse(array);
            foreach (string element in array)
            {
                Console.WriteLine(element);
            }

            // Task 8
            int[] niza1 = new int[5];
            string[] niza2 = new string[10];

            if (niza1.Length == niza2.Length)
            {
                Console.WriteLine("Arrays are equal!");
            }
            else
            {
                Console.WriteLine("Arrays are not equal!");
            }

            // Task 9
            Console.Write("All numbers in between 1 and 1000, that divide the sum composed of their digits:");
            for( int i= 1; i<=1000; i++)
            {
                int res = (i % 10) + (i / 10);
                if(i%res != 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Task 10
            Console.Write("All numbers in the range [1 : 1000] that divide the product composed of their digits:");
            for (int i = 1; i <= 1000; i++)
            {
                int res = (i % 10) * (i / 10);
                if (res != 0)
                {
                    if (i % res != 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            //Task 11
            Console.Write("Enter number:");
            int num11 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num11; i++)
            {

                if (i.ToString().Length == 2)
                {
                    if ((i % 10) < (i / 10))
                    {
                        Console.WriteLine(i);
                    }

                }
            }

            // Task 12
            Console.Write("Enter number:");
            int num12 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num12; i++)
            {
                if (i > 100)
                {
                    break;
                }
                if(i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i % 3 == 0|| i%5== 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                Console.WriteLine(i);


            }


                Console.ReadLine();
        }

    }
}
