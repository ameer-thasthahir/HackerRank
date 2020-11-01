using System;
using System.Net.Http;

namespace RestApi
{

    class Program
    {


        /*
           * Complete the 'getNumDraws' function below.
           *
           * The function is expected to return an INTEGER.
           * The function accepts INTEGER year as parameter.
           */

        




        public static int getNumDraws(int year)
        {
             HttpClient client = new HttpClient();
            int counter = 0;
            string Uri = "https://jsonmock.hackerrank.com/api/football_matches?year={0}&page={1}";
            var formattedUri = string.Format(Uri, year, 0);
            var res = client.GetAsync(Uri).Result;
            var reds = res.Content.ReadAsStringAsync();            
            // for (int i = 0; i <= totalPages; i++)
            // {
            //     var newUrl = string.Format(Uri, year, i);
            //     var responseMessage = client.GetAsync(newUrl).Result;
            //     var content = responseMessage.Content;
            //     for (int j = 0; j < perPage; j++)
            //     {
            //         var team1goals = content.data[j]["team1goals"];
            //         var team2goals = content.data[j]["team2goals"];
            //         if (team1goals == team2goals)
            //         {
            //             counter++;
            //         }
            //     }

            // }

            return counter;


        }
        static void Main(string[] args)
        {

            
            int result = getNumDraws(2011);

           Console.WriteLine(result);
        }
    }
}
