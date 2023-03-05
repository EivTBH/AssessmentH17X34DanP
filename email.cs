internal class EmailShort
{
    public string Email()
    {
        string fullName;

        do
        {
            Console.Write("Please enter your First and Last name separated by a space: ");
            Col.White("");
            fullName = Console.ReadLine();
        } while (!IsValidName(fullName));

        return Create_User(fullName);
    }

    private bool IsValidName(string fullName)
    {
        string[] names = fullName.Split(' ');
        if (names.Length != 2)
        {
            Console.WriteLine(
                "Error: please enter a valid name with first name and surname separated by a space."
            );
            return false;
        }

        string firstName = names[0];
        string lastName = names[1];

        if (!IsAllLetters(firstName) || !IsAllLetters(lastName))
        {
            Console.WriteLine(
                "Error: please enter a valid name without numbers or special characters."
            );
            return false;
        }

        firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();
        lastName = char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower();

        return true;
    }

    private bool IsAllLetters(string str)
    {
        foreach (char c in str)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }
        return true;
    }

    private string Create_User(string fullName)
    {
        string[] names = fullName.Split(' ');
        string firstName = names[0];
        string lastName = names[1];

        firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();
        lastName = char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower();

        string userName = $"{firstName}.{lastName}".Trim();
        userName = userName + "@dundeeandangus.ac.uk";

        return userName;
    }
}