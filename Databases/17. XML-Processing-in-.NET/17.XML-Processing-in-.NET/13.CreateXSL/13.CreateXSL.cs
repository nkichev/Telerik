using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace _13.CreateXSL
{
    class Program
    {
        //13.Create an XSL stylesheet, which transforms the file catalog.xml into HTML document, formatted for viewing in a standard Web-browser.
        //14.Write a C# program to apply the XSLT stylesheet transformation on the file catalog.xml using the class XslTransform.

        static void Main(string[] args)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../../catalogue.xsl");
            xslt.Transform("../../../catalogue.xml", "../../../catalogue.html");
            Console.WriteLine("The html file is generated in the directory!");
        }
    }
}
