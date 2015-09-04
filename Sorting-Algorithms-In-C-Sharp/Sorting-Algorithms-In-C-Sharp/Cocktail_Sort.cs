using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_In_C_Sharp
{
    public static class Cocktail_Sort
    {
        //Implement Cocktail Sort (Smallest on left, largest on right)
        //Best case: O(n) (If list is already sorted, it only needs to go through list one time) (with boolean flag)
        //Average case: O(N^2)
        //Worst case: O(N^2) (Inversely sorted list (Ex. 4,3,2,1))
        //Explanation: https://www.youtube.com/watch?v=Xmx_6YRBaq8
        public static int[] CocktailSort(params int[] x)
        {
            for (int i = 0; i < x.Length / 2; i++)
            {
                for (int k = i; k < x.Length - 1 - i; k++)
                {
                    if (x[k] > x[k + 1])
                    {
                        int temp = x[k];
                        x[k] = x[k + 1];
                        x[k + 1] = temp;
                    }
                }
                for (int j = x.Length - 2 - i; j > 0; j--)
                {
                    if (x[j] < x[j - 1])
                    {
                        int temp = x[j];
                        x[j] = x[j - 1];
                        x[j - 1] = temp;
                    }
                }
            }
            return x;
        }
        ////Call Program.cs to test
        //int[] x = Cocktail_Sort.CocktailSort(5, 4, 3, 2, 1);
        //foreach (int y in x)
        //    Console.WriteLine(y);
        ////Output should be:
        ////1
        ////2
        ////3
        ////4
        ////5
    }
}