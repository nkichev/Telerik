﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _09.TraverseDirectories
{
    class TraverseDirectories
    {
        //09. Write a program to traverse given directory and write to a XML file its contents together with 
        //all subdirectories and files. Use tags <file> and <dir> with appropriate attributes. 
        //For the generation of the XML document use the class XmlWriter.

        static void Main(string[] args)
        {
            XmlTextWriter writer = new XmlTextWriter("../../../directoryStructure.xml", Encoding.UTF8);
            DirectoryInfo sourceDir = new DirectoryInfo("../../../");

            using (writer)
            {
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartElement("directoryStructure");

                WriteDirectoryXML(writer, sourceDir);

                writer.WriteEndDocument();
            }
        }

        private static void WriteDirectoryXML(XmlTextWriter writer, DirectoryInfo rootDirectory)
        {
            writer.WriteStartElement("directory");
            writer.WriteAttributeString("name", rootDirectory.Name);

            foreach (var file in rootDirectory.GetFiles())
            {
                writer.WriteElementString("file", file.Name);
            }

            foreach (var subDir in rootDirectory.GetDirectories())
            {
                WriteDirectoryXML(writer, subDir);
            }

            writer.WriteEndElement();
        }
    }
}
