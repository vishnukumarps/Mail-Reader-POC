
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Primitives;
using System.Globalization;
using TestApi.Middlewares;
using TestApi.Services;

namespace TestApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<TestService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.UseMiddleware<RequestCultureMiddleware>();
            //app.UseRequestCulture1();

            //app.Use(middleware: async (HttpContext context, RequestDelegate next) =>
            //{
            //    var controllerActionDescriptor = context
            //                .GetEndpoint()
            //            .Metadata
            //            .GetMetadata<ControllerActionDescriptor>();

            //    var controllerName = controllerActionDescriptor.ControllerName;
            //    var actionName = controllerActionDescriptor.ActionName;


            //    // Call the next delegate/middleware in the pipeline.
            //    await next(context);
            //});

            //app.Run(handler: async (context) =>
            //{
            //    await context.Response.WriteAsync(
            //        $"CurrentCulture.DisplayName: {CultureInfo.CurrentCulture.DisplayName}");
            //});

            app.Run();
        }
    }
}