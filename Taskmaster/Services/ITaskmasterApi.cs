using Refit;
namespace Taskmaster.Services
{
    public interface ITaskmasterApi
    {
        [Get("/tasks")]
        Task<List<TaskmasterModels.Task>> GetTasks();
    }
}
