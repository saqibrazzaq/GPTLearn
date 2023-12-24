namespace api.Services
{
    public class ChatBotService : IChatBotService
    {
        public string Test(string text)
        {
            return "Your input was: " + text;
        }
    }
}
