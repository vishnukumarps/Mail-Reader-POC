using POC.Helper;

namespace POC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.Configure<ConfigSettings>(builder.Configuration.GetSection("settings"));
            builder.Services.AddTransient<GraphHelper>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.Use(middleware: (HttpContext context, RequestDelegate next) =>
            {
                
                return next(context);
            });
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Authenticate}/{id?}");

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello world!");
            });

            app.Run();
        }
    }
}