using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    class JsonFeed
    {
        static string _url = "";

        public JsonFeed(string endpoint, int results)
        {
            _url = endpoint;
        }

        public static string[] GetRandomJokes(string firstName, string lastName, string category)
        {
            string joke = ValidateCategory(category);

            if (firstName != null && lastName != null)
            {
                int index = joke.IndexOf(Constants.DefaultName);
                int length = Constants.DefaultName.Length;
                int nameLength = index + length;
                string firstPart = joke.Substring(0, index);
                string secondPart = joke.Substring(0 + nameLength, joke.Length - nameLength);
                joke = $"{ firstPart } { firstName } { lastName } { secondPart }";
            }

            return new string[] { JsonConvert.DeserializeObject<dynamic>(joke).value };
        }

        private static string ValidateCategory(string category)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_url);
            string url = Constants.RandomJokes;
            if (category != null)
            {
                url += (url.Contains('?')) ? "&" : "?";
                url += "category=";
                url += category;
            }

            string joke = Task.FromResult(client.GetStringAsync(url).Result).Result;
            return joke;
        }

        /// <summary>
        /// get name from the api
        /// </summary>
        /// <returns>name,surname</returns>
        public static dynamic GetNames()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_url);
            string url = Constants.NameSurname;
            var result = client.GetStringAsync(url).Result;
            return JsonConvert.DeserializeObject<dynamic>(result);
        }

        public static string[] GetCategories()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_url);
            string url = Constants.JokeCategories;
            return new string[] { Task.FromResult(client.GetStringAsync(url).Result).Result };
        }
    }
}