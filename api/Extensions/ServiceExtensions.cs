using api.Common;
using api.Services;
using Microsoft.Extensions.DependencyInjection;
using OpenAI.Extensions;

namespace api.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureEnvironmentVariables(this IServiceCollection services)
        {
            DotNetEnv.Env.Load(Path.Combine(Directory.GetCurrentDirectory(), ".env"));
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IChatBotService, ChatBotService>();
            services.AddOpenAIService(settings => { settings.ApiKey = SecretUtility.OpenAIAPIKey; });
        }
    }
}
