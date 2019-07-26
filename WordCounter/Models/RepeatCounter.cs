using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
      public int wordCounter (string phrase, string word)
      {
        int wordnum = 0;
        string lphrase = phrase.ToLower();
        string lword = word.ToLower();
        string[] phraseArr = lphrase.Split(" ");
        for (int i = 0; i < phraseArr.Length; i++)
        {
          if (phraseArr[i] == lword)
          {
            wordnum += 1;
          }
        }
        return wordnum;
      }
    }
}
