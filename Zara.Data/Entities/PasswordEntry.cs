using System.ComponentModel.DataAnnotations;
using Zara.Common;

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

    #region Constructors
    public PasswordEntry()
    {
    }

    public PasswordEntry(PasswordEntryDto password_entry)
    {
        Application = password_entry.Application;
        UserName = password_entry.UserName;
        Password = password_entry.Password;
        CreatedAt = password_entry.CreatedAt;
        LastModifiedAt = password_entry.LastModifiedAt;
    }
    #endregion

    #region Publics
    public PasswordEntryDto ToPasswordEntryDto()
    {
        return new PasswordEntryDto
        {
            Id = Id,
            Application = Application,
            UserName = UserName,
            Password = Password,
            CreatedAt = CreatedAt,
            LastModifiedAt = LastModifiedAt
        };
    }
    #endregion
}