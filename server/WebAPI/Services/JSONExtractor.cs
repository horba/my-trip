using System;
using System.Text.RegularExpressions;

namespace WebAPI.Services
{
  public class JSONExtractor
  {
    public string GetValue(string key, string json)
    {
      try
      {
        var tokenRegex = new Regex($"\"{key}\": \"(.*?)\"");
        var matches = tokenRegex.Matches(json);
        return matches[0].Groups[1].Value;
      }
      catch
      {
        return null;
      }
    }
  }
}
