using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_In_C_Sharp
{
    //Sort an array of integers using Bubble Sort and no temp array
    //With each pass, bubblesort needs to look at one less item at the far right
    //(highest #'s bubbled to the right)
    //Bubble Sort time complexity
    //Best case: O(n) (If list is already sorted, it only needs to go through list one time, if bool flag added)
    //Average case: O(N^2)
    //Worst case: O(N^2) (Inversely sorted list (Ex. 4,3,2,1))
    //https://www.youtube.com/watch?v=jAoBsroEow4
    public static class BubbleSort
    {
        //No bool flag
        public static int[] Sort1(params int[] input)
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

        //Implement efficient bubblesort with boolean that checks if it's already sorted
        public static int[] Sort2(params int[] input)
        {
            //Flag to check if list is sorted so sort can exit early
            bool sorted = false;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (sorted)
                    return input;
                sorted = true;

                //Bubbles higher numbers to the right
                for (int k = 0; k < input.Length - i - 1; k++)
                {
                    if (input[k] > input[k + 1])
                    {
                        int temp = input[k];
                        input[k] = input[k + 1];
                        input[k + 1] = temp;
                        sorted = false;
                    }
                }
            }
            return input;
        }
        ////Call Program.cs to test
        //int[] x = BubbleSort.Sort2(4, 3, 2, 1);
        //foreach (int y in x)
        //    Console.WriteLine(y);
        ////Output should be:
        ////1
        ////2
        ////3
        ////4
    }
}