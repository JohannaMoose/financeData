using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace FinanceData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen, hämtar gårdagens data");

            Console.WriteLine("Vilken aktie vill du hämta (beteckning från Yahoo finans)");
            var aktie = Console.ReadLine()?.ToUpper();

            var client = new RestClient("https://query.yahooapis.com");
            var request = new RestRequest(
                $"/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20(\"{aktie}\")%0A%09%09&format=json&diagnostics=true&env=http%3A%2F%2Fdatatables.org%2Falltables.env&callback=", Method.GET);
            var rawData = client.Execute(request).Content;
            var json = JObject.Parse(rawData);

            var q = json["query"]["results"]["quote"];
           
            var stock = JsonConvert.DeserializeObject<Stock>(q.ToString());

            var exit = Console.ReadLine();
        }
    }
}
