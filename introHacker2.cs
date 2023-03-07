/// <summary>
/// Emulates a hacking screen from a movie, now with more nonsense.
/// </summary>
public class Hack2
{
    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();

        string[] lines = new string[]
        {
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
                System.Threading.Thread.Sleep(5);
            }
            Console.WriteLine();

            if (lines[i].StartsWith("Warning:"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(">>> WARNING: SECURITY BREACH DETECTED <<<");
                Console.ForegroundColor = ConsoleColor.Green;

                if (lines[i].Contains("Lockout"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(">>> LOCKOUT IMMINENT: BACKTRACE INITIATED <<<");
                    Console.ForegroundColor = ConsoleColor.Green;

                    for (int k = 0; k < Console.WindowWidth; k++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(k, Console.CursorTop);
                        Console.Write("   XXX-SYTEM COMPROMISED!-XXX  ");
                        System.Threading.Thread.Sleep(10);
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    for (int k = 0; k < Console.WindowWidth; k++)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(k, Console.CursorTop);
                        Console.Write(
                            "--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--VIRUS--"
                        );
                        System.Threading.Thread.Sleep(10);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine();
                    }
                }
            }
        }

        // Emulate typing
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        string input2 = "Welcome to my Assessment ;)";
        for (int i = 0; i < input2.Length; i++)
        {
            Console.Write(input2[i]);
            Thread.Sleep(100); // delay between characters
        }
        Thread.Sleep(700);
        Console.Clear();
    }
}