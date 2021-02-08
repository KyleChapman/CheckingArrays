// Written by: Kyle Chapman
// with some coaching from NETD 2202-01 W2021.
// Date: Feb 1, 2021
// This is a proof-of-concept related to array indexes to (maybe?) clear up
// some confusion about array indexes in C#.

using System;

namespace CheckingArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creation
            int[, ] integerArray = new int[3, 2];

            // Assignment
            integerArray[0, 0] = 2;
            integerArray[0, 1] = 4;
            integerArray[1, 0] = 6;
            integerArray[1, 1] = 8;
            integerArray[2, 0] = 10;
            integerArray[2, 1] = 12;

            // Loop through the array and output all indexes.
            for(int rowCounter = 0; rowCounter < integerArray.GetLength(0); rowCounter++)
            {
                for (int columnCounter = 0; columnCounter < integerArray.GetLength(1); columnCounter++)
                {
                    Console.WriteLine("Value at [" + rowCounter + ", " + columnCounter + "]: " + integerArray[rowCounter, columnCounter]);
                }
            }

            // A few additional array properties we wanted to check.
            Console.WriteLine("Length of dimension 0: " + integerArray.GetLength(0));
            Console.WriteLine("Length of dimension 1: " + integerArray.GetLength(1));
            Console.WriteLine("Upper bound of dimension 0: " + integerArray.GetUpperBound(0));
            Console.WriteLine("Upper bound of dimension 1: " + integerArray.GetUpperBound(1));

            // This next line is intended to make the program crash.
            // If you wanted to solve it, you could use GetUpperBound() instead of GetLength().
            //Console.WriteLine("Hopefully this crashes: " + integerArray[0, integerArray.GetLength(1)]);

            Console.WriteLine("Length of the entire array: " + integerArray.Length);
        }
    }
}
