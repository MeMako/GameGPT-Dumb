using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Standard.AI.OpenAI;
using Standard.AI.OpenAI.Models.Services.Foundations.ChatCompletions;

namespace yes1
{
    public interface IOpenAIProxy
    {
        Task<ChatCompletionMessage[]> SendChatMessage(string message);

    }
}
