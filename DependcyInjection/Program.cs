using DependcyInjection.Models;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddMvc();
        builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
        var app = builder.Build();
        app.UseRouting();
        app.MapControllerRoute(
            name: "default", 
            pattern: "{controller=Home}/{action=Index}/{id?}" 
        );
        app.Run();
    }
}