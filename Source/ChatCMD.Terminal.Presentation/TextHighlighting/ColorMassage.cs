using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Presentation.TextHighlighting
{
    //Just the "quality of life" functions
    public static class ColorMassage
    {
        public static void PrintColorMessage(string color, string message)
        {
            PrintingColorBody(color);

            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintColorMessage(string color, string message, bool addNewLineFlag)
        {
            PrintingColorBody(color);

            if(addNewLineFlag)
                Console.WriteLine(message);
            else
                Console.Write(message);

            Console.ResetColor();
        }

        private static void PrintingColorBody(string color)
        {
            switch (color)
            {
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case "Gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                default:
                    break;
            }
        }

        public static void PrintWhiteBackground(string content)
        {
            //Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(content);
            Console.ResetColor();
        }
    }
}
