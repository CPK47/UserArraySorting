namespace UserArraySorting
{
    class Program
    {

        static void Main(string[] args)
        {
            // Bool and While statement to continually run program until exited by bool being false
            bool play = true;
            while (play)
            {
                //Call Welcome Function
                Welcome();
                //Int size is output of ArraySize function
                int size = ArraySize();
                //Array createdArray is output of CreateArray function
                int[] createdArray = CreateArray();
                //User chooses what sort to use on array
                WhatSort();
                //Constructor
                SortTypes sorter;
                sorter.SortArray();
                //User asked would they like to do another array sort
                Again();
                
                
                //Int sortType is output of WhatSort function
                int sortType;

                void Welcome()          //Welcome function
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t  Welcome to CPK's Array Creator and Sorter!\t\t");
                    Console.WriteLine("\n\n");
                    Console.ResetColor();
                }
                int ArraySize()         //Function for setting of size integer for Array
                {
                    //Try Catch for errors in user input
                    try
                    {
                        Console.WriteLine("Please enter the size of Array you would like to create (eg. 10, 100, 1000): ");
                        // int size is equal to user input Parsed from string into an int
                        size = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    catch
                    { Error(); ArraySize(); }
                    return size;
                }
                int[] CreateArray()     // Create the array using the size given in ArraySize()
                {
                    Console.Clear();
                    createdArray = new int[size];
                    //Creation of array using desired size and random integers
                    Random random = new Random();
                    //Array is  filled with random integers between 0 and array length
                    for (int i = 0; i < createdArray.Length - 1; i++) { createdArray[i] = random.Next(0, createdArray.Length - 1); }
                    //Print array to show array contains integers
                    Console.WriteLine($"\n\tYour array is printed in its created order here: \n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintArray();
                    Console.ResetColor();
                    Console.Clear();
                    return createdArray;
                }
                void WhatSort()          // User input for type of sort to use by choosing the number
                {
                    // Try Catch to test user input is valid
                    try
                    {
                        Console.WriteLine("\n\nPlease enter the array type you would like to select: \n\n");
                        Console.WriteLine("\t\t\t1. Bubble Sort\n");
                        Console.WriteLine("\t\t\t2. Selection Sort\n");
                        Console.WriteLine("\t\t\t3. Insertion Sort\n");
                        Console.WriteLine("\t\t\t4. Merge Sort\n");
                        Console.WriteLine("\t\t\t5. Quick Sort\n\n");
                        sortType = int.Parse(Console.ReadLine());
                    
                        switch (sortType)
                        {
                            case 1: sorter = new BubbleSort(createdArray); break;
                            case 2: sorter = new SelectionSort(createdArray); break;
                            case 3: sorter = new InsertionSort(createdArray); break;
                            case 4: sorter = new MergeSort(createdArray); break;
                            case 5: sorter = new QuickSort(createdArray); break;
                            default: ; Error(); WhatSort(); break;
                        }
                    }
                    catch { Error(); WhatSort(); }
                }
                void PrintArray()       //Function to print array
                {
                    Console.Write("\t\t");
                    for (int i = 0; i < createdArray.Length; i++)
                    {
                        //If array integer is less that 10, a space will be entered before the number to evenly space it
                        if (createdArray[i] < 10)
                        { Console.Write(" " + createdArray[i] + " "); }
                        else
                        { Console.Write(createdArray[i] + " "); }
                        //If statement - if i + 1 is divisible by 10 with no remainder.
                        //Write newline for next 10 integers of array.
                        if ((i + 1) % 10 == 0) { Console.Write("\n\t\t"); }
                    }
                    Console.ResetColor();
                    Console.WriteLine("\n\n\t\tPlease press a key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }

                void Again()            //Function to ask user whether to create and sort another array
                {
                    //Try Catch to check user input valid
                    try
                    {
                        Console.WriteLine("Would you like to run the array generator and sorter again? Y / N ");
                        string answer = Console.ReadLine();
                        answer = answer.ToUpper();
                        if (answer == "Y") { Console.Clear(); }
                        else if (answer == "N") { Console.Clear(); play = false; Goodbye(); }
                        else { Error(); Again(); }
                    }
                    catch
                    { Error(); Again(); }
                }
                void Goodbye()              //Function to say goodbye to user and end the program
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\tThank you for using CPK's Array Creator and Sorter!\n");
                    Console.ResetColor();
                    Console.WriteLine("\t\t\tPress any key to end the program.");
                    Console.ReadKey();
                }
                void Error()                //Function to standardise error messages for invalid input from user.
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n\t\t\tERROR!\n\n");
                    Console.WriteLine($"    Invalid input detected. Press a key to try again.");
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();
                }
            }
        }
    }
}


