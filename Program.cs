using System.Security.Cryptography;

namespace TerminalMenu;

// Make Print Options make a little more sense
// Have Printoptions return the string they input
// Take that string into another function, maybe determining which function to run


public class Program
{
    public static void Main()
    {
        List<string> newList = InputList("here", "there", "everywhere", "stop", "go");
        string word = PrintOptions(newList);
        Console.WriteLine(word);
    }

    
    
    public static string PrintOptions(List<string> options)
    {
        int i;

        Console.WriteLine("Please make one of the following selections");

        foreach(string phrase in options)
        {
            string word = phrase;
            char first = word[0];
            string rest = word.Remove(0, 1);
            Console.WriteLine("========================================");
            Console.WriteLine($"Please enter ({first}){rest} for {word}");
        }
        string input = Console.ReadLine().ToLower();
        return input;
    }
    
    
    public static List<string> InputList(params string[] newlist)
    {
        int i;
        List<string> options = new List<string>();
        for (i = 0; i < newlist.Length; i++)
        {
            options.Add(newlist.ElementAt(i));
        }

        return options;
    }
}