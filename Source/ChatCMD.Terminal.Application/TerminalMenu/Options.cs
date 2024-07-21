using ChatCMD.Terminal.Presentation.Pages.About;
using ChatCMD.Terminal.Presentation.Pages.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Application.TerminalMenu
{
    internal static class Options
    {
        public static void OptionsLoop()
        {
            OptionsPage.PrintOptions();

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
