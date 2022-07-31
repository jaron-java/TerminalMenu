using System.Security.Cryptography;

namespace TerminalMenu;

// Make Print Options make a little more sense
// Have Printoptions return the string they input
// Take that string into another function, maybe determining which function to 


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
    
    
    // public static void PrintList(List<string> options)
    // {
    //     //Helper function to test InputList
    //     foreach (string word in options)
    //     {
    //         Console.WriteLine(word);
    //     }
    // }
    //
    // public static List<Tuple<string>> SplitInput(List<string> choices)
    // {
    //     //Takes in an unknown size List<String> as parameters
    //     //uses for loop to iterate over unknown sized List
    //     //foreach word in list return a tuple containing ("w", "word")
    //     //add tuples to list
    //     //return list of tuples
    // }
    
    
    // public static void PrintOptions(List<Tuple<string>> tupList)
    // {
    //     //for loop for the amount of tuples in list
    //     //for each tuple print code
    //     //"=================="
    //     //"Please enter (w) or (word)"
    //     //===========More printing
    //     //make the return of this statement equal to something
    //     // string choice = PrintOptions(tupList
    //     //feed choice into next method above
    // }
    //

    
    ///////////////////////////
    //////////////////////// public static string ????(List<Tuple<string>> 
    // {
   ////////////// //     //Takes in List<Tuple<string>> from SplitInput()
    //////////////////     // and input from user from another method
    //     //Loop through list of tuples, they should be ("w", "word")
    //     //for each, if each == 
    //     //return string with input
    //     //maybe try to have functions as inputs and if input == x run functionX()
    // }
    //////////////////////

    
}