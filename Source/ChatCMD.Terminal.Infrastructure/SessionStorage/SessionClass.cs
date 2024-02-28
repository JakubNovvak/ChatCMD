using ChatCMD.Terminal.Domain.ApiModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatCMD.Terminal.Infrastructure.Cache
{
    internal static class SessionClass
    {
        internal static List<RequestMessage> Messages { get; set; } = new List<RequestMessage>();
    }
}
