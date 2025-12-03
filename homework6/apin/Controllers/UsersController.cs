using Microsoft.AspNetCore.Mvc;

namespace apin.Controllers;
[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers(
        [FromQuery] string? search = null,
        [FromQuery] string? sortBy = null)
    {
        return Ok(new { Search = search, SortBy = sortBy });
    }
}