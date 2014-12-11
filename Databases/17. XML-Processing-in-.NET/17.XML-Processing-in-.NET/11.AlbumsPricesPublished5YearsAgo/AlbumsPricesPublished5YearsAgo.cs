using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _11.AlbumsPricesPublished5YearsAgo
{
    class AlbumsPricesPublished5YearsAgo
    {
        //11. Write a program, which extract from the file catalog.xml the prices for all albums, 
        //    published 5 years ago or earlier. Use XPath query.

        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");

            string xPathQuery = "/albums/album[year>" + (DateTime.Now.Year - 5).ToString() + "]";
            XmlNodeList list = doc.SelectNodes(xPathQuery);

            foreach (XmlNode album in list)
            {
                Console.WriteLine("Name: {0}, price: {1}", album.SelectSingleNode("name").InnerText, album.SelectSingleNode("price").InnerText);
            }
        }
    }
}
