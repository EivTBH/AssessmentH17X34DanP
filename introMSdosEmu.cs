public class MSdos
{
    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.Write("Loading MS-DOS...");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(600);
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("Microsoft(R) MS-DOS(R) Version 6.22");
        Console.WriteLine("(C) Copyright Microsoft Corp 1981");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        ;
        Console.BackgroundColor = ConsoleColor.Black;
        Thread.Sleep(500);
        Console.Write("C:\\>");
        Thread.Sleep(1000);
        // Emulate typing
        string input = "H17X33";
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[i]);
            System.Threading.Thread.Sleep(100); // delay between characters
        }
        Console.WriteLine(); // hit return
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error in directory...");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("C:\\>");
        Thread.Sleep(2000);

        // Emulate typing
        string input2 = "H17X34";
        for (int i = 0; i < input2.Length; i++)
        {
            Console.Write(input2[i]);
            System.Threading.Thread.Sleep(100); // delay between characters
        }
        Thread.Sleep(500);
        // Emulate typing
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        string input3 = "Welcome to my Assessment ;)";
        for (int i = 0; i < input3.Length; i++)
        {
            Console.Write(input3[i]);
            Thread.Sleep(100); // delay between characters
        }
        Thread.Sleep(700);
        Console.Clear();

        Console.Clear();
    }
}