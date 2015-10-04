using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_In_C_Sharp
{
    public static class SelectionSort
    {
        //Selection Sort
        //Write a program that traverses an array of integers, identifies the smallest integer
        //and swaps it with the element at the far left in the zero index position.
        //The program then will traverse the remainder of the array
        //(excluding the first position which is already sorted) and repeat the process
        //Selection Sort time complexity
        //Best case: O(n^2)
        //Average case: O(N^2)
        //Worst case: O(N^2)
        //https://www.youtube.com/watch?v=MZ-ZeQnUL1Q
        public static int[] SelectionSort1(params int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                int minPos = i;
                for (int k = i + 1; k < input.Length; k++)
                {
                    if (input[minPos] > input[k])
                        minPos = k;
                }
                //Smallest elements in the array are swapped with the elements to the farthest left
                if (i != minPos)
                {
                    int temp = input[i];
                    input[i] = input[minPos];
                    input[minPos] = temp;
                }
            }
            return input;
        }
        ////Call Program.cs to test
        //int[] x = Selection_Sort.SelectionSort(4,3,2,1);
        //foreach (int y in x)
        //    Console.WriteLine(y);
        ////Output should be:
        ////1
        ////2
        ////3
        ////4
    }
}