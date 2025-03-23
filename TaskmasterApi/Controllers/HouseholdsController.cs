using Microsoft.AspNetCore.Mvc;

namespace TaskmasterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HouseholdsController : ControllerBase
{
    private readonly ILogger<TasksController> _logger;
    private readonly TaskmasterDbContext dbContext;

    public HouseholdsController(ILogger<TasksController> logger, TaskmasterDbContext dbContext)
    {
        _logger = logger;
        this.dbContext = dbContext;
    }

    [HttpGet("{householdId}")]
    public async Task<TaskmasterModels.Household> Get([FromRoute] int householdId)
    {
        var result = dbContext.Households.Find(householdId);
        return await Task.FromResult(result);
    }

    [HttpGet("{householdId}/members")]
    public async Task<List<TaskmasterModels.Member>> GetMembers([FromRoute] int householdId)
    {
        var result = dbContext.Members.Where(i => i.HouseholdId == householdId).ToList();
        return await Task.FromResult(result);
    }

    [HttpGet("{householdId}/tasks")]
    public async Task<List<TaskmasterModels.Task>> GetTasks([FromRoute] int householdId)
    {
        var result = dbContext.Tasks.Where(i => i.HouseholdId == householdId).ToList();
        return await Task.FromResult(result);
    }
}
