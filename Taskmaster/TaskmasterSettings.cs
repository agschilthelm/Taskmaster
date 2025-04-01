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

        public static string ApiUrl = "https://localhost:44332";
        //public static string ApiUrl = "https://localhost:45457";
    }
}
