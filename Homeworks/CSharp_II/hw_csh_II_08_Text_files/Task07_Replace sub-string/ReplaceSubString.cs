/* Task 7 
    Write a program that replaces all occurrences of the sub-string "start" with the sub-string "finish" in a text file.
    Ensure it will work with large files (e.g. 100 MB).
*/

using System;
using System.Text.RegularExpressions;
using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        // NB! - If testing for big TXT files - first use GenerateLargeFile() Method to create the 100mb start.txt File
        // GenerateLargeFile();

        string fileContent = File.ReadAllText("../../start.txt");
        File.WriteAllText("../../finish.txt", Regex.Replace(fileContent, @"\bstart\b", "finish"));
        Console.WriteLine("Complete");
    }

    private static void GenerateLargeFile()
    {
        string inputPath = "../../start.txt";
        using (StreamWriter writer = new StreamWriter(inputPath))
        {
            long fileSize = 0;
            long maxSize = 100000000; // ~100 MB

            while (fileSize < maxSize)
            {
                writer.WriteLine(@"Some Lorem Ipsum:
Vivamus start placerat enim faucibus fermentum. In hac habitasse platea dictumst. In eget dui
 id magna bibendum maximus. Vestibulum hendrerit ullamcorper nisi. Vivamus a start est. start 
 vel tincidunt mi, vitae start mi. Maecenas augue erat, start ac mattis sit amet, sodales 
 eu metus. Suspendisse metus urna, tempus nec justo vel, dapibus porta velit. Etiam lobortis 
 augue eu dui scelerisque lacinia ac eget dolor. Cras tempus risus ligula, a aliquam tellus 
 semper gravida. Etiam dapibus purus risus, quis start elit malesuada nec. Aenean ultricies 
 libero eget nunc start, id mattis start vestibulum.

Nam eleifend sapien ut eleifend porta. Aenean lacinia neque non turpis facilisis, nec start 
magna faucibus. Morbi et turpis at leo commodo tempus. Proin maximus ullamcorper tellus non 
porta. Donec cursus erat in mi start bibendum. Class aptent taciti sociosqu ad litora 
torquent per conubia nostra, per inceptos himenaeos. Etiam quis lectus mattis, tincidunt risus 
a, fermentum nulla. Mauris sit amet orci condimentum, condimentum tortor non, semper justo. 
start vestibulum magna quis start tincidunt. Donec lacinia, erat non condimentum tempor, 
turpis start consequat libero, imperdiet finibus lacus lectus commodo neque. Nam congue, odio 
eget varius sollicitudin, lacus risus vulputate start, at convallis turpis elit et start. ");

                FileInfo file = new FileInfo("../../start.txt");
                fileSize = file.Length;
            }
        }
    }
}

