using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Xml.Linq;
using System.IO;

namespace JSON.NETAndRSS
{
    class JSONNETAndRSS
    {
        private const string RssUrl = "http://forums.academy.telerik.com/feed/qa.rss";
        private const string RssFilePath = "../../rss.xml";
        private const string JsonFilePath = "../../rss.json";
        private const string HtmlFilePath = "../../index.html";
        private const string ItemTemplate = "<li><a href=\"{0}\">[{1}] {2} ({3})</a></li>";

        static void Main()
        {
            //02. Download the content of the feed programmatically
            //You can use WebClient.DownloadFile()

            var webClient = new WebClient();

            using (webClient)
            {
                webClient.DownloadFile(RssUrl, RssFilePath);
            }

            //03.Parse the XML from the feed to JSON

            var xml = XElement.Load(RssFilePath);
            string json = JsonConvert.SerializeXNode(xml, Newtonsoft.Json.Formatting.Indented);

            using (var fileStream = new FileStream(JsonFilePath, FileMode.Create))
            {
                using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    writer.WriteLine(json);
                }
            }

            //04.Using LINQ-to-JSON select all the question titles and print them to the console

            var jsonObj = JObject.Parse(json);
            var titles = jsonObj["rss"]["channel"]["item"]
                .Select(i => i["title"]);
            Console.WriteLine(string.Join(Environment.NewLine, titles));

            //05.Parse the JSON string to POCO

            var itemsJson = jsonObj["rss"]["channel"]["item"].ToString();
            var items = JsonConvert.DeserializeObject<Item[]>(itemsJson);

            //06. Using the parsed objects create a HTML page that lists all questions from the RSS their 
            //categories and a link to the question's page

            var itemsInHtml = new StringBuilder();
            itemsInHtml.AppendLine("<ul>");

            foreach (var item in items)
            {
                itemsInHtml.AppendFormat(ItemTemplate, item.Link, item.Category, item.Title, item.PubDate.ToShortDateString());
            }

            itemsInHtml.AppendLine("</ul>");

            using (var fileStream = new FileStream(HtmlFilePath, FileMode.Create))
            {
                using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    writer.WriteLine(itemsInHtml.ToString());
                }
            }
        }
    }
}
