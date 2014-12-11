using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10.PreviousTaskWithXElement
{
    class PreviousTaskWithXElement
    {
        //10. Rewrite the last exercises using XDocument, XElement and XAttribute.

        static void Main(string[] args)
        {
            DirectoryInfo sourceDir = new DirectoryInfo("../../../");

            var xmlInfo = new XElement("directoryStructure");
            WriteDirectoryXML(xmlInfo, sourceDir);
            xmlInfo.Save("../../../directoryStructure.xml");
        }

        private static void WriteDirectoryXML(XElement parentElement, DirectoryInfo rootDirectory)
        {
            var currentFolder = new XElement("directory", new XAttribute("name", rootDirectory.Name));

            foreach (var file in rootDirectory.GetFiles())
            {
                currentFolder.Add(new XElement("file", file.Name));
            }

            foreach (var subDir in rootDirectory.GetDirectories())
            {
                WriteDirectoryXML(currentFolder, subDir);
            }

            parentElement.Add(currentFolder);
        }      
    }
}
