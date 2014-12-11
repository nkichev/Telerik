//Write a program that parses an URL address given in the format:
//[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. 
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"

using System;

class URLAddress
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        int index = url.IndexOf(':');
        Console.WriteLine("[protocol] = {0}", url.Substring(0, index));
        url = url.Remove(0, index + 3);

        index = url.IndexOf('/');
        Console.WriteLine("[server] = {0}", url.Substring(0, index));
        url = url.Remove(0, index);

        Console.WriteLine("[resource] = {0}", url);
        
    }
}

