using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03.PreviousTaskWithXPath
{
    class PreviousTaskWithXPath
    {
        //03. Implement the previous using XPath.

        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");

            string xPathQuery = "/albums/album/artist";
            Dictionary<string, int> artistsAlbums = new Dictionary<string,int>();

            XmlNodeList artistsList = doc.SelectNodes(xPathQuery);

            foreach (XmlNode artist in artistsList)
            {
                string currentArtist = artist.InnerText;
                addToDictionary(artistsAlbums, currentArtist);
            }

            ListArtistsAndAlbums(artistsAlbums);
        }

        private static void ListArtistsAndAlbums(Dictionary<string, int> artistsAlbums)
        {
            foreach (var kVPair in artistsAlbums)
            {
                Console.WriteLine("Artist: " + kVPair.Key + "; number of albums: " + kVPair.Value);
            }
        }

        private static void addToDictionary(Dictionary<string, int> artistsAlbums, string artist)
        {
            if (!artistsAlbums.ContainsKey(artist))
            {
                artistsAlbums[artist] = 1;
            }
            else
            {
                artistsAlbums[artist]++;
            }
        }
    }
}
