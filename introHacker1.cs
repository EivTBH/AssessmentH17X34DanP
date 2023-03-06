using System;

public class Terminal
{
    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();

        string[] lines = new string[] {
            "Initializing Hack Protocol...",
            "Connecting to Remote Server...",
            "Warning: Security System Detected!",
            "Establishing Data Link...",
            "Warning: Firewall Detected!",
            "Hacking Security System...",
            "Bypassing Firewall...",
            "Accessing Private Network...",
            "Warning: Intrusion Detected!",
            "Decrypting Passwords...",
            "Warning: Lockout Detected!",
            "Downloading Sensitive Data...",
            "Uploading Virus Payload...",
            "Terminating Connection...",
            "Warning: Trace Detected!",
            "Scrambling System Logs...",
            "Warning: Alert Detected!",
            "Destroying Evidence...",
            "Hacking Complete!"
        };

        for (int i = 0; i < lines.Length; i++)
        {
            Console.Write(lines[i]);
            System.Threading.Thread.Sleep(200);
            for (int j = 0; j < lines[i].Length; j++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(25);
            }
            Console.WriteLine();

            if (lines[i].StartsWith("Warning:"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(">>> WARNING: SECURITY BREACH DETECTED <<<");
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
        // Emulate typing
        Console.WriteLine() ;
        Console.WriteLine() ;
        Console.WriteLine();
        string input2 = "Welcome to my Assessment ;)";
        for (int i = 0; i < input2.Length; i++)
        {
            Console.Write(input2[i]);
            System.Threading.Thread.Sleep(100); // delay between characters
        }
        Thread.Sleep(500);
        Console.Clear();
        
    }
}
