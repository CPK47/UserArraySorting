using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserArraySorting
{
    public class SortTypes
    {
        protected int[] arr;

        public SortTypes(int[] numberArray)
        {
            arr = numberArray;
        }
        public virtual void SortArray() { }         //Blank Overrideable virtual method for Sorting Arrays

        public virtual void PrintArray()            //Overrideable virtual method for Printing Arrays
        {

            Console.WriteLine($"\n\t   The array looks like this after this run.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t     ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                //Code will start new line once 10 elements of array printed
                if ((i + 1) % 10 == 0) { Console.Write("\n\t\t     "); }
            }
            Console.ResetColor();
            Console.WriteLine("\n\n\t\tPlease press a key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public virtual void PrintArrayFinal()       //Overrideable virtual method to print the final sorted array
        {
            Console.WriteLine("\nThank you for using our Generate and Sort program. Your final sorted array is below.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t    ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                //Code will start new line once 10 elements of array printed
                if ((i + 1) % 10 == 0) { Console.Write("\n\t\t     "); }
            }
            Console.ResetColor();
            Console.WriteLine("\n\n\t\tPlease press a key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
