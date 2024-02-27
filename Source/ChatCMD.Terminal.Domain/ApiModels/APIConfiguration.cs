using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Domain.ApiModels
{
    public class APIConfiguration
    {
        public string? ApiKey { get; set; }
        public string? ApiUrl { get; set; }
        public string? Greetings { get; set; }
    }
}
