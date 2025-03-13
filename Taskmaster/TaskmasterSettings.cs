using System.Text.Json;

namespace Taskmaster
{
    public class TaskmasterSettings
    {
        public static JsonSerializerOptions GetJsonSerializerOptions()
        {
            return new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };
        }
    }
}
