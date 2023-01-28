using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Language> languages = File.ReadAllLines("./languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();
    }
}