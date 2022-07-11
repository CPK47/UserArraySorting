using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserArraySorting
{
    class MergeSort : SortTypes
    {
        public MergeSort(int[] numberArray) : base(numberArray) { arr = numberArray; }
        
        public override void SortArray()
        {
            Console.Clear();
            int[] result = mergeSort(arr);
            PrintArrayFinal(result);


            int[] mergeSort(int[] array)
            {
                int[] lower;
                int[] upper;
                int[] result = new int[array.Length];
                int arrayMidPoint = array.Length / 2;
                if (array.Length < 2) { return array; }
                lower = new int[arrayMidPoint];
                if (array.Length % 2 == 0)
                {
                    upper = new int[arrayMidPoint];
                }
                else
                {
                    upper = new int[arrayMidPoint + 1];
                }
                for (int i = 0; i < arrayMidPoint; i++)
                {
                    lower[i] = array[i];
                }
                int x = 0;
                for (int i = arrayMidPoint; i < array.Length; i++)
                {
                    upper[x] = array[i];
                    x++;
                }
                lower = mergeSort(lower);
                upper = mergeSort(upper);
                result = Merge(lower, upper);
                return result;
            }
            int[] Merge(int[] lower, int[] upper)
            {
                int resultLength = upper.Length + lower.Length;
                int[] result = new int[resultLength];
                int indexLower = 0, indexUpper = 0, indexResult = 0;
                while (indexLower < lower.Length || indexUpper < upper.Length)
                {
                    if (indexLower < lower.Length && indexUpper < upper.Length)
                    {
                        if (lower[indexLower] <= upper[indexUpper])
                        {
                            result[indexResult] = lower[indexLower];
                            indexLower++;
                            indexResult++;
                        }
                        else
                        {
                            result[indexResult] = upper[indexUpper];
                            indexUpper++;
                            indexResult++;
                        }
                    }
                    else if (indexLower < lower.Length)
                    {
                        result[indexResult] = lower[indexLower];
                        indexLower++;
                        indexResult++;
                    }
                    else if (indexUpper < upper.Length)
                    {
                        result[indexResult] = upper[indexUpper];
                        indexUpper++;
                        indexResult++;
                    }
                }
                return result;
            }
        }
        protected override void PrintArrayFinal(int[] array)
        {
            Console.WriteLine("\nThank you for using our Generate and Sort program. Your final sorted array is below.");
            Console.WriteLine("\t\t\tFor this array you used Merge Sort.\n");
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
    }       
}

