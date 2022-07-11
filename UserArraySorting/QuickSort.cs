using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserArraySorting
{
    class QuickSort : SortTypes
    {
        public QuickSort(int[] numberArray) : base(numberArray) { arr = numberArray; }

        public override void SortArray()
        {
            Console.Clear();
            PrintArrayFinal(quickSort(arr, 0, arr.Length - 1));
            int[] quickSort(int[] array, int low, int high)
            {
                if (low < high)
                {
                    int pivotIndex = partition(array, low, high);

                    quickSort(array, low, pivotIndex - 1);
                    quickSort(array, pivotIndex + 1, high);
                }
                PrintArray(array);
                return array;
            }
            int partition(int[] array, int low, int high)
            {
                int pivot = array[high];
                int store = low;
                for (int i = low; i <= high; i++)
                {
                    if (array[i].CompareTo(pivot) < 0)
                    {
                        int temp = array[i];
                        array[i] = array[store];
                        array[store] = temp;
                        store++;
                    }
                }
                int temp2 = array[store];
                array[store] = array[high];
                array[high] = temp2;
                return store;
            }
        }
        protected override void PrintArrayFinal(int[] array)
        {
            Console.WriteLine("\nThank you for using our Generate and Sort program. Your final sorted array is below.");
            Console.WriteLine("\t\t\tFor this array you used Quick Sort.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t\t   ");
            for (int i = 0; i < array.Length; i++)
            {
                //If array integer is less that 10, a space will be entered before the number to evenly space it
                if (array[i] < 10)
                { Console.Write(" " + array[i] + " "); }
                else
                { Console.Write(array[i] + " "); }
                //Code will start new line once 10 elements of array printed
                if ((i + 1) % 10 == 0) { Console.Write("\n\t\t\t   "); }
            }
            Console.ResetColor();
            Console.WriteLine("\n\n\t\t\t   Please press a key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        protected override void PrintArray(int[] array)
        {
            Console.WriteLine($"\n\t   The array is now being sorted...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t   ");
            for (int i = 0; i < array.Length; i++)
            {
                //If array integer is less that 10, a space will be entered before the number to evenly space it
                if (array[i] < 10)
                { Console.Write(" " + array[i] + " "); }
                else
                { Console.Write(array[i] + " "); }
                //Code will start new line once 10 elements of array printed
                if ((i + 1) % 10 == 0) { Console.Write("\n\t   "); }
            }
            Console.ResetColor();
            Console.WriteLine("\n\n\t\tSort will continue...");

            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}

