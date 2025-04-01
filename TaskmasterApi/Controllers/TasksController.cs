using Microsoft.AspNetCore.Mvc;

namespace TaskmasterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private readonly ILogger<TasksController> _logger;
    private readonly TaskmasterDbContext dbContext;

    public TasksController(ILogger<TasksController> logger, TaskmasterDbContext dbContext)
    {
        _logger = logger;
        this.dbContext = dbContext;
    }

    [HttpGet]
    public async Task<List<TaskmasterModels.Task>> Get()
    {
        var tasks = dbContext.Tasks.Where(i => i.HouseholdId == 1).ToList();
        return await Task.FromResult(tasks);
    }

    [HttpGet("{taskId}")]
    public async Task<TaskmasterModels.Task> GetTask([FromRoute] int taskId)
    {
        var task = dbContext.Tasks.Find(taskId);
        return await Task.FromResult(task);
    }

    [HttpPost("saveTask")]
    public async Task CreateTask([FromBody] TaskmasterModels.Task task)
    {
        TaskmasterModels.Task dbTask;
        if (task.IsNew)
        {
            dbTask = new TaskmasterModels.Task();
            dbTask.HouseholdId = task.HouseholdId;
        }
        else
        {
            dbTask = dbContext.Tasks.Find(task.ID);

        }
    }
}
