using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    public static class Constants
    {
        public const string NameSurname = "?name&surname";
        public const string RandomJokes = "jokes/random";
        public const string JokeCategories = "jokes/categories";
        public const string DefaultName = "Chuck Norris";
        public const string GetInstructions = "Press ? to get instructions.";
        public const string SelectJokes = "How many jokes do you want? (1-9)";
        public const string RandomName = "Want to use a random name? y/n:";
        public const string SpecifyCategory = "Want to specify a category? y/n: ";
        public const string GetCategory = "Press c to get categories";
        public const string GetRandom = "Press r to get random jokes";
        public const string EnterCategory = "Enter a category:";
        public const string JokeEndPoint = "https://api.chucknorris.io";
        public const string NameEndPoint = "https://www.names.privserv.com/api/";

    }
}