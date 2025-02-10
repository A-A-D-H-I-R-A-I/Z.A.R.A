using Microsoft.EntityFrameworkCore;
using Zara.Data;

namespace Zara.Api;

internal static class Startup
{
	#region Internals
	internal static void AddServices(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDatabaseContext(configuration);

		services.AddControllers();

		services.AddEndpointsApiExplorer();

		services.AddSwagger();
	}

	internal static void UseServices(this IApplicationBuilder builder)
	{
		builder.ConfigureSwagger();

		builder.UseHttpsRedirection();

		builder.UseAuthorization();
	}

	internal static void ConfigureEndpoints(this IEndpointRouteBuilder routes)
	{
		routes.MapControllers();
	}
	#endregion

	#region Privates
	private static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<ZaraDataContext>(options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
	}
	#endregion
}