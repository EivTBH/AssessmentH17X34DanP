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
        while (true)
        {
            Helper.CenterText($"Hello and welcome to my 'H17X34' assessment");

            Col.White("");
            Console.WriteLine("Please select a Task:");
            Col.Red("");
            Console.WriteLine("1. Task 1 & 2: File size information.");
            Col.Cyan("");
            Console.WriteLine("2. Task 3: Create email address.");
            Col.Green("");
            Console.WriteLine("3. Task 4");
            Col.Yellow("");
            Console.WriteLine("4. Exit");
            Col.Default("");

            // Read user input
            string input = Console.ReadLine();

            // Determine which method to call based on user input
            switch (input)
            {
                case "1":
                    Task1();
                    break;

                case "2":
                    Task2();
                    break;

                case "3":
                    Task3();
                    break;

                case "4":
                    // Exit the program
                    return;

                default:
                    Console.Clear();
                    Col.Red("");
                    Console.WriteLine("Invalid input. Please try again.");
                    Col.Default("");
                    break;
            }
        }
    }

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

        // Task 1 Display the total sizes in KB of all of the images and the average size in KB.
        // Also counts and displays the total number of images there are on the USB
        // device which are less than 100KB.

        Console.Clear();
        Col.White("");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("The following is a list of values taken from the local drive:");
        Console.WriteLine();
        Col.Red("");
        Console.WriteLine("Task 1:");
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

    private static void Task2()
    {
        Console.Clear();
        Col.Cyan("");
        Console.WriteLine("Welcome to the email creation system. Please enter your name.");
        Console.WriteLine();


        // Create an instance of the EmailShort class and call the Email method
        EmailShort emailShort = new EmailShort();
        string userName = emailShort.Email();

        // Use the returned user name as needed
        Console.WriteLine($"The email is: {userName}");
        Helper.Blinker("");
        Col.Green("");
        Console.WriteLine("Press any key to return to menu.");
        Console.ReadKey();
        Console.Clear();
    }

    private static void Task3()
    {
        Console.WriteLine("Task 3 selected.");
        Console.WriteLine("this is task 4");
    }
}
