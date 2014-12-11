using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _12.PreviousTaskWithLINQ
{
    class PreviousTaskWithLINQ
    {
        //12. Rewrite the previous using LINQ query.

        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("../../../catalogue.xml");

            var albums =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) > (DateTime.Now.Year - 5)
                select new { Name = album.Element("name").Value, Price = album.Element("price").Value };

            foreach (var album in albums)
            {
                Console.WriteLine("Name: {0}, Price: {1}", album.Name, album.Price);
            }
        }
    }
}
