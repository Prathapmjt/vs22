class ReverseString
{
    static void Main(string[] args)
    {
        string str, revString = "";
        Console.WriteLine("Enter string : ");
        str = Console.ReadLine();
        str = str.ToLower();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            revString = revString + str[i];
        }
        Console.WriteLine("Reverse String is : " + revString);
        if (str == revString)
        {
            Console.WriteLine("\n String is palindrome");
        }
        else
        {
            Console.WriteLine("\n String is not palindrome.");
        }
        Console.ReadLine();
    }
}
