using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserArraySorting
{
    class BubbleSort : SortTypes
    {
        public BubbleSort(int[] numberArray) : base(numberArray) { arr = numberArray; }
        
        protected override void SortArray()
        {
            Console.Clear();
            //where 'i' is location of i'th unsorted element
            for (int i = arr.Length - 1; i > 0; i--)
            {
                //where 'n' is next element
                for (int n = 0; n < i; n++)
                {
                    //if element 'n' is greater than 'n + 1' then swap elements
                    if (arr[n] > arr[n + 1])
                    {
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
