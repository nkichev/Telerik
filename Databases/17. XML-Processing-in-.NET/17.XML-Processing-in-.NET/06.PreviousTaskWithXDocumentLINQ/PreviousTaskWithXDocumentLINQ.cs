using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _06.PreviousTaskWithXDocumentLINQ
{
    class PreviousTaskWithXDocumentLINQ
    {
        //06. Rewrite the same using XDocument and LINQ query.

        static void Main(string[] args)
        {
            XElement doc = XElement.Load("../../../catalogue.xml");

            var songsTitles = from song in doc.Descendants("song")
                              select song.Element("title").Value;

            foreach (var title in songsTitles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
