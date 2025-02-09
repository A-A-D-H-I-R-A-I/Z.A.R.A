namespace Zara.Api;

internal static class Startup
{
    #region Internals
    internal static void AddServices(this IServiceCollection services)
    {
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
}