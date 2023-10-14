using Microsoft.AspNetCore.Mvc.Controllers;
using System.Globalization;
using TestApi.Services;

namespace TestApi.Middlewares;

public class RequestCultureMiddleware
{
    private readonly RequestDelegate _next;

    public RequestCultureMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, TestService testService)
    {
        HttpRequest? request=context.Request;

        ControllerActionDescriptor? controllerActionDescriptor = context.GetEndpoint()?.Metadata.GetMetadata<ControllerActionDescriptor>();

        string? controllerName = controllerActionDescriptor?.ControllerName;
        string? actionName = controllerActionDescriptor?.ActionName;

        int no=testService.GetMeARandomNumber();

        // Call the next delegate/middleware in the pipeline.
        await _next(context);
    }
}
public static class RequestCultureMiddlewareExtensions
{
    public static IApplicationBuilder UseRequestCulture1(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestCultureMiddleware>();
    }
}
