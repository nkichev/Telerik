namespace WcfServiceLibraryDemo
{
    using System;
    
    /// <summary>
    /// Demonstrates wcf service library usage.
    /// </summary>
    public class ServiceDemo : IServiceDemo
    {
        /* 03. Create a Web service library which accepts two string as parameters. 
         * It should return the number of times the second string contains the first string. 
         * Test it with the integrated WCF client.*/

        public int GetCount(string firstString, string secondString)
        {
            int count = 0;
            int startIndex = 0;

            startIndex = secondString.IndexOf(firstString);

            if (startIndex == -1)
            {
                return 0;
            }

            while (startIndex != -1)
            {
                count++;
                startIndex = secondString.IndexOf(firstString, startIndex + 1);
            }

            return count;
        }
    }
}
