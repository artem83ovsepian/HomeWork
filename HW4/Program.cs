using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace MyClasses.HomeWork.HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var int1 = 9;
            var int2 = 6;
            var int3 = -2;

            //-Write a C# method to find the largest value from three integer values.
            Console.WriteLine($"the largest value from three integer ({int1},{int2},{int3}): {LargestIntGet(int1, int2, int3)}");

            //-Write a C# method to find the lowest value from three integer values.
            Console.WriteLine($"the lowest value from three integer ({int1},{int2},{int3}): {LowestIntGet(int1, int2, int3)}");

            //-Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
            //           Test Data:
            //            Input first integer:
            //            15
            //           Input second integer:
            //            12
            //          Sample Output
            //          15
            var firtstInt = ConsoleGetNumber("Input first integer: ");
            var secondInt = ConsoleGetNumber("Input second integer: ");
            Console.WriteLine($"the nearest value of 20: {Nearest20IntGet(firtstInt, secondInt)}");

            
            int[] myArray = new int[] {1, 0, -2, 5, -5};
            Console.WriteLine($"array of integers: [{string.Join(",", myArray)}]");

            //- Write a C# method to compute the sum of all the elements of an array of integers
            Console.WriteLine($"sum of all the elements: {ArraySumGet(myArray)}");

            //-Write a C# method to get the larger value from array
            Console.WriteLine($"the larger value: {ArrayMaxGet(myArray)}");

        }

        private static int LargestIntGet(int varInt1, int varInt2, int varInt3)
        {
            var largestInt = new int();
            int[] intArray = new int[] {varInt1, varInt2, varInt3};
            foreach (int i in intArray)
            {
                if (largestInt < i) { largestInt = i; }
            }
            return largestInt;
        }
        
        private static int LowestIntGet(int varInt1, int varInt2, int varInt3)
        {
            var lowestInt = new int();
            int[] intArray = new int[] { varInt1, varInt2, varInt3 };
            foreach (int i in intArray)
            {
                if (lowestInt > i) { lowestInt = i; }
            }
            return lowestInt;
        }

        private static int Nearest20IntGet(int varInt1, int varInt2)
        {
            if (varInt1 == varInt2) 
            {
                return 0; 
            }
            else 
            {
                if (Math.Abs(20 - varInt1) < Math.Abs(20 - varInt2)) 
                {
                    return varInt1; 
                }
                else 
                {
                    return varInt2; 
                }
            }
        }

        private static int ArraySumGet(int[] inArray)
        {
            var arraySum = inArray[0];

            foreach (int i in inArray)
            {
                arraySum += i;
            }
            return arraySum;
        }
        
        private static int ArrayMaxGet(int[] inArray)
        {
            var arrayMax = inArray[0];

            foreach (int i in inArray)
            {
                if (arrayMax < i)
                {
                    arrayMax = i;
                };
            }
            return arrayMax;
        }


        private static int ConsoleGetNumber(string userMessage)
        {
            int outNumber;

            Console.WriteLine(userMessage);

            while (!int.TryParse(Console.ReadLine(), out outNumber))
                Console.WriteLine("Wrong number. " + userMessage);

            return outNumber;
        }
    }
}