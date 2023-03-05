public static class Helper
{
    //Sets text (cursor) to the center of the console window.
    public static void CenterText(string text)
    {
        int screenWidth = Console.WindowWidth; // Gets the width of the console window

        int stringWidth = text.Length;  // Gets the length of the text to be centered

        int left = (screenWidth / 2) - (stringWidth / 2); // Calculates the horizontal position for the text to be centered

        int top = Console.CursorTop; // Gets the current vertical position of the console cursor

        Console.SetCursorPosition(left, top); // Sets the horizontal position of the console cursor to the calculated left position
        Col.Blue("");
        Console.WriteLine(text);
        Col.Default("");
    }

    //Gives a blinking effect a dot, showing the computer is 'thinking' and not crashed.
    public static void Blinker(string text)
    {
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("."); // Writes dot
            }
            Thread.Sleep(500);

            for (int j = 1; j <= i; j++)
            {
                Console.Write("\b \b"); // Erase the last dot by moving the cursor back and overwrite it with a space
            }
            Thread.Sleep(500);
        }
    }
}