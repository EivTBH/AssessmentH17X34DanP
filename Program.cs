using Assessment;

/// <summary>
/// This program is used to complete 4 tasks as part of an assessment. This has a menu system which allows the user to select which task they want to run.
/// It is colour coded to keep consistency of features and applies some visual techniques to make sure users know the program is functioning correctly.
///
/// The assigned tasks are as follows:
///
/// Task 1 — Display the total size in KB of all of the images and the average size in KB of all of the images.
/// Also count and display the total number of images there are on the USB device which are less than 100KB.
///
/// Task 2 — Display the size in KB of the largest image.
///
/// Task 3 - Create a program which creates an email address for the student.  This should be comprised of the their first name with a capital first
/// letter and lower case for the rest of the name, a full stop and then the surname in format capital first letter lower case rest of the name@ dundeeandanguscollege.co.uk.
///
/// Task 4 — Sorting times in order of speed - A number of complex calculations are performed on a computer. The time taken for each calculation is kept in milliseconds.
/// You are asked to order the resultant times from fastest to slowest.
/// </summary>
internal class MenuSystem
{
    private static void Main()
    {
        // Hack1.Run();
        // Hack2.Run();
        // Pi.Run();
        // MSdos.Run
       

        while (true)
        {
            Helper.CenterText("Hello and welcome to my 'H17X34' assessment");
            Col.White("");
            string inputMessage = "Please select a Task:";
            for (int i = 0; i < inputMessage.Length; i++)
            {
                Console.Write(inputMessage[i]);
                System.Threading.Thread.Sleep(25); // delay between characters
            }
            Thread.Sleep(200);

            Console.WriteLine("");
            Col.Red("");
            Console.WriteLine("A. Task 1 & 2: File size information.");
            Thread.Sleep(200);
            Col.Cyan("");
            Console.WriteLine("B. Task 3: Create email address.");
            Thread.Sleep(200);
            Col.Green("");
            Console.WriteLine("C. Task 4: Enter and Sort Speed from fastest to slowest in (ms).");
            Thread.Sleep(200);
            Col.Yellow("");
            Console.WriteLine("D. Exit");
            Col.Default("");

            // Read user input
            string userInput = Console.ReadLine();

            // Determine which method to call based on user input
            switch (userInput)
            {
                case "A": //dual case... just in case.
                case "a":
                    Task1();
                    break;

                case "B":
                case "b":
                    Task2();
                    break;

                case "C":
                case "c":
                    Task3();
                    break;

                case "D":
                case "d":
                    // Exit the program
                    return;
                
                case "Easter":
                    Secret();
                    break;

                default:
                    Console.Clear();
                    Col.Red("");
                    Console.WriteLine("Invalid input. Please try again.");
                    Col.Default("");
                    break;
            }
        }
    }
    // Task 1 Display the total sizes in KB of all of the images and the average size in KB.
    // Also counts and displays the total number of images there are on the USB
    // device which are less than 100KB.
    private static void Task1()
    {
        //Assigns numbers to an array
        int[] imageSizes = new int[]
        {
            99,
            1024,
            2048,
            3072,
            4096,
            5120,
            6144,
            7168,
            8192,
            9216,
            10240,
            64
        };
        ImageAnalyzer analyzer = new ImageAnalyzer(imageSizes); //shortens ImageAnylyzer name
        Console.Clear();
        Col.White("");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("The following is a list of values taken from the local drive:");
        Console.WriteLine();
        Col.Red("");
        Console.WriteLine("Task 1:");
        Console.WriteLine();
        Console.WriteLine("USB:");
        Col.White("");
        Console.WriteLine($"Total size of all images: {analyzer.TotalSize()} KB"); // Prints TotalSize from ImageAnalyzer
        Console.WriteLine($"Average size of all images: {analyzer.AverageSize()} KB"); // Prints Average Size from ImageAnalyzer
        Console.WriteLine(
            $"Number of images under 100 KB: {analyzer.NumImagesUnderSize(100)} Files"
        ); // Prints number of files under 100kb from ImageAnalyzer

        // Task 2 - Displays the size in KB of the largest image.

        Console.WriteLine();
        Col.Red("");
        Console.WriteLine("Task 2:");
        Col.White("");
        Console.WriteLine("Size of largest image: " + analyzer.LargestSize() + " KB"); // Prints Largest sized image from ImageAnalyzer
        Console.WriteLine("---------------------------------------");

        Helper.Blinker("");

        Col.Green("");
        Console.WriteLine("Press any key to return to menu.");
        Console.ReadKey();
        Console.Clear();
    }

