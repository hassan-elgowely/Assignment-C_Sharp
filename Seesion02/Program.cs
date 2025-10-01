using Microsoft.AspNetCore.Routing.Constraints;

namespace Seesion02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");  // base URL

            #region Route Mapping / EndPoint Mapping => delegate ( Routing Type : [ static , dynamic , mixed ] Segment )
            //app.MapGet("/mvc", () => "Architecture pattern => Model , View , Controller");   // Static segment

            //app.MapGet("/{naything}", () => "Hello Mono");  // Dynamic segment  => can write any thing  => and return "Hello Mono"

            //app.MapGet("/Text{text}", async (context) =>
            //{
            //    var text = context.GetRouteValue("text");
            //    await context.Response.WriteAsync($"Hello : {text}");       // Dynamic segment 
            //});

            //app.MapGet("/T{text}", async (context) =>
            //{
            //    var text = context.GetRouteValue("text");
            //    await context.Response.WriteAsync($"text : {text}");       // mixed segment 
            //});

            //app.MapGet("{age}", async (context) =>                                   // this way usually use to validation
            //{
            //    var Age = context.GetRouteValue("age").ToString();
            //    if (int.TryParse(Age, out int age) && age >= 18 && age <= 99)
            //        await context.Response.WriteAsync($"Your age Valid : {age} ");
            //    else
            //        await context.Response.WriteAsync($"Your age InValid : {age} ");

            //});

            //app.MapGet("/{name}", async (novalidation) =>                                                //(other way without validation )
            //{
            //    await novalidation.Response.WriteAsync($"hello : {novalidation.Request.RouteValues["name"]}");  
            //});

            //app.MapGet("/direct{name}", async (context) =>
            //{
            //    await context.Response.WriteAsync($"Hello  {context.Request.RouteValues["name"]}");       // mixed segment  ( other way without validation )
            //});
            #endregion

            #region Route Mapping / EndPoint Mapping Methods => Controller , Action 
            //app.MapControllerRoute(name:"default",
            //                       pattern: "{Controller=movies}/{Action=index}/{Id:int:regex(^[1-9][0-9]$)?}"                  // controller , movies => called to variable segment
            //                       //constraints: /*new {Id = new IntRouteConstraint()},*/ new { Id = "^[1-9][0-9]$" },
            //                       //defaults: new { Controller = "Movies", Action = "GetMovie" }
            //                       );

            //app.MapControllerRoute(name: "default",
            //                       pattern: "static/{Controller=movies}/{Action=deletemovie}/{Id:int:regex(^\\d{{2}}$)?}"               // default : without double quotation  , (detact _space)
            //    );
            #endregion

            app.UseStaticFiles();
            app.MapControllerRoute(name:"default"
                                   ,pattern: "{controller=home}/{action=index}");

            app.Run();
        }
    }
}
