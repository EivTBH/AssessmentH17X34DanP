using System;
/// <summary>
/// Emulates the boot sequence of a Raspberry Pi.
/// </summary>
public class Pi
{
    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();

        Console.WriteLine("Welcome to Raspberry Pi");
        Console.WriteLine();
        Console.Write("Starting file system...");
        System.Threading.Thread.Sleep(1000);
        Console.Write("done.\n");
        Console.WriteLine();

        Console.Write("Scanning for storage devices...");
        System.Threading.Thread.Sleep(1000);
        Console.Write("done.\n");
        Console.WriteLine();

        Console.WriteLine("Mounted file systems:");
        Console.WriteLine("    /dev/sda1  120GB  FAT32");
        Console.WriteLine("    /dev/sdb1  1TB    NTFS");
        Console.WriteLine("    /dev/sdc1  500GB  EXT4");
        Console.WriteLine();

        Console.Write("Loading desktop environment...");
        System.Threading.Thread.Sleep(1000);
        Console.Write("done.\n");
        Console.WriteLine();

        Console.WriteLine("Starting X server...");

        Console.WriteLine("    Initializing graphics driver...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("    Initializing input driver...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("    Initializing display manager...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("    Initializing window manager...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("    Starting desktop environment...");

        Console.WriteLine("Desktop environment started.");
        Console.WriteLine();

        Console.Write("Loading system settings...");
        System.Threading.Thread.Sleep(500);
        Console.Write("done.\n");
        Console.WriteLine();

        Console.Write("Loading user settings...");
        System.Threading.Thread.Sleep(500);
        Console.Write("done.\n");
        Console.WriteLine();

        Console.WriteLine("Starting system tray...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Starting taskbar...");
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("Starting applications...");

        Console.Write("Entering desktop...");
        System.Threading.Thread.Sleep(500);
        Console.Write("done.\n");

        Console.ResetColor();
       
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        string input2 = "Welcome to my Assessment ;)";
        for (int i = 0; i < input2.Length; i++)
        {
            Console.Write(input2[i]);
            Thread.Sleep(100); 
        }
        Thread.Sleep(700);
        Console.Clear();
    }
}
