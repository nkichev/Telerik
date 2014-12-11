using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _05.XMLReaderExtractsAllSongs
{
    class XMLReaderExtractsAllSongs
    {
        //05. Write a program, which using XmlReader extracts all song titles from catalog.xml.

        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            List<string> songsTitles = new List<string>();
            doc.Load("../../../catalogue.xml");

            XmlReader reader = XmlReader.Create("../../../catalogue.xml");
            using (reader)
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "title"))
                    {
                        songsTitles.Add(reader.ReadInnerXml());
                    }
                }
            }

            foreach (var songTitle in songsTitles)
            {
                Console.WriteLine(songTitle);
            }
        }
    }
}
