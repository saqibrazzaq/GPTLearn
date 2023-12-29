namespace api.Services
{
    public interface IChatBotService
    {
        Task<string> Test(string text);
    }
}
