using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace _08.CreateXMLWithXMLWriter
{
    class CreateXMLWithXMLWriter
    {
        //08. Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml, 
        //in which stores in appropriate way the names of all albums and their authors.

        static void Main(string[] args)
        {
            XmlReader reader = XmlReader.Create("../../../catalogue.xml");
            XmlTextWriter writer = new XmlTextWriter("../../../AlbumsAndArtists.xml", Encoding.UTF8);

            using (reader)
            {
                using (writer)
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");
                    writer.Formatting = Formatting.Indented;
                    string name = string.Empty;
                    string artist = string.Empty;
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "name"))
                        {
                            name = reader.ReadElementString();
                        }
                        else if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "artist"))
                        {
                            artist = reader.ReadElementString();
                            WriteAlbumNameArtist(writer, name, artist);
                        }
                    }
                }
            }
        }

        private static void WriteAlbumNameArtist(XmlWriter writer, string name, string artist)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", name);
            writer.WriteElementString("artist", artist);
            writer.WriteEndElement();
        }
    }
}
