using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using RestSharp;

namespace FinanceData
{
    class Program
    {
        private ExcelPackage excelFile;

        static void Main(string[] args)
        {
            var file = args[0];
        
            Console.WriteLine("Välkommen, till hämtning av finans data. Komihåg att excelfilen måste vara stängd och inte används av någon annan process för att programmet ska fungera");
            var excelFilePath = new Uri(file);
            Console.WriteLine("Läser in data från filen {0}", excelFilePath.AbsolutePath);
            var excelFile = new ExcelPackage(new FileInfo(excelFilePath.AbsolutePath));
            var stockList = createStockList(excelFile);

            var client = new RestClient("https://query.yahooapis.com");
            var dataSheet = excelFile.Workbook.Worksheets["Data"];
            foreach (var stockName in stockList)
            {
                Console.WriteLine("Hämtar data för aktien {0}", stockName);
                var request = new RestRequest(
              $"/v1/public/yql?q=select%20*%20from%20yahoo.finance.quotes%20where%20symbol%20in%20(\"{stockName}\")%0A%09%09&format=json&diagnostics=true&env=http%3A%2F%2Fdatatables.org%2Falltables.env&callback=", Method.GET);
                var rawData = client.Execute(request).Content;
                var json = JObject.Parse(rawData);

                var q = json["query"]["results"]["quote"];

                var stock = JsonConvert.DeserializeObject<Stock>(q.ToString());
                dataSheet.InsertRow(2,1);
                dataSheet.Cells[2, 1].Value = stock.Symbol;
                dataSheet.Cells[2, 2].Value = stock.LastTradePriceOnly;
                dataSheet.Cells[2, 3].Value = DateTime.Now;
            }

            Console.WriteLine("Sparar all data som är tillagd i filen");
            excelFile.Save();

            Console.WriteLine("Tryck på valfri knapp för att stänga");
            var exit = Console.ReadLine();
        }

        private static IEnumerable<string> createStockList(ExcelPackage excelFile)
        {
            Console.WriteLine("Läser in vilka aktier som ska läsas av, finns i arbetsboken 'Aktier'");
            var stockSheet = excelFile.Workbook.Worksheets["Aktier"];
            var stockNames = new List<string>();
            var index = 2;
            while (stockSheet.Cells[index, 2].Value != null)
            {
                stockNames.Add(stockSheet.Cells[index, 2].Value.ToString());
                index++;
            }

            return stockNames;
        }
    }
}
