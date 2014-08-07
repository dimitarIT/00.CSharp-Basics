//Write a program that extracts and prints all URLs from given text. URL can be in only two formats:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class ExtractURLsFromText
{
    static void Main()
    {
        string givenText = Console.ReadLine();

        List<string> urls = ReturnLinks(givenText).Distinct().ToList();

        foreach (var item in urls)
        {
            Console.WriteLine(item);
        }
    }

    static List<string> ReturnLinks(string text)
    {
        List<string> links = new List<string>();

        Regex urls = new Regex(@"((https?|ftp|file)\://|www.)[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*", RegexOptions.IgnoreCase);

        MatchCollection matches = urls.Matches(text);
        foreach (Match match in matches)
        {
            links.Add(match.Value);
        }
        return links;
    }
}
