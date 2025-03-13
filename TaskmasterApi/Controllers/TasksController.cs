using Microsoft.AspNetCore.Mvc;

namespace TaskmasterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private readonly ILogger<TasksController> _logger;

    public TasksController(ILogger<TasksController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<List<TaskmasterModels.Task>> Get()
    {
        var tasks = Enumerable.Range(1, 5).Select(index => new TaskmasterModels.Task
        {
            ID = index,
            Name = $"Task #{index}"
        })
        .ToList();

        return await Task.FromResult(tasks);
    }
}
