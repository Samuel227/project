using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    class EnteredKey
    {
        public static char key;
        public static void GetEnteredKey(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.C:
                    key = (char)KeyStatus.Category;
                    break;
                case ConsoleKey.D0:
                    key = (char)KeyStatus.KeyZero;
                    break;
                case ConsoleKey.D1:
                    key = (char)KeyStatus.KeyOne;
                    break;
                case ConsoleKey.D2:
                    key = (char)KeyStatus.KeyTwo;
                    break;
                case ConsoleKey.D3:
                    key = (char)KeyStatus.KeyThree;
                    break;
                case ConsoleKey.D4:
                    key = (char)KeyStatus.KeyFour;
                    break;
                case ConsoleKey.D5:
                    key = (char)KeyStatus.KeyFive;
                    break;
                case ConsoleKey.D6:
                    key = (char)KeyStatus.KeySix;
                    break;
                case ConsoleKey.D7:
                    key = (char)KeyStatus.KeySeven;
                    break;
                case ConsoleKey.D8:
                    key = (char)KeyStatus.KeyEight;
                    break;
                case ConsoleKey.D9:
                    key = (char)KeyStatus.KeyNine;
                    break;
                case ConsoleKey.R:
                    key = (char)KeyStatus.RandomJokes;
                    break;
                case ConsoleKey.Y:
                    key = (char)KeyStatus.Yes;
                    break;
                case ConsoleKey.Backspace:
                    break;
                default:
                    break;
            }
        }
    }
}