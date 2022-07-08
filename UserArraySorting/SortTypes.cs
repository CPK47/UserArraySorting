using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserArraySorting
{
    public abstract class SortTypes
    {
        protected int[] arr;

        protected SortTypes(int[] numberArray)
        {
            arr = numberArray;
        }
        protected abstract void SortArray();         //Blank Overrideable abstract method for Sorting Arrays

        protected void PrintArray()            //Overrideable virtual method for Printing Arrays
        {

            Console.WriteLine($"\n\t   The array is now being sorted...");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t   ");
            for (int i = 0; i < arr.Length; i++)
            {
                //If array integer is less that 10, a space will be entered before the number to evenly space it
                if (arr[i] < 10)
                { Console.Write(" " + arr[i] + " "); }
                else
                { Console.Write(arr[i] + " "); }
                //Code will start new line once 10 elements of array printed
                if ((i + 1) % 10 == 0) { Console.Write("\n\t   "); }
            }
            Console.ResetColor();
            Console.WriteLine("\n\n\t\tSort will continue...");
            
            Thread.Sleep(1000);
            Console.Clear();
        }
        protected void PrintArrayFinal()       //Overrideable virtual method to print the final sorted array
        {
            Console.WriteLine("\nThank you for using our Generate and Sort program. Your final sorted array is below.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t\t\t   ");
            for (int i = 0; i < arr.Length; i++)
            {
                //If array integer is less that 10, a space will be entered before the number to evenly space it
                if (arr[i] < 10)
                { Console.Write(" " + arr[i] + " "); }
                else
                { Console.Write(arr[i] + " "); }
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
