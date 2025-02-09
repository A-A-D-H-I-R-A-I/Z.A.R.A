namespace Zara.Api;

internal static class SwaggerExtensions
{
    #region Internals
    internal static void AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen();
    }

    internal static void ConfigureSwagger(this IApplicationBuilder builder)
    {
        builder.UseSwagger();
        builder.UseSwaggerUI();
    }
    #endregion
}