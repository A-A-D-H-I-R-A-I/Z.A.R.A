namespace Zara.Common;

public class PasswordEntryDto
{
    #region Publics
    public int Id { get; set; }

    public string Application { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
    public DateTime LastModifiedAt { get; set; }
    #endregion
}