using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// Asigns a text colour in a shorted form for ease of use.
public static class Col
{
    public static void Red(string args)
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    public static void Blue(string args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
    }

    public static void Green(string args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }

    public static void Yellow(string args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    public static void White(string args)
    {
        Console.ForegroundColor = ConsoleColor.White;
    }

    public static void Cyan(string args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }

    public static void Magenta(string args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
    }

    public static void Default(string args)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
