using System;
using System.Collections.Generic;

namespace ScrabbleScore.Objects
{
  public class Scrabble
  {
    private string _word;
    private static Dictionary<char, int> _letterValues;

    public Scrabble(string newWord)
    {
      _word = newWord.ToLower();
      _letterValues = new Dictionary<char, int>()

    {
      {'a', 1}, {'b', 3}, {'c', 3}, {'d', 2}, {'e', 1}, {'f', 4}, {'g', 2}, {'h', 4}, {'i', 1}, {'j', 8}, {'k', 5}, {'l', 1}, {'m', 3}, {'n', 1}, {'o', 1}, {'p', 3}, {'q', 10}, {'r', 1}, {'s', 1}, {'t', 1}, {'u', 1}, {'v', 4}, {'w', 4}, {'x', 8}, {'y', 4}, {'z', 10}
    };
    // private Dictionary<int, string> _scoreLetters = new Dictionary <int, string> ()
    // {
    //   {1,"a","e","i","o","u","l","n","r","s","t"}, {2,"d","g"}, {3,"b","c","m","p"}, {4,"f","h","v","w","y"}, {5,"k"}, {8, "j","x"}, {10,"q","z"}
    // };
  }
    public string GetWord()
    {
      return _word;
    }

    public Dictionary<char, int> GetDictionary()
    {
      return _letterValues;
    }
    public int CheckScore(string newWord, Dictionary<char, int> letterValues)
    {
      char[] InputArray = newWord.ToCharArray();
      int score = 0;
      for (int i = 0; i < InputArray.Length; i++)
      {
        score += letterValues[InputArray[i]];
      }

      return score;
    }
    // public string ScrabbleScore(string userInput)
    // {
    //
    //   Console.WriteLine(userInput);
    //   return userInput;
    // }

    // public int ContainsCommon()
    // {
    //   int wordScore = 0;
    //   if (userInput.Contains("A","a","E","e","I","i","O","o","U","u","L","l","N","n","R","r","S","s","T","t")) {
    //     wordScore += 1;
    //   }
    //   return wordScore;
    // }
  }
}
