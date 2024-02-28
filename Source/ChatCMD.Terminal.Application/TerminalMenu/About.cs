using ChatCMD.Terminal.Presentation.Pages.About;
using ChatCMD.Terminal.Presentation.TextHighlighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Application.TerminalMenu
{
    internal static class About
    {
        public static void AboutLoop()
        {
            AboutPage.PrintAbout();

            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    break;
            }

            Console.Clear();
            MainMenu.MainMenuLoop();
        }
    }
}
