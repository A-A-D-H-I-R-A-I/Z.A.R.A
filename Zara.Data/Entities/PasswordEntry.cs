using System.ComponentModel.DataAnnotations;

namespace Zara.Data;

public class PasswordEntry
{
	#region Properties
	public int Id { get; set; }

	[MaxLength(100)]
	public string Application { get; set; } = string.Empty;
	[MaxLength(100)]
	public string UserName { get; set; } = string.Empty;
	[MaxLength(500)]
	public string Password { get; set; } = string.Empty;
	
	public DateTime CreatedAt { get; set; }
	public DateTime LastModifiedAt { get; set; }
	#endregion
}