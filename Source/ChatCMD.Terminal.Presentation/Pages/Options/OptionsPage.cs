using ChatCMD.Terminal.Presentation.TextHighlighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Presentation.Pages.Options
{
    public static class OptionsPage
    {
        public static void PrintOptions()
        {
            Console.Write("Choose an option and change it's value by pressing ");
            ColorMassage.PrintColorMessage(ConsoleColor.Green, "Enter.");

            ColorMassage.PrintColorMessage(ConsoleColor.Blue, "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            ColorMassage.PrintColorMessage(ConsoleColor.Red, "] Language - [English]");
            ColorMassage.PrintColorMessage(ConsoleColor.Red, "] Response Token Lenght - [150]");
            ColorMassage.PrintColorMessage(ConsoleColor.Red, "] Terminal Size - [Custom]");
            ColorMassage.PrintColorMessage(ConsoleColor.Green, " ] Exit");
        }
    }
}
