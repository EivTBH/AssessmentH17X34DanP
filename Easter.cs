using System;

public class Easter
{
    public static void Egg()
    {
        Console.Clear();
        Col.Green("");
        Helper.Blinker("");
        string input3 = "Why are you here?...";
        for (int i = 0; i < input3.Length; i++)
        {
            Console.Write(input3[i]);
            Thread.Sleep(50); // delay between characters
        }

        Thread.Sleep(600);
        Console.Clear();
        string input4 = "There isn't an easter egg. I mean, what even is an easter egg?";
        for (int i = 0; i < input4.Length; i++)
        {
            Console.Write(input4[i]);
            Thread.Sleep(50); // delay between characters
        }

        Thread.Sleep(600);
        Console.Clear();
        string input5 = "A way for a developer to stroke their own ego thinking they have hidden something from their colleagues and users?";
        for (int i = 0; i < input5.Length; i++)
        {
            Console.Write(input5[i]);
            Thread.Sleep(50); // delay between characters
        }

        Thread.Sleep(600);
        Console.Clear();
        string input6 = "Or, are they a fun little surprise to thank you for exploring every inch of a program?";
        for (int i = 0; i < input6.Length; i++)
        {
            Console.Write(input6[i]);
            Thread.Sleep(50); // delay between characters
        }
        Thread.Sleep(600);
        Console.Clear();

        string input7 = "Well... sorry to tell you... this is neither...";
        for (int i = 0; i < input7.Length; i++)
        {
            Console.Write(input7[i]);
            Thread.Sleep(50); // delay between characters
        }
        Thread.Sleep(1500);
        Console.Clear();

        string input8 = "Fine...";
        for (int i = 0; i < input8.Length; i++)
        {
            Console.Write(input8[i]);
            Thread.Sleep(50); // delay between characters
        }
        Thread.Sleep(600);
        Col.Yellow("");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("  ___");
        Console.WriteLine(" /    \\");
        Console.WriteLine("/      \\");
        Console.WriteLine("\\      /");
        Console.WriteLine(" \\ ___/");
        Console.WriteLine();
        Console.WriteLine();

        Col.Green("");
        Thread.Sleep(1500);

        string input9 = "happy now?...";
        for (int i = 0; i < input9.Length; i++)
        {
            Console.Write(input9[i]);
            Thread.Sleep(50); // delay between characters
        }

        Thread.Sleep(2000);
        Console.Clear();
        Col.White("");
    }
}
