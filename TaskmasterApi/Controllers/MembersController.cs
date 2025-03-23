using Microsoft.AspNetCore.Mvc;

namespace TaskmasterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MembersController : ControllerBase
{
    private readonly ILogger<TasksController> _logger;
    private readonly TaskmasterDbContext dbContext;

    public MembersController(ILogger<TasksController> logger, TaskmasterDbContext dbContext)
    {
        _logger = logger;
        this.dbContext = dbContext;
    }

    [HttpGet("{memberId}")]
    public async Task<TaskmasterModels.Member> GetMember([FromRoute] int memberId)
    {
        var member = dbContext.Members.Find(memberId);
        return await Task.FromResult(member);
    }
}
