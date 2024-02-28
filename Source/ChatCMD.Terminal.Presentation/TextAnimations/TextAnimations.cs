using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Presentation.TextAnimations
{
    public static class TextAnimations
    {
        public static void SelfWriteText(string textToAnimate)
        {
            foreach (var singleChat in textToAnimate) 
            {
                Console.Write(singleChat);
                Thread.Sleep(10);
            }

            Console.WriteLine();
        }
    }
}
