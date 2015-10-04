using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_In_C_Sharp
{
    //Sort an array of integers using Bubble Sort and no temp array
    //(highest #'s bubbled to the right)
    //Bubble Sort time complexity
    //Best case: O(n) (If list is already sorted, it only needs to go through list one time, if bool flag added)
    //Average case: O(N^2)
    //Worst case: O(N^2) (Inversely sorted list (Ex. 4,3,2,1))
    //https://www.youtube.com/watch?v=jAoBsroEow4
    public static class BubbleSort
    {
        public static int[] BubbleSort(params int[] input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int k = 0; k < input.Length - 1 - i; k++)
                {
                    if (input[k] > input[k + 1])
                    {
                        int temp = input[k];
                        input[k] = input[k + 1];
                        input[k + 1] = temp;
                    }
                }
            }
            return input;
        }
        ////Call Program.cs to test
        //int[] x = Bubble_Sort.BubbleSort(4, 3, 2, 1);
        //foreach (int y in x)
        //    Console.WriteLine(y);
        ////Output should be:
        ////1
        ////2
        ////3
        ////4
    }
}