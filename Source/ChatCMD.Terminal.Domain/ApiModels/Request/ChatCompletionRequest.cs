using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Domain.ApiModels.Request
{
    // "JsonPropertyName" - exact names requested by API in request's body
    public class ChatCompletionRequest
    {
        [JsonPropertyName("model")]
        public string? Model { get; set; }
        [JsonPropertyName("messages")]
        public List<RequestMessage>? Messages { get; set; }
        [JsonPropertyName("max_tokens")]
        public int MaxTokens { get; set; }
    }
}
