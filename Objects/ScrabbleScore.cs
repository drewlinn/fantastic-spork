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
  }
}
