using Nancy;
using System.Collections.Generic;
using ScrabbleScore.Objects;

namespace ScrabbleScore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {


        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        Scrabble instance = new Scrabble(Request.Form["body"]);
        // Dictionary<char, int> newDict = instance.GetDictionary();

        return View["index.cshtml", instance];
      };
    }
  }
}
