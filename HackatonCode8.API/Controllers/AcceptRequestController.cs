using HackatonCode8.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HackatonCode8.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AcceptRequestController : ControllerBase
{
    private readonly IApplicationDbContext _context;
    public AcceptRequestController(IApplicationDbContext context)
    {
        _context = context;
    }
    [HttpPost]
    public async Task<IActionResult> Accept(string deviceId, DateTime appointmentDate)
    {
        var user = _context.Users.FirstOrDefault(x => x.DeviceId == deviceId);
        var applicant = _context.Applicants.FirstOrDefault(x => x.UserId == user.Id);

        user.AppointmentDate = appointmentDate;
        applicant.Status = true;
        

        await _context.SaveChangesAsync();
        return Ok(user);
    }
}
