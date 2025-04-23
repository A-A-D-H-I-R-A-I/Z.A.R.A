using Microsoft.EntityFrameworkCore;

namespace Zara.Data;

public class ZaraDataContext : DbContext
{
	#region Properties
	public DbSet<PasswordEntry> PasswordEntries { get; set; }
	#endregion

	#region Constructors
	public ZaraDataContext(DbContextOptions<ZaraDataContext> options) : base(options)
	{
	}
	#endregion
}