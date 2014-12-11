using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02.ExtractingArtistsAndNumberOfAlbums
{
    class ExtractingArtistsAndNumberOfAlbums
    {
        //02. Write program that extracts all different artists which are found in the catalog.xml. 
        //For each author you should print the number of albums in the catalogue. Use the DOM parser and a hash-table.

        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../catalogue.xml");

            XmlNode rootNode = doc.DocumentElement;
            Dictionary<string, int> artistsAlbums = new Dictionary<string, int>();

            foreach (XmlNode album in rootNode.ChildNodes)
            {
                var currentAlbumArtist = album["artist"].InnerText;
                AddToDictionary(artistsAlbums, currentAlbumArtist);
            }

            ListArtistsAndNumberOfAlbums(artistsAlbums);
        }

        private static void ListArtistsAndNumberOfAlbums(Dictionary<string, int> artistsAlbums)
        {
            foreach (var kVPair in artistsAlbums)
            {
                Console.WriteLine("Artist: " + kVPair.Key + " , number of albums: " + kVPair.Value);
            }
        }

        private static void AddToDictionary(Dictionary<string, int> artistsAlbums, string artist)
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
