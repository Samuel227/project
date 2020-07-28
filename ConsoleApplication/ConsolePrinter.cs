using System;

namespace ConsoleApplication
{

    public class ConsolePrinter
    {

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