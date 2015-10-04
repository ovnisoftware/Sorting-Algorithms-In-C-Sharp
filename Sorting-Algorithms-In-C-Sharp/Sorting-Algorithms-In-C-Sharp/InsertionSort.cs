using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_In_C_Sharp
{
    public static class InsertionSort
    {
        //Insertion Sort
        //Builds the final sorted array one item at a time starting on the left with smallest numbers.
        //Good explanation here: https://www.youtube.com/watch?v=I44aUk4vvq0
        //Best case: O(n) (If list is already sorted, it only needs to go through list one time with boolean flag)
        //Average case: O(N^2)
        //Worst case: O(N^2) (Inversely sorted list (Ex. 4,3,2,1))
        public static int[] InsertionSort1(params int[] x)
        {
            for (int i = 1; i < x.Length; i++)
            {
                int index = i;
                while (x[index] < x[index - 1])
                {
                    int temp = x[index];
                    x[index] = x[index - 1];
                    x[index - 1] = temp;
                    index--;
                    if (index == 0)
                        break;
                }
            }
            return x;
        }
        ////Call this in Program.cs to test
        //int [] z = Test.InsertionSort(5, 4, 3, 2, 1);
        //foreach (int y in z)
        //Console.WriteLine(y);
    }
}