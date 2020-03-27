using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithDataStructures
{
    class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (int i = 0; i < partIndex; i++)
                {
                    if(array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                //set index of largest element to zero.
                int largestAt = 0;

                for (int i = 1; i <= partIndex; i++)
                {
                    if(array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }
                }
                Swap(array, largestAt, partIndex);
            }
        }
        private static void Swap(int[] array, int i, int j)
        {
            if(i == j)
            {
                return;
            }
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
