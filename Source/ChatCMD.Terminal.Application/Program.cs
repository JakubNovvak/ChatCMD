using ChatCMD.Terminal.Infrastructure.ApiConnection;
using ChatCMD.Terminal.Presentation.TextHighlighting;
using ChatCMD.Terminal.Presentation.Pages;
using System;
using System.ComponentModel.Design;
using ChatCMD.Terminal.Application.TerminalMenu;

class Program
{
    static async Task Main(string[] args)
    {

        MainMenu.MainMenuLoop();

        //Console.WriteLine("Test1");
        //Console.WriteLine("Test2");
        //Console.SetCursorPosition(0, Console.CursorTop - 1);
        //ClearCurrentConsoleLine();
        

/*
        //Green color for chat's response
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("ChatCMD>");

        //Regular color for text
        Console.ResetColor();
        Console.WriteLine($"{await ApiConnection.SendMessageToAPI(true, "empty")}");

        Console.WriteLine("----------------------");


        while (true)
        {
            //Blue username in console
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{userName}>");

            //Regular color and user's input
            Console.ResetColor();
            var input = Console.ReadLine();


            Console.WriteLine("----------------------");


            //Getting response
            var response = await ApiConnection.SendMessageToAPI(false, input);

            //Green color for chat's response
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("ChatCMD>");

            //Regular color for text
            Console.ResetColor();
            Console.WriteLine($"{response}");


            Console.WriteLine("----------------------");
        }*/
    }
}