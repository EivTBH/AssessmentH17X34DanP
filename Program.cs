using Assessment;

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
            Console.WriteLine("1. Task 1 & 2");
            Col.Cyan("");
            Console.WriteLine("2. Task 3");
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
        int[] imageSizes = new int[] { 99, 1024, 2048, 3072, 4096, 5120, 6144, 7168, 8192, 9216, 10240, 64 };
        ImageAnalyzer analyzer = new ImageAnalyzer(imageSizes); //shortens ImageAnylyzer name

        // Task 1 Display the total sizes in KB of all of the images and the average size in KB.
        // Also counts and displays the total number of images there are on the USB
        // device which are less than 100KB.

        Console.Clear();
        Col.White("");
        Console.WriteLine("---------------------------------------");
        Col.Red("");
        Console.WriteLine("Task 1:");
        Col.White("");
        Console.WriteLine($"Total size of all images: {analyzer.TotalSize()} KB"); // Prints TotalSize from ImageAnalyzer
        Console.WriteLine($"Average size of all images: {analyzer.AverageSize()} KB"); // Prints Average Size from ImageAnalyzer
        Console.WriteLine($"Number of images under 100 KB: {analyzer.NumImagesUnderSize(100)} Files"); // Prints number of files under 100kb from ImageAnalyzer

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
        Console.WriteLine("Task 2 selected.");
        Console.WriteLine("this is task 3");
    }

    private static void Task3()
    {
        Console.WriteLine("Task 3 selected.");
        Console.WriteLine("this is task 4");
    }

}