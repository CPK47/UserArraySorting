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
                //Constructors
                SortTypes sorter = new SortTypes(createdArray);
                BubbleSort bubble = new BubbleSort(createdArray);
                SelectionSort selection = new SelectionSort(createdArray);
                InsertionSort insertion = new InsertionSort(createdArray);
                //Int sortType is output of WhatSort function
                int sortType = WhatSort();

                void Welcome()          //Welcome function
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t  Welcome to CPK's Sort-tacular Array Creator and Sorter!\t\t");
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
                    {
                        Error(); 
                        ArraySize();
                    }
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
                int WhatSort()          // User input for type of sort to use by choosing the number
                {
                    // Try Catch to test user input is valid
                    try
                    {
                        Console.WriteLine("\n\nPlease enter the array type you would like to select: \n\n");
                        Console.WriteLine("\t\t\t1. Bubble Sort\n");
                        Console.WriteLine("\t\t\t2. Selection Sort\n");
                        Console.WriteLine("\t\t\t3. Insertion Sort\n\n");
                        sortType = int.Parse(Console.ReadLine());
                    }
                    catch { Error(); WhatSort(); }
                        //If statement, checking if sortType is within the range 1 - 3
                        if (Enumerable.Range(1, 3).Contains(sortType))
                        {
                            if (sortType == 1) { bubble.SortArray(); Again(); }
                            else if (sortType == 2) { selection.SortArray(); Again(); }
                            else if (sortType == 3) { insertion.SortArray(); Again(); }
                        }
                        else { Error(); WhatSort(); }
                    
                    return sortType;
                }
                void PrintArray()       //Function to print array
                {   
                    Console.Write("\t\t     ");
                    for (int i = 0; i < createdArray.Length; i++)
                    {
                        Console.Write(createdArray[i] + " ");
                        //If statement - if i + 1 is divisible by 10 with no remainder.
                        //Write newline for next 10 integers of array.
                        if ((i + 1) % 10 == 0) { Console.Write("\n\t\t     "); }
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
                        play = true;
                        Console.WriteLine("Would you like to run the array generator and sorter again? Y / N ");
                        string answer = Console.ReadLine();
                        answer = answer.ToUpper();
                        if (answer == "Y") { Console.Clear(); }
                        else if (answer == "N") { Console.Clear(); play = false; }
                        else { Error(); Again(); }
                    }
                    catch
                    {
                        Error();
                        Again();
                    }
                }
            }
            //When while loop exits, this next function will be called.
            Goodbye();
            void Goodbye()              //Function to say goodbye to user and end the program
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\tThank you for using CPK's Array Generator and Sorter!\n");
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