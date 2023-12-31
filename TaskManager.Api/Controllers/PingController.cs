using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PingController
{
    [HttpGet]
    public string Ping()
    {
        return "Pong";
    }
}