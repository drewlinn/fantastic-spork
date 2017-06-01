using Xunit;
using System;
using System.Collections.Generic;
using ScrabbleScore.Objects;

namespace ScrabbleScore.Objects
{
  public class ScrabbleTest
  {
    // [Fact]
    // public void Returns_user_input()
    // {
    //   Scrabble instance = new Scrabble();
    //   string testString = instance.ScrabbleScore("Beard");
    //   Assert.Equal("Beard", testString);
    // }
    [Fact]
    public void Scores_Common_Letter()
    {
    string word = "lore";
    Scrabble instance = new Scrabble(word);
    string newWord = instance.GetWord();
    Dictionary<char, int> newDictionary = instance.GetDictionary();
    Assert.Equal(4, instance.CheckScore(newWord, newDictionary));
    }
  }
}
