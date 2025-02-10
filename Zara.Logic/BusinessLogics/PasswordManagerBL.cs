using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Zara.Common;
using Zara.Data;

namespace Zara.Logic;

internal class PasswordManagerBL
{
    #region Fields
    private readonly ZaraDataContext _context;
    #endregion

    #region Constructors
    public PasswordManagerBL(ZaraDataContext context)
    {
        _context = context;
    }
    #endregion

    #region Publics
    internal IEnumerable<PasswordEntryDto> GetAllPasswords()
    {
        IEnumerable<PasswordEntryDto> password_entries = _context.PasswordEntries.Select(x => x.ToPasswordEntryDto()).AsEnumerable();

        return password_entries;
    }

    internal async Task<PasswordEntryDto?> GetByApplication(string application)
    {
        PasswordEntry? password_entry = await _context.PasswordEntries.FirstOrDefaultAsync(x => x.Application.Equals(application));

        return password_entry?.ToPasswordEntryDto();
    }

    internal async Task<PasswordEntryDto> AddPassword(PasswordEntryDto password_entry)
    {
        PasswordEntry entry = new PasswordEntry(password_entry);

        EntityEntry<PasswordEntry> result = await _context.PasswordEntries.AddAsync(entry);

        return result.Entity.ToPasswordEntryDto();
    }

    internal async Task<PasswordEntryDto> UpdatePassword(string application, PasswordEntryDto password_entry)
    {
        PasswordEntry? entry = await _context.PasswordEntries.FirstOrDefaultAsync(x => x.Application.Equals(application));

        if (entry is not null)
        {
            PasswordEntry updated_entry = new PasswordEntry(password_entry);

            EntityEntry<PasswordEntry> result = _context.PasswordEntries.Update(updated_entry);

            return result.Entity.ToPasswordEntryDto();
        }

        throw new ArgumentOutOfRangeException();
    }

    internal async Task<PasswordEntryDto> DeletePassword(string application)
    {
        PasswordEntry? password_entry = await _context.PasswordEntries.FirstOrDefaultAsync(x => x.Application.Equals(application));

        if (password_entry is not null)
        {
            EntityEntry<PasswordEntry> result = _context.PasswordEntries.Remove(password_entry);

            return result.Entity.ToPasswordEntryDto();
        }

        throw new ArgumentOutOfRangeException();
    }
    #endregion
}