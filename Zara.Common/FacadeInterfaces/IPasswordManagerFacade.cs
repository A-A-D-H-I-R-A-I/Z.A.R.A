namespace Zara.Common;

public interface IPasswordManagerFacade
{
    IEnumerable<PasswordEntryDto> GetAllPasswords();
    Task<PasswordEntryDto?> GetByApplication(string application);

    Task<PasswordEntryDto> AddPassword(PasswordEntryDto password_entry);
    Task<PasswordEntryDto> UpdatePassword(string application, PasswordEntryDto password_entry);
    Task<PasswordEntryDto> DeletePassword(string application);
}
