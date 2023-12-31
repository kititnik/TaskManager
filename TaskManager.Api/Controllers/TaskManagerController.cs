using TaskManager.Core;
using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TaskManagerController
{
    private readonly ICore _core;
    
    [HttpGet]
    public async Task<Entities.Task> GetTaskById(Guid id)
    {
        return await _core.GetTaskById(id);
    }
    
    [HttpPost]
    public async Task<Guid> SaveTaskToData(Entities.Task task)
    {
        return await _core.SaveTaskToData(task);
    }
}