using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserArraySorting
{
    internal class InsertionSort : SortTypes
    {
        public InsertionSort(int[] numberArray) : base(numberArray) { arr = numberArray; }

        protected override void SortArray()            //Overriding of SortArray() from Parent/base
        {
            Console.Clear();
            //i set to array length -1. Whilst i larger that 0, reduce by 1.
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int index = i;
                //n'th run, while less that i, increase by 1.
                for (int n = 0; n < i; n++)
                {   //if value at array[n] is greater than value to right (arr[n+1])
                    if (arr[n] > arr[n + 1])
                    {   //swap values - new var temp becomes arr[n], arr[n] becomes arr[n+1], arr[n+1] becomes temp
                        int temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;
                    }
                }
                PrintArray();
            }
            PrintArrayFinal();
        }
    }
}
