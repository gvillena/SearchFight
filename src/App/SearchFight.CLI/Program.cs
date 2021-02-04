using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace SearchFight.CLI
{
  class Program
  {
    public const string SEARCH_FIGHT_API_BASEURL = "http://localhost:5000";

    static async Task Main(string[] args)
    {
      if (args.Length == 0)
      {
        Console.WriteLine("Please enter the name of one or more programming languages.");
        Console.WriteLine("USAGE: TranzactChallenge <PROGRAMMING_LANGUAGE_NAME ...>");
        return;
      }

      var client = new HttpClient();
      var builder = new UriBuilder($"{SEARCH_FIGHT_API_BASEURL}/api/searchfight");

      var parameters = HttpUtility.ParseQueryString(string.Empty);

      for (int i = 0; i < args.Length; i++)
      {
        parameters[$"list[{i}]"] = args[i];
        Console.WriteLine(args[i]);
      }

      builder.Query = parameters.ToString();

      Console.WriteLine(builder.Uri);

      HttpResponseMessage response = await client.GetAsync(builder.Uri);



      if (response.IsSuccessStatusCode)
      {
        Console.WriteLine("Ok");
      } else
      {
        Console.WriteLine("Error");
      }

      Console.ReadLine();


    }
  }
}
