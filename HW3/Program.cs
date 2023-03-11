using System.ComponentModel;

namespace MyClasses.HomeWork.HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to check two given integers and return true if one is negative and one is positive.
            //           Sample Output:
            //            Input first integer:
            //            -5
            //           Input second integer:
            //            25
            //           Check if one is negative and one is positive:
            //           True
            while (true)
            {
                StartNewTask(1);

                var firtstInt = ConsoleGetNumber("Input first integer: ");
                var secondInt = ConsoleGetNumber("Input second integer: ");
                Console.WriteLine("Check if one is negative and one is positive:");
                Console.WriteLine((firtstInt * secondInt) < 0);

                if (IsEnterInputed()) { break; }
            }

            //- Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            while (true)
            {
                StartNewTask(2);

                var firtstInt = ConsoleGetNumber("Input first integer: ");
                var secondInt = ConsoleGetNumber("Input second integer: ");
                Console.WriteLine("Check if one of the integer is 20 or if their sum is 20:");
                Console.WriteLine((firtstInt == 20) || (secondInt == 20) || ((firtstInt + secondInt) == 20));

                if (IsEnterInputed()) { break; }
            }

            //-Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            while (true)
            {
                StartNewTask(3);

                for (int i = 1; i < 99; i++)
                {
                    if (i % 2 == 0) { Console.WriteLine(i); }

                }

                if (IsEnterInputed()) { break; }
            }

            //-Write a C# program to compute the sum of the first 500 prime numbers.
            //             Sample Output:
            //             Sum of the first 500 prime numbers:
            //             824693
            while (true)
            {
                StartNewTask(4);

                var arraySize = 500;
                var primeSum = 0;

                for (int n = 1; n <= arraySize; n++)
                {
                    int j = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0) { j++; }
                    }
                    if (j == 2) { primeSum += n; }
                }

                Console.WriteLine($"Sum of the first {arraySize} prime numbers:");
                Console.WriteLine(primeSum);

                if (IsEnterInputed()) { break; }
            }

            //-Write a C# program and compute the sum of the digits of an integer.
            //             Sample Output:
            //             Input a number(integer): 12(string.Length)
            //             Sum of the digits of the said integer: 3
            while (true)
            {
                StartNewTask(5);

                var num = ConsoleGetNumber("Input a number(integer): ");
                var arraySum = num.ToString().Select(o => int.Parse(o.ToString())).ToArray().Sum();
                Console.WriteLine($"Sum of the digits of the said integer: {arraySum}");

                if (IsEnterInputed()) { break; }
            }
        }
        private static int ConsoleGetNumber(string userMessage)
        {
            int outNumber;

            Console.WriteLine(userMessage);

            while (!int.TryParse(Console.ReadLine(), out outNumber))
                Console.WriteLine("Wrong number. " + userMessage);

            return outNumber;
        }
        private static void StartNewTask(int taskNum)
        {
            Console.Clear();
            Console.WriteLine($"HW3. Task #{taskNum}");
        }

        private static bool IsEnterInputed()
        {
            Console.WriteLine("\nPress <Enter> to go to Next Task.");
            Console.WriteLine("Press <Any Key> to Repeat.");
            var readkey = Console.ReadKey();
            return (readkey.Key == ConsoleKey.Enter);
        }

    }
}