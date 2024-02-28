using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Reflection;
using System.Xml.Linq;
using ChatCMD.Terminal.Domain.ApiModels;
using ChatCMD.Terminal.Domain.ApiModels.Request;
using ChatCMD.Terminal.Domain.ApiModels.Response;
using ChatCMD.Terminal.Infrastructure.Cache;

namespace ChatCMD.Terminal.Infrastructure.ApiConnection
{
    public class ApiConnection
    {
        public async static Task<string> SendMessageToAPI(bool isFirstMessage, string? userChatMessage)
        {
            var apiConfigurationData = ReadConfigurationFile();

            //TODO: Call method from Application, that will exit App/handle error
            if (apiConfigurationData == null)
                return "Error: Can't find/open the configuration file.";

            string? requestMessageContent;

            if (!isFirstMessage)
                requestMessageContent = userChatMessage;
            else
                requestMessageContent = apiConfigurationData.Greetings;


            SessionClass.Messages.Add
                (
                    new RequestMessage()
                    {
                        Role = "user",
                        Content = requestMessageContent
                    }
                );

            ChatCompletionRequest completitionRequest = new()
            {
                Model = "gpt-3.5-turbo",
                MaxTokens = 150,
                Messages = SessionClass.Messages
            };

            var completionRequestStringified = JsonSerializer.Serialize(completitionRequest);


            using (var httpRequest = new HttpRequestMessage(HttpMethod.Post, apiConfigurationData.ApiUrl))
            {
                //Request Setup
                httpRequest.Headers.Add("Authorization", $"Bearer {apiConfigurationData.ApiKey}");
                httpRequest.Content = new StringContent(completionRequestStringified, Encoding.UTF8, "application/json");

                //Sending and getting response
                var httpClient = new HttpClient();

                HttpResponseMessage? httpResponse = await httpClient.SendAsync(httpRequest);
                httpResponse.EnsureSuccessStatusCode();

                var completionResponse = httpResponse.IsSuccessStatusCode 
                    ? JsonSerializer.Deserialize<ChatCompletionResponse>(await httpResponse.Content.ReadAsStringAsync()) 
                    : null;

                //TODO: Call method from Application, that will exit App/handle error
                if (completionResponse == null)
                    return "Error: The response was empty...";

                //TODO: Call method from Application, that will exit App/handle error
                if (completionResponse.Choices?[0]?.RequestMessage?.Content == null)
                    return "Error: The resposnse was ok, but there is no chat content.";

                //Manual Dispose to avoid nested usings
                httpClient.Dispose();

                SessionClass.Messages.Add
                    (
                        new RequestMessage()
                        {
                            Role = "assistant",
                            Content = completionResponse.Choices?[0]?.RequestMessage?.Content!
                        }
                    );

                return completionResponse.Choices?[0]?.RequestMessage?.Content!;
            }       
        }


        private static APIConfiguration? ReadConfigurationFile()
        {
            //TODO: Development-wise proper solution - for Production should be changed to Working Directory
            string apiConfigurationJsonFile = Path.GetDirectoryName(Directory.GetParent(
                Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName)
                + "\\ChatCMD.Terminal.Infrastructure\\ApiConnection\\apiconfig.json";


            if (!File.Exists(apiConfigurationJsonFile) || new FileInfo(apiConfigurationJsonFile).Length == 0)
                return null;

            var apiConfigurationJsonContent = File.ReadAllText(apiConfigurationJsonFile);
            var apiConfigurationData = JsonSerializer.Deserialize<APIConfiguration>(apiConfigurationJsonContent);

            if (apiConfigurationData == null)
                return null;

            return apiConfigurationData;
        }
    }
}
