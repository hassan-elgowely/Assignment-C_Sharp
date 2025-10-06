using DemoDAL.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace DemoPL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddScoped<ApplicationDbContext>();
                  //option.UseSqlServer("ConnectionString")
            builder.Services.AddDbContext<ApplicationDbContext>(option =>
                  option.UseSqlServer(builder.Configuration.GetConnectionString("defaultconnectionstring"))
             //option.UseSqlServer(builder.Configuration["ConnectionString:defaultconnectionstring"])
             //option.UseSqlServer(builder.Configuration.GetSection("ConnectionString")["defaultconnectionstring"]
             );


            builder.Services.AddControllersWithViews();

            var app = builder.Build();




            //app.MapGet("/test{thing}", async (context) => { await context.Response.WriteAsync($"HI : {context.Request.RouteValues["thing"]}"); });

            //Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }



            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(name: "test", pattern: "{controller=test}/{action=text}/{id:int?}");


            app.Run();
        }
    }
}
