using HackatonCode8.Application.Common.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackatonCode8.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AppluCourseController : ControllerBase
{
    private readonly IApplicationDbContext _context;

    public AppluCourseController(IApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Apply(string deviceId)
    {
        return Ok();
    }
}
