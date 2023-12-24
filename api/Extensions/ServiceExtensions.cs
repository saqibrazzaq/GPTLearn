using api.Services;

namespace api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IChatBotService, ChatBotService>();
        }
    }
}
