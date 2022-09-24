using System.Security.Cryptography;

namespace TerminalMenu;

// Take that string into another function, maybe determining which function to run


public class Program
{   //This is before I learned any unit testing. 
    public static void Main()  //I would just run multiple tests in my Main
    {       // Just to kind of "eyeball" if my project was working as I wanted it.
        List<string> newList = InputList("here", "there", "everywhere", "stop", "go");
        string word = PrintOptions(newList);
        Console.WriteLine(word);
    }

        
    public static List<string> InputList(params string[] newlist)
    {    //This method returns a List of strings, this params string[] just means
        int i;          //the user can enter as many comma seperated strings as they want
        List<string> options = new List<string>(); //I dont have to know the size before hand
        for (i = 0; i < newlist.Length; i++)
        {
            options.Add(newlist.ElementAt(i)); //just loop through the "param string array"
        }                   //and make the list we will be returning
                            // this list we return will be fed into the next method below
        return options;
    }    
    
    public static string PrintOptions(List<string> options)
    {       //returns a string, takes the list returned from the above method
        int i;

        Console.WriteLine("Please make one of the following selections");
        
        foreach(string phrase in options)
        {
            string word = phrase; //Honestly probably dont need to do this, could just combine "word" and "phrase"
            char first = word[0]; // Takes hte first letter, so we can format it all (P)retty
            string rest = word.Remove(0, 1); //Takes the rest of the word besides the first letter
                                // Remove starting at 0 up to but not including 1
            Console.WriteLine("========================================"); //Gnarly cool line
            Console.WriteLine($"Please enter ({first}){rest} for {word}"); //"Please enter (U)p for up
                   // I guess I made it like this so the user could have the choice of entering the first letter or the whole word
        }
        string input = Console.ReadLine().ToLower();
        return input;
    }
    
    // I wanted to make another method, or alter this method to accept Functions/Methods
    // So if someone entered 'u' we could run the "up" method.  I guess make tuples out of the input letter and the method
}