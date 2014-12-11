//Write a program that extracts from given HTML file its title (if available), 
//and its body text without the HTML tags. Example:
//<html>
//  <head><title>News</title></head>
//  <body><p><a href="http://academy.telerik.com">Telerik
//    Academy</a>aims to provide free real-world practical
//    training for young people who want to turn into
//    skillful .NET software engineers.</p></body>
//</html>


using System;
using System.IO;

    class ExtractHTMLTitleAndBody
    {
        static void Main()
        {
            string str = @"<html><head><title>News</title>
</head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a> aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

            int openIndex = str.IndexOf('<');
            int closeIndex = str.IndexOf('>');

            while (openIndex >= 0)
            {
                str = str.Remove(openIndex, closeIndex - openIndex + 1);

                openIndex = str.IndexOf('<');
                closeIndex = str.IndexOf('>');
            }

            str = str.Trim();
            Console.WriteLine(str);
        }
    }

