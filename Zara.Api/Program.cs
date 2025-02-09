namespace Zara.Api;

public class Program
{
    #region Publics
    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddServices();

        WebApplication app = builder.Build();
        
        app.UseServices();

        app.ConfigureEndpoints();

        app.Run();
    }
    #endregion
}