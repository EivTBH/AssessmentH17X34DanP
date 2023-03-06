using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// Assigns a text colour in a shortened form for ease of use.
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

    public static void Black(string args)
    {
        Console.ForegroundColor = ConsoleColor.Black;
    }

    public static void DarkBlue(string args)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
    public static void DarkGreen(string args)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
    }
    public static void DarkCyan(string args)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
    }
    public static void DarkRed(string args)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    public static void DarkMagenta(string args)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    public static void DarkYellow(string args)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
    public static void DarkGray(string args)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
    }

}