    /// <summary>
    /// This method takes user input charactarised by a First name and a Last name.
    /// It then creates an email address using the first name and last name.
    /// </summary>
    private static void Task2()
    {
        Console.Clear();
        Col.Cyan("");
        Console.WriteLine("Welcome to the email creation system.");
        Col.White("");
        Console.WriteLine();

        // Create an instance of the EmailShort class and call the Email method
        EmailShort emailShort = new EmailShort();
        string userName = emailShort.Email();

        // Use the returned user name as needed
        Col.Red("");
        Console.WriteLine("---------------------------------------------------");
        Col.White("");
        Console.WriteLine($"The email is: {userName}");
        Col.Red("");
        Console.WriteLine("---------------------------------------------------");
        Col.White("");

        //The Helper.Blinker method is called to give a blinking effect, indicating that the computer is 'thinking' and not crashed. Then the user is prompted to press any key to return to the menu.
        Helper.Blinker("");
        Col.Green("");
        Console.WriteLine("Press any key to return to menu.");
        Console.ReadKey();
        Console.Clear();
    }

    private static void Task3()
    {
        {
            Console.Clear();
            // Prompt the user to enter the number of values
            Col.White("");
            Console.Write("Enter the amount of values you want to sort: ");

            // Read the user's input as a string
            string input = Console.ReadLine();

            // Initialize a variable to store the number of values
            int n;

            // Loop until the user enters a valid integer
            while (!int.TryParse(input, out n))
            {
                // Display an error message and prompt the user to try again
                Col.Red("");
                Console.WriteLine("Invalid input. Please enter a number.");
                Col.White("");
                Console.Write("Please enter the values now: ");
                input = Console.ReadLine();
            }

            // Initialize an array of size n
            int[] arr = new int[n];
            Console.WriteLine();
            Console.WriteLine();
            // Prompt the user to enter the values
            Console.WriteLine("Enter the values:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Value {0}: ", i + 1);

                // Read the user's input as a string
                input = Console.ReadLine();

                // Loop until the user enters a valid integer
                while (!int.TryParse(input, out arr[i]))
                {
                    // Display an error message and prompt the user to try again
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.Write("Value {0}: ", i + 1);
                    input = Console.ReadLine();
                }
            }

            // Create an instance of the SpeedSort class
            SpeedSort speedSort = new SpeedSort();

            // Call the speed method to sort the array
            int[] sortedArr = speedSort.speed(arr);

            // Print the sorted array with "ms" appended to each value
            Console.Clear();
            Col.White("");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Sorted values:");
            Col.Red("");
            for (int i = 0; i < sortedArr.Length; i++)
            {
                Console.Write(sortedArr[i]);
                Console.WriteLine("ms");
            }
            Col.White("");
            Console.WriteLine("---------------------------------------------------");
            Helper.Blinker("");
            Col.Green("");
            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey();
            Thread.Sleep(1000);

            string input3 = "Go on... hit it again, you know you want to.";
            for (int i = 0; i < input3.Length; i++)
            {
                Console.Write(input3[i]);
                Thread.Sleep(100); // delay between characters
            }
            Console.ReadKey();
            Console.Clear();
        }
    }

    private static void Secret()
    {
        Easter.Egg();
    }
}
