
//???????? ??? ?????????
using slope.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<Ipoint, Linecalculator>();
        var app = builder.Build();

        app.UseStaticFiles();

        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Point}/{action=Index}");

        app.Run();
    }
}