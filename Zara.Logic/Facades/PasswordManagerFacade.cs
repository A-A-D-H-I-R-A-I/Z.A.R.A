using Zara.Common;
using Zara.Data;

namespace Zara.Logic;

public class PasswordManagerFacade : IPasswordManagerFacade
{
    #region Fields
    private readonly PasswordManagerBL _blPasswordManager;
    #endregion

    #region Constructors
    public PasswordManagerFacade(ZaraDataContext context)
    {
        _blPasswordManager = new PasswordManagerBL(context);
    }
    #endregion

    #region Publics
    public IEnumerable<PasswordEntryDto> GetAllPasswords()
    {
        return _blPasswordManager.GetAllPasswords();
    }

    public async Task<PasswordEntryDto?> GetByApplication(string application)
    {
        return await _blPasswordManager.GetByApplication(application);
    }

    public async Task<PasswordEntryDto> AddPassword(PasswordEntryDto password_entry)
    {
        return await _blPasswordManager.AddPassword(password_entry);
    }

    public async Task<PasswordEntryDto> UpdatePassword(string application, PasswordEntryDto password_entry)
    {
        return await _blPasswordManager.UpdatePassword(application, password_entry);
    }

    public async Task<PasswordEntryDto> DeletePassword(string application)
    {
        return await _blPasswordManager.DeletePassword(application);
    }
    #endregion
}