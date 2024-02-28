using ChatCMD.Terminal.Infrastructure.ApiConnection;

class Program
{
    static async Task Main(string[] args)
    {
        //Show Computer's name
        string userName = Environment.UserName;

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
        }
    }
}