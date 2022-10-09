/*
 * Copyright 2021 The MITRE Corporation. All Rights Reserved.
 */

using System;

namespace CSharpExercises
{
    // Enter the info below, then implement each function so that it passes
    // the unit test. Submit this file when you have completed the assignment.
    // Name: Christina Trinh
    // Date: 2/27/22
    // Class/Program:

    class Exercises
    {
        // Returns an empty array of length n.
        // Works for n >= 0.
        public int[] Exercise1(int n)
        {
            // TODO
            int[] array1 = new int[n];
            return array1;
        }

        // Returns an array containing the first n natural numbers.
        // Hint: the natural numbers are all of the integers in sequence,
        // starting at 1.
        // Works for n >= 0.
        public int[] Exercise2(int n)
        {
            // TODO
            int value = n;
            int[] array2 = new int[n];
            for(int i=n-1; i>=0; i--)
            {
                array2[i] = value;
                value--;
            }
            
            return array2;
        }

        // Returns a 2D string array with n rows and m columns.
        // The value of each element is its "Battleship" coordinates.
        // E.g., the value of the element in the 4th row, 3rd column is "C4".
        // Works for n, m >= 0.
        public string[,] Exercise3(int n, int m)
        {
            // TODO
            string[,] array3= new string[n, m];
            int character = 65;
            for(int i=0; i<=array3.GetUpperBound(0); i++)
            {
                for(int j=0; j<=array3.GetUpperBound(1); j++)
                {
                    string row = (i + 1).ToString();
                    string column = ((char)character).ToString();
                    array3[i, j] = column+row;
                    character++;
                }
                character = 65;
            }
            return array3;
        }

        // Returns the arithmetic mean of array.
        // Returns 0 if array is empty.
        public double Exercise4(int[] array)
        {
            // TODO
            double total = 0.0;
            if (array.Length == 0)
                return 0;
            else
            {
                for(int i=0; i<array.Length; i++)
                {
                    total += array[i];
                }
            }
            return total / array.Length;
        }

        // Returns n factorial (n!).
        // Works for n >= 0.
        public int Exercise5(int n)
        {
            // TODO
            if (n == 0)
                return 1;
            else
            {
                for (int i = n - 1; i >= 1; i--)
                {
                    n *= i;
                }
            }
            return n;
        }

        // Adds a and b, and stores the sum in b without modifying a.
        public void Exercise6(ref int a, ref int b)
        {
            // TODO
            b = a + b;
        }

        // Returns array in reverse order without modifying the original.
        public int[] Exercise7(int[] array)
        {
            // TODO
            int index = 0;
            int[] array_copy = new int[array.Length];
            for(int i=array.Length-1; i>=0; i--)
            {
                array_copy[index] = array[i];
                index++;
            }
            return array_copy;
        }

        // Removes every odd-indexed element from array.
        // E.g., [ 0, 1, 2, 3, 4 ] becomes [ 0, 2, 4 ].
        public void Exercise8(ref int[] array)
        {
            // TODO
            int[] array_copy;
            if (array.Length % 2 != 0)
            {
                array_copy = new int[array.Length / 2 +1];
            }
            else
            {
                array_copy = new int[array.Length / 2];
            }
            int index = 0;
            for(int i=0; i<array.Length; i++)
            {
                if(i%2 ==0)
                {
                    array_copy[index] = array[i];
                    index++;
                }
            }
            array = array_copy;
        }
    }
}
