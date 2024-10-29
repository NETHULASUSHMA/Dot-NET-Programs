using Microsoft.EntityFrameworkCore;
using Mvc_1sttypeEx2_Sushma.Models;

namespace Mvc_1sttypeEx2_Sushma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var cs1 = builder.Configuration.GetConnectionString("ConStr");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(cs1));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Products}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
