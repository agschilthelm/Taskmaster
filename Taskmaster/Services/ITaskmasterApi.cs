using Refit;
using TaskmasterModels;
namespace Taskmaster.Services
{
    public interface ITaskmasterApi
    {
        [Get("/tasks")]
        Task<List<TaskmasterModels.Task>> GetTasks();

        [Get("/tasks/{taskId}")]
        Task<TaskmasterModels.Task> GetTask(int taskId);

        [Get("/households/{householdId}/members")]
        Task<List<Member>> GetMembers(int householdId);

        [Get("/households/{householdId}/tasks")]
        Task<List<TaskmasterModels.Task>> GetHouseholdTasks(int householdId);

        [Get("/members/{memberId}")]
        Task<Member> GetMember(int memberId);
    }
}
