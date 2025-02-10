using Microsoft.AspNetCore.Mvc;

namespace Zara.Api;

[ApiController]
[Route("api/password-manager")]
public class PasswordManagerController : ControllerBase
{
	#region Publics
	[HttpGet]
	public IActionResult GetAllPasswords()
	{
		return Ok();
	}

	[HttpGet("{application}")]
	public IActionResult GetByApplication(string application)
	{
		return Ok();
	}

	[HttpPost]
	public IActionResult AddPassword()
	{
		return CreatedAtAction(nameof(GetByApplication), new { application = string.Empty }, null);
	}

	[HttpPut]
	public IActionResult UpdatePassword()
	{
		return NoContent();
	}

	[HttpDelete]
	public IActionResult DeletePassword()
	{
		return NoContent();
	}
	#endregion
}