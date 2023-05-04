using HtmlAgilityPack;
using System;
using System.Net.Http;

namespace WebScraperWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            // send get request to weather.com
            String url = "https://weather.com/hr-HR/vrijeme/danas/l/27364e72f397ce124628bf2a8d79db04990c30a5d3fad6b4b477fc214e9891d3";
            var httpClient = new HttpClient(); //objekt pridruuzujemo varijabli
            var html = httpClient.GetStringAsync(url).Result; //
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);


            //get the location
            var locationElement = htmlDocument.DocumentNode.SelectSingleNode("//h1[@class='CurrentConditions--location--1YWj_']");
            var locations = locationElement.InnerText.Trim(); //triba nan samo broj
            Console.WriteLine("Lokacija: " + locations);

            // get the temperature
            var temperatureElement = htmlDocument.DocumentNode.SelectSingleNode("//span[@class='CurrentConditions--tempValue--MHmYY']");
            var temperature = temperatureElement.InnerText.Trim(); //triba nan samo broj
            Console.WriteLine("Temperatura: " + temperature);

            // get the conditiona
            var conditionElement = htmlDocument.DocumentNode.SelectSingleNode("//div[@class='CurrentConditions--phraseValue--mZC_p']");
            var conditions = conditionElement.InnerText.Trim(); //triba nan samo broj
            Console.WriteLine("Uvjeti: " + conditions);
        }
    }
}
