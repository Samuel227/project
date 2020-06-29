using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    /// <summary>
    /// This class print to console.
    ///Contains all methods for performing printing
    /// </summary>
    public class ConsolePrinter
    {
        /// <summary>
        /// <see cref="Object"/> print value
        /// </summary>
        public static object PrintValue;

        /// <summary>
        /// This method print out values to console
        /// </summary>
        /// <returns>This</returns>
        /// <param name="value">A string value.</param>
        public ConsolePrinter Value(string value)
        {
            PrintValue = value;
            return this;
        }
        /// <summary>
        /// This method convert print values to string
        /// </summary>
        /// <returns>null</returns>
        public override string ToString()
        {
            Console.WriteLine(PrintValue);
            return null;
        }
    }
}