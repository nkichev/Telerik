using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _04.DeleteAlbumsWithPriceMoreThan20
{
    class DeleteAlbumsWithPriceMoreThan20
    {
        //04. Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.

        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogueCopy.xml");

            string xPathQuery = "/albums/album[price>20]";
            XmlNodeList albums = doc.SelectNodes(xPathQuery);
            foreach (XmlNode album in albums)
            {
                XmlNode parent = album.ParentNode;
                parent.RemoveChild(album);
                Console.WriteLine("Successfully deleted");
            }

            doc.Save("../../../newCatalogue.xml");
        }
    }
}
