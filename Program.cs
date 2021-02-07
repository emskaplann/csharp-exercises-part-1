using System;

namespace csharp_exercises_part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World
            Console.WriteLine("Hello World");

            // Single Line Comment
            /*
             * Multi-line comment
             * Example second line
             * Nice!
             */

            // Variables
            //bool exampleBool = true;
            //int myNumber = 31;
            //double myDouble = 13.0;
            //char myChar = 'a';
            //string myString = "Hello World!";

            // Min / Max Values
            int maxValue = int.MaxValue;

            // Implicit types
            var exampleBool = true;
            var myNumber = 31;
            var myDouble = 13.0;
            var myChar = 'a';
            var myString = "Hello, World!";

            // Operators
            int x = 3;
            int y = 5;
            int z1 = x++; // Increment after the variable returns the updated value to the left-hand.
            int z2 = ++y; // Increment before the variable returns the unupdated value to the left-hand.

            int a = z1 / z2;
            int b = z1 + x;

            bool myBool = x % 2 == 0;

            // Type conversions
            double newA = a;
            int secondA = (int)newA;

            int myStringLength = myString.Length;

            /*
             * Indexing Strings
             * When we try to combine first, middle and the last char from a string,
             * we need to keep in mind that first char is not a string type and it will throw an error,
             * since we are trying to add new chars to a char.
             * To fix this problem, we can simply convert the leading char to a string.
             * So that, we can add new chars to a string.
             */
            string firstMiddleAndLastChar = myString[0].ToString() + myString[myStringLength / 2] + myString[myStringLength - 1];
            char middleChar = myString[myStringLength / 2];

            // Getting parts of strings
            string exampleString = "Emirhan Melik Sencer Kaplan";
            //exampleString = exampleString.Remove(0, 1);
            exampleString = exampleString.TrimStart(exampleString[0]);
            //exampleString = exampleString.Remove(exampleString.Length - 1);
            exampleString = exampleString.TrimEnd(exampleString[exampleString.Length - 1]);
            Console.WriteLine(exampleString);

            // Searching strings
            string filePath = @"c:\foo\bar.txt";
            int indexOfLastSlash = filePath.LastIndexOf('\\');
            string fileName = filePath.Remove(0, indexOfLastSlash + 1);
            Console.WriteLine("file name: " + fileName);

            char driveLetter = Char.ToUpper(filePath[0]);
            Console.WriteLine(driveLetter);

            // Structs & Enums
            CustomStruct mySelf = new CustomStruct();
            mySelf.legalFirstName = "Emirhan";
            mySelf.legalLastName = "Kaplan";
            mySelf.age = 20;
            mySelf.birthday = WeekOfDay.Saturday;
        }

        /// <summary>
        /// This functions prints "Hello World!" phrase in the console.
        /// </summary>
        /// <returns></returns>
        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
