using System;
using WordCounter.Models;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
          RepeatCounter Words123 = new RepeatCounter();
          Console.WriteLine("Please enter a sentence.");
          string UserPhrase = Console.ReadLine();
          Console.WriteLine("Please enter a word the check the previous sentence with.");
          string UserWord = Console.ReadLine();
          int CountWords = Words123.wordCounter(UserPhrase,UserWord);
          Console.WriteLine(UserWord + " appears in (" + UserPhrase + ") " + CountWords + " times.");


        }
    }
}
