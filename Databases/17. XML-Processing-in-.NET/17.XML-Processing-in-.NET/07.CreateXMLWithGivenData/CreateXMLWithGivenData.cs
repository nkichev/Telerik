using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _07.CreateXMLWithGivenData
{
    class CreateXMLWithGivenData
    {
        //07.In a text file we are given the name, address and phone number of given person (each at a single line).
        //Write a program, which creates new XML document, which contains these data in structured XML format.

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../PersonInfo.txt");
            string name = reader.ReadLine();
            string address = reader.ReadLine();
            string number = reader.ReadLine();

            XElement persons =
                new XElement("persons",
                    new XElement("person",
                        new XElement("name", name),
                        new XElement("address", address),
                        new XElement("number", number)
                    )
                );

            persons.Save("../../../PersonsInfo.xml");
        }
    }
}
