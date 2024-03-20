using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // while and if and do while and swithch
            Console.Write("write the number of the day: ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Friday");
                    break;
                case 2:
                    Console.WriteLine("saterday");
                    break;
                case 3:
                    Console.WriteLine("monday");
                    break;
                case 4:
                    Console.WriteLine("tusday");
                    break;
                default: Console.WriteLine("invalid number");
                    break;
            }



                Console.Write("What do you wanna repeat: ");
                string repeatedText = Console.ReadLine();

                Console.Write($"How many times you want to say {repeatedText}: ");
                int times = Convert.ToInt32(Console.ReadLine());


                if (times <= 0)
                {
                    Console.WriteLine("write a number above 0");
                }
                else
                {
                    for (int i = 0; i < times; ++i)
                    {
                        Console.WriteLine(repeatedText);
                    }
                }




                do
                {
                    Console.WriteLine(times);
                    times++;
                } while (times < 10);



                int myAge = 10;
                // ternary if 
                string result = myAge >= 0 ? "valid" : "invalid";
                Console.WriteLine(result);


            // Numeric Formating

            double value = 10D / 3D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.00}", value));
            Console.WriteLine(string.Format("{0} {1}", value , "100"));
            Console.WriteLine(string.Format("{0:0.#}", value)); // if the number is zero will remove it but if 1 will remain
            Console.WriteLine(value.ToString("C0" ,CultureInfo.CreateSpecificCulture("en-US")));

            Console.WriteLine();

            bool success;
            do
            {
                Console.Write("Create a id number: ");
                string inputUserNumber = Console.ReadLine();
                success = int.TryParse(inputUserNumber, out int number);
                    if (success)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;
                        success = true;
                        Console.WriteLine($"welcome here is your id:{number}");
                    }
                    else
                    {
                        Console.WriteLine("invalid number");
                        Console.WriteLine();
                    }
            } while (success != true);

            //string shit = Console.ReadLine();
            //Console.WriteLine(Convert.ToInt32(shit));

            // you can insert @ before the text to escape all the escape charchters but the quote you should use double double quote;
            string path = @"C:\usr""\""sharing\info";
            Console.WriteLine(path);
            Console.ReadLine();
        }

    }
}
