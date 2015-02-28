/* Task 4 
    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
    Find in Google how to download files in C#.
    Be sure to catch all exceptions and to free any used resources in the finally block.
*/

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            {
                webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
                Console.WriteLine(" The download is successful!");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("The address is invalid or error occured during download.");
            }
        }
    }
}

