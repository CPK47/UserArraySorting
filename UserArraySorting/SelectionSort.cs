using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserArraySorting
{
    internal class SelectionSort : SortTypes
    {
        public SelectionSort(int[] numberArray) : base(numberArray) { arr = numberArray; }

        protected override void SortArray()        //Overriding of SortArray() from Parent/base
        {
            Console.Clear();
            // i is Array length. While i is greater than 0. i decreases.
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int index = i;
                for (int n = 0; n < i; n++)
                {   //if array index n is greater than array index index. Change index to n.
                    if (arr[n].CompareTo(arr[index]) > 0)
                    {
                        index = n;
                    }
                }
                //Swap values. New temp becomes arr[index]. arr[index] becomes arr[i]. arr[i] becomes temp.
                int temp = arr[index];
                arr[index] = arr[i];
                arr[i] = temp;
                PrintArray();
            }
            PrintArrayFinal();
        }
    }
}
