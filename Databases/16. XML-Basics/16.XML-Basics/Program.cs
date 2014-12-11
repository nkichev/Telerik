using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace _16.XML_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../students.xsl");
            xslt.Transform("../../students.xml", "../../students.html");
            Console.WriteLine("The html file is generated in the directory!");
        }
    }
}
