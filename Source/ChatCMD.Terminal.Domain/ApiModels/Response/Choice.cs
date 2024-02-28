using ChatCMD.Terminal.Domain.ApiModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Domain.ApiModels.Response
{
    // "JsonPropertyName" - exact names requested by API in response body
    public class Choice
    {
        [JsonPropertyName("index")]
        public int Index { get; set; }

        [JsonPropertyName("message")]
        public RequestMessage? RequestMessage { get; set; }

        [JsonPropertyName("logprobs")]
        public object? Logprobs { get; set; }

        [JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }
    }
}
