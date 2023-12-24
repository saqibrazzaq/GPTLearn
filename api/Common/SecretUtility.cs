namespace api.Common
{
    public class SecretUtility
    {
        public static string? OpenAIAPIKey
        {
            get
            {
                return Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            }
        }
    }
}
