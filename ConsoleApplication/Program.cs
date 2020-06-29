using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    class Program
    {
        static string[] results = new string[50];
        static Tuple<string, string> names;
        static ConsolePrinter printer = new ConsolePrinter();

        private static void PrintResults()
        {
            printer.Value("[" + string.Join(",", results) + "]").ToString();
        }

        private static void GetRandomJokes(string category, int number)
        {
            new JsonFeed(Constants.JokeEndPoint, number);
            results = JsonFeed.GetRandomJokes(names?.Item1, names?.Item2, category);
        }

        private static void GetCategories()
        {
            new JsonFeed(Constants.JokeEndPoint, 0);
            results = JsonFeed.GetCategories();
        }

        private static void GetNames()
        {
            new JsonFeed(Constants.NameEndPoint, 0);
            dynamic result = JsonFeed.GetNames();
            names = Tuple.Create(result.name.ToString(), result.surname.ToString());
        }

        private static void StartJoke()
        {
            if (Console.ReadLine() == "?")
            {
                while (true)
                {
                    printer.Value(Constants.GetCategory).ToString();
                    printer.Value(Constants.GetRandom).ToString();
                    EnteredKey.GetEnteredKey(Console.ReadKey());
                    Console.ReadLine();
                    MakeSelection();
                }
            }
        }

        private static void MakeSelection()
        {
            switch (EnteredKey.key)
            {
                case (char)KeyStatus.Category:
                    GetCategories();
                    PrintResults();
                    break;
                case (char)KeyStatus.RandomJokes:
                    {
                        printer.Value(Constants.RandomName).ToString();
                        EnteredKey.GetEnteredKey(Console.ReadKey());
                        Console.ReadLine();
                        SpecifyChoice();
                        break;
                    }
            }
        }
        private static void SpecifyChoice()
        {
            switch (EnteredKey.key)
            {
                case (char)KeyStatus.Yes:
                    {
                        GetNames();
                        printer.Value(Constants.SpecifyCategory).ToString();
                        EnteredKey.GetEnteredKey(Console.ReadKey());
                        Console.ReadLine();

                        printer.Value(Constants.SelectJokes).ToString();
                        int n = Int32.Parse(Console.ReadLine());
                        printer.Value(Constants.EnterCategory).ToString();
                        GetRandomJokes(Console.ReadLine(), n);
                        PrintResults();
                        break;
                    }

                default:
                    {
                        printer.Value(Constants.SelectJokes).ToString();
                        int n = Int32.Parse(Console.ReadLine());
                        GetRandomJokes(null, n);
                        PrintResults();
                        break;
                    }
            }
        }

        static void Main(string[] args)
        {
            printer.Value(Constants.GetInstructions).ToString();
            Program pj = new Program();
            StartJoke();
        }
    }
}