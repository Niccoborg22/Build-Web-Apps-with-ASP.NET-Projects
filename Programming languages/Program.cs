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

        // Let's print all the languages 
        foreach(Language language in languages)
        {
            Console.WriteLine(language.Prettify());
        }

        Console.WriteLine("\n-----------------------------------\n");
        
        // Let's print a good string for each language
        var stringLang = 
            from l in languages
            select $"The {l.Name} was created in {l.Year} by {l.ChiefDeveloper}";

        foreach(string lang in stringLang)
        {
            Console.WriteLine(lang);
        }

        Console.WriteLine("\n-----------------------------------\n");

        // Let's find everything there is to know about C#
        var CSharp = 
            from l in languages
            where l.Name == "C#"
            select l.Prettify();
        
        foreach(string Csharp in CSharp)
        {
            Console.WriteLine(Csharp);
        }

        Console.WriteLine("\n-----------------------------------\n");

        // Let's find all the languages that were created by Microsoft
        var MicrosoftLang =
            from l in languages
            where l.ChiefDeveloper == "Microsoft"
            select l.Prettify();

        foreach(string micLang in MicrosoftLang)
        {
            Console.WriteLine(micLang);
        }

        Console.WriteLine("\n-----------------------------------\n");

        // Let's find all the languages that come from the Lisp langauge
        var LispLang =
            from l in languages
            where l.Predecessors == "Lisp"
            select l.Prettify();

        foreach(string lispLang in LispLang)
        {
            Console.WriteLine(lispLang);
        }

        Console.WriteLine("\n-----------------------------------\n");

        // Let's find all the languages that contain the word "Scripts"
        var ScriptsLang =
            from l in languages
            where l.Name.Contains("Script")
            select l.Prettify();

        foreach(string scriptsLang in ScriptsLang)
        {
            Console.WriteLine(scriptsLang);
        }

        Console.WriteLine("\n-----------------------------------\n");

        // Let's count the total number of languages in the list
        Console.WriteLine($"The total number of languages is {languages.Count()}");

        Console.WriteLine("\n-----------------------------------\n");

        // Let's count the number of languages in the list created between 1995 and 2005
        var tenYearSpan = 
            from l in languages
            where l.Year >= 1995 & l.Year <= 2005
            select $"{l.Name} was invented in {l.Year}";

        Console.WriteLine("The languages created between 1995 and 2005 are:");
        foreach(string langName in tenYearSpan)
        {
            Console.WriteLine($"- {langName}");
        }
    }

    // Method that return all the languages in the list in Prettify fashion
    public void PrettyPrintAll(IEnumerable<Language>[] LangList)
    {
        foreach(Language lang in LangList)
        {
            lang.Prettify();
        }
    }
}