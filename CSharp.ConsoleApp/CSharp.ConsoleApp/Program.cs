namespace CSharp.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args);
            Console.Title = "C SHARP IS AMAZING";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Hello, World!\n");
            Console.WriteLine("this is new line");

            // you have to wirte a value to the varible.
            string sentenceToPrint = "welcome form the string variable";
            Console.WriteLine(sentenceToPrint);

            char letter = 'a';
            Console.WriteLine(letter);

            int old = 21;
            Console.WriteLine(old);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = 90000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float percision = 5.000001F;
            Console.WriteLine(percision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            bool isMale = true;
            Console.WriteLine(isMale);
            isMale = false;
            Console.WriteLine(isMale);

            // string to integer
            string convTo32 = "10";
            int converted32 = Convert.ToInt32(convTo32);
            Console.WriteLine(converted32);

            string convTo64 = "46464646464646";
            long converted64 = Convert.ToInt64(convTo64);
            Console.WriteLine(converted64);

            string textPersition = "5.000001";
            float convertedFloat = Convert.ToSingle(textPersition);
            Console.WriteLine(convertedFloat);

            string textDouble = "5.0000001";
            double convertedDouble = Convert.ToDouble(textDouble);
            Console.WriteLine(convertedDouble);

            string textDecimal = "14.99";
            decimal convertedDecimal = Convert.ToDecimal(textDecimal);
            Console.WriteLine(convertedDecimal);
            Console.WriteLine("14.99");


            // string concatination and number operations
            int a = 0;
            // postincrement
            Console.WriteLine(a++); ;
            // preincrement
            Console.WriteLine(++a); ;
            a = a + 10;
            a += 10;
            Console.WriteLine(a);

            // it is the same like js you can use + - * / 

            // you can not subtract a text or multiply it just + for concatination
            string text = "concat";
            text += "ination";
            Console.WriteLine(text);

            // when we concat two chars we get the sum of there hex code or ascii code don't remember exactly
            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            // we also have the modulas %
            Console.WriteLine(99%10);
            Console.WriteLine(98 % 2);

            // var keyword it seems like typeless 

            var number = "0112548754";
            Console.WriteLine(number);

            // const
            const string email = "gabr22065@gamil.com";
            Console.WriteLine(email);

            // read input from the user and store it in a variable to use it later
            Console.Write("enter your name: ");
            string name = Console.ReadLine();

            Console.Write("enter your age: ");
            string ageInput = Console.ReadLine();

            int age = Convert.ToInt32(ageInput);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + ++age );

            Console.ReadLine();
        }
    }
}
