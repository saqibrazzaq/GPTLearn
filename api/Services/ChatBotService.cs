using OpenAI.Interfaces;
using OpenAI.Managers;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels;

namespace api.Services
{
    public class ChatBotService : IChatBotService
    {
        private readonly IOpenAIService _openAIService;

        public ChatBotService(IOpenAIService openAIService)
        {
            _openAIService = openAIService;
        }

        public async Task<string> Test(string text)
        {
            var completionResult = await _openAIService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = new List<ChatMessage>
                {
                    ChatMessage.FromSystem("You are a helpful assistant."),
                    ChatMessage.FromUser(text),
                },
                Model = Models.Gpt_3_5_Turbo
            });
            if (completionResult.Successful)
            {
                return (completionResult.Choices.First().Message.Content);
            }
            else
            {
                if (completionResult.Error == null)
                {
                    throw new Exception("Unknown Error");
                }

                return ($"{completionResult.Error.Code}: {completionResult.Error.Message}");
            }
        }
    }
}
