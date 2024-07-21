using ChatCMD.Terminal.Presentation.TextHighlighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Presentation.Pages.About
{
    public static class AboutPage
    {
        public static void PrintAbout()
        {
            ColorMassage.PrintColorMessage(ConsoleColor.Green, "ChatCMD", false);
            Console.WriteLine(" is an amator project of recreating basic functionalities of the real ChatGPT ChatBot.\n" +
                              "The Project uses OpenAI completion API with the Free Plan API Key. At this stage of\n" +
                              "development, ChatCMD offers single chat converstaion with the language model, with\n" +
                              "application's session based chat history."
                );
            ColorMassage.PrintColorMessage(ConsoleColor.Blue, "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            ColorMassage.PrintColorMessage(ConsoleColor.Green, " ] Exit");
        }
    }
}
