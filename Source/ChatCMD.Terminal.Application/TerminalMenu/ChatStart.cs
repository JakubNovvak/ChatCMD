using ChatCMD.Terminal.Infrastructure.ApiConnection;
using ChatCMD.Terminal.Presentation.Pages.ChatStart;
using ChatCMD.Terminal.Presentation.TextHighlighting;
using ChatCMD.Terminal.Presentation.TextAnimations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Application.TerminalMenu
{
    internal static class ChatStart
    {
        private static string _userName = Environment.UserName;

        public static void ChatLoop()
        {
            ChatStartPage.PrintChatAdvice();

            ColorMassage.PrintColorMessage("Green", "ChatCMD>", false);

            //First Greetings Response
            var greetingsTask = Task.Run(async () => await ApiConnection.SendMessageToAPI(true, "<Greetings Respone.>"));
            var grettingsResponse = greetingsTask.GetAwaiter().GetResult();

            TextAnimations.SelfWriteText(grettingsResponse);
            Console.WriteLine("----------------------");

            while (true)
            {
                ColorMassage.PrintColorMessage("Blue", $"{_userName}>", false);

                var userInput = Console.ReadLine();

                if (userInput == "exit")
                    break;

                Console.WriteLine("----------------------");

                ColorMassage.PrintColorMessage("Green", "ChatCMD>", false);

                //Getting response
                var task = Task.Run(async () => await ApiConnection.SendMessageToAPI(false, userInput));
                var response = task.GetAwaiter().GetResult();

                TextAnimations.SelfWriteText(response);
                Console.WriteLine("----------------------");
            }

            Console.Clear();
            MainMenu.MainMenuLoop();
        }
    }
}
