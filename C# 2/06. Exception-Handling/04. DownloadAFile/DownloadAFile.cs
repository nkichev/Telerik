//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;
using System.IO;

class DownloadAFile
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            Console.Write("Enter URL address: ");
            string urlAddress = Console.ReadLine();
            Console.Write("Enter file name: ");
            string fileName = Console.ReadLine();

            try
            {
                webClient.DownloadFile(urlAddress, fileName);
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("The address cannot be null");
            }

            catch (WebException)
            {
                Console.WriteLine("The address is invalid or the file is empty.");
            }

            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
        }
    }
}

