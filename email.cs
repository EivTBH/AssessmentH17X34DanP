internal class EmailShort
{
    /// <summary>
    /// This method prompts the user to enter their full name, checks if it's valid, and creates an email username for the user if the name is valid.
    /// It returns the resulting email address.
    /// </summary>
    public string Email()
    {
        string fullName;

        // Loop until the user enters a valid name
        do
        {
            // Prompt the user to enter their full name
            Console.Write("Please enter your First and Last name separated by a space: ");
            Col.White("");
            fullName = Console.ReadLine();
        } while (!IsValidName(fullName));

        // Create an email username for the user and return it
        return Create_User(fullName);
    }

    /// <summary>
    /// This method takes a full name as input and checks if it's valid. A valid name consists of exactly two words
    /// (first name and last name) with no special characters or numbers. It returns true if the name is valid and
    /// false otherwise.
    /// </summary>
    private bool IsValidName(string fullName)
    {
        // Split the full name into first name and last name
        string[] names = fullName.Split(' ');

        // If the name doesn't consist of exactly two words, print an error message and return false
        if (names.Length != 2)
        {
            Console.WriteLine("Error: please enter a valid name with first name and surname separated by a space.");
            return false;
        }

        // Check if each word consists only of letters. If not, print an error message and return false.
        string firstName = names[0];
        string lastName = names[1];
        if (!IsAllLetters(firstName) || !IsAllLetters(lastName))
        {
            Console.WriteLine("Error: please enter a valid name without numbers or special characters.");
            return false;
        }

        // If the name is valid, return true
        return true;
    }

    /// <summary>
    /// This method takes a string as input and checks if it consists only of letters. It returns true if the string
    /// consists only of letters and false otherwise.
    /// </summary>
    private bool IsAllLetters(string str)
    {
        // Loop through each character in the string
        foreach (char c in str)
        {
            // If the character isn't a letter, return false
            if (!char.IsLetter(c))
            {
                return false;
            }
        }

        // If all characters are letters, return true
        return true;
    }

    /// <summary>
    /// This method takes a full name as input and creates an email username for the user. It returns the email username.
    /// </summary>
    private string Create_User(string fullName)
    {
        // Split the full name into first name and last name
        string[] names = fullName.Split(' ');
        string firstName = names[0];
        string lastName = names[1];

        // Capitalize the first letter of each word
        firstName = char.ToUpper(firstName[0]) + firstName.Substring(1
