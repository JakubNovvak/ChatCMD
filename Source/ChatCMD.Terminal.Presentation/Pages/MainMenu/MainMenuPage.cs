using ChatCMD.Terminal.Presentation.TextHighlighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Presentation.Pages.MainMenu
{
    public static class MainMenuPage
    {
        private static string[] _menuOptions { get; set; } = ["] Start Chatting", "] About ChatCMD", "] Options", "] Exit"];
        private static string[] _menuGraphic { get; set; } = [
            "   ________          __  ________  _______ ",
            "  / ____/ /_  ____ _/ /_/ ____/  |/  / __ \\",
            " / /   / __ \\/ __ `/ __/ /   / /|_/ / / / /",
            "/ /___/ / / / /_/ / /_/ /___/ /  / / /_/ / ",
            "\\____/_/ /_/\\__,_/\\__/\\____/_/  /_/_____/  ",
            "\n  Your personal ChatBot in the Terminal!"
            ];

        public static void PrintMainMenu(int index)
        {
            ColorMassage.PrintColorMessage("Blue", "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var graphicLine in _menuGraphic)
                ColorMassage.PrintColorMessage("Green", graphicLine);

            ColorMassage.PrintColorMessage("Blue", "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Choose your option:\n");

            for (int i = 0; i < _menuOptions.Length; i++)
            {
                if (i == index)
                    ColorMassage.PrintColorMessage("Green", " " + _menuOptions[i]);
                else
                    Console.WriteLine(_menuOptions[i]);
            }

        }
    }
}
