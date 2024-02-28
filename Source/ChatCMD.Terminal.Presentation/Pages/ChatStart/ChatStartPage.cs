using ChatCMD.Terminal.Presentation.TextHighlighting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Presentation.Pages.ChatStart
{
    public static class ChatStartPage
    {
        public static void PrintChatAdvice()
        {
            ColorMassage.PrintColorMessage("none", "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ColorMassage.PrintColorMessage("none", "|", false);
            ColorMassage.PrintColorMessage("Green", "! Type \"exit\" to get back the to main menu !", false);
            ColorMassage.PrintColorMessage("none", "|");
            ColorMassage.PrintColorMessage("none", "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
    }
}
