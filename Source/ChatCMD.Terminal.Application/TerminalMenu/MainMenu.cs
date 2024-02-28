using ChatCMD.Terminal.Presentation.Pages.MainMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Application.TerminalMenu
{
    internal static class MainMenu
    {
        public static void MainMenuLoop()
        {
            int index = 0;
            bool mainMenuFlag = true;

            while (mainMenuFlag)
            {
                MainMenuPage.PrintMainMenu(index);

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        if (index != 0)
                            index--;
                        break;

                    case ConsoleKey.DownArrow:
                        if (index != 3)
                            index++;
                        break;

                    case ConsoleKey.Enter:
                            mainMenuFlag = false;
                        break;

                    default:
                        break;
                }
                Console.Clear();
            }

            switch (index)
            {
                case 0:
                    ChatStart.ChatLoop();
                    break;

                case 1:
                    About.AboutLoop();
                    break;

                case 2:
                    Options.OptionsLoop();
                    break;

                case 3:
                    //TODO: Exit App
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("You shouldn't be here...");
                    break;
            }
        }
    }
}
