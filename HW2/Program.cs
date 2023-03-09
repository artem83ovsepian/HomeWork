namespace MyClasses.HomeWork.HW2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //-- print the sum of two numbers

            var firtstNumber = 1.1M;
            var secondNumber = 1.2M;
            Console.WriteLine($"sum of two numbers: {firtstNumber} + {secondNumber} = {firtstNumber + secondNumber}");
            Console.WriteLine();


            //-- print the result of dividing two numbers

            Console.WriteLine($"result of dividing two numbers: {firtstNumber} / {secondNumber} = {Math.Round((firtstNumber / secondNumber), 4)}");
            Console.WriteLine();


            //-- print the result of the specified operations
            //  1 + 4 * 6
            //  (35 + 5) % 7
            //  14 + -4 * 6 / 11
            //  2 + 15 / 6 * 1 - 7 % 2

            Console.WriteLine($"1 + 4 * 6 = {(1 + (4 * 6))}");
            Console.WriteLine($"(35 + 5) % 7 = {((35 + 5) % 7)}");
            Console.WriteLine($"14 + -4 * 6 / 11 = {(14 + ((-4 * 6) / 11))}");
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {(2 + (15 / (6 * 1)) - (7 % 2))}");
            Console.WriteLine();


            //-- swap two numbers
            //                   Test Data:
            //            Input the First Number : 5
            //                    Input the Second Number : 6
            //                    Expected Output:
            //                    After Swapping :
            //                    First Number : 6
            //                    Second Number : 5

            firtstNumber = ConsoleGetNumber("Input the First Number : ");
            secondNumber = ConsoleGetNumber("Input the Second Number : ");

            Console.WriteLine("Swapping...");

            var swapDecimal = secondNumber;
            secondNumber = firtstNumber;
            firtstNumber = swapDecimal;

            Console.WriteLine($"First Number : {firtstNumber}");
            Console.WriteLine($"Second Number : {secondNumber}");
            Console.WriteLine();


            //-- print the output of multiplication of three numbers which will be entered by the user
            //                   Test Data:
            //            Input the first number to multiply: 2
            //                    Input the second number to multiply: 3
            //                    Input the third number to multiply: 6
            firtstNumber = ConsoleGetNumber("Input the first Number to multiply: ");
            secondNumber = ConsoleGetNumber("Input the second Number to multiply: ");
            var thirdNumber = ConsoleGetNumber("Input the third Number to multiply: ");

            Console.WriteLine($"Multiplaction result {firtstNumber} * {secondNumber} * {thirdNumber} = {firtstNumber * secondNumber * thirdNumber}");
            Console.WriteLine();

        }

        private static decimal ConsoleGetNumber(string userMessage)
        {
            decimal outNumber;

            Console.Write(userMessage);

            while (!Decimal.TryParse(Console.ReadLine(), out outNumber))
                Console.Write("Wrong number. " + userMessage);

            return outNumber;
        }
    }
}
