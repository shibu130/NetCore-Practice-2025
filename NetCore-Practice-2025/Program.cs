using NetCore_Practice_2025.Middleware;

var builder = WebApplication.CreateBuilder(args);
// adding custom middleware
builder.Services.AddTransient<CustomMiddleware>();
var app = builder.Build();

app.Use( async ( HttpContext context, RequestDelegate next ) =>
{
    await context.Response.WriteAsync("hello");
    await next(context);
});


//app.UseMiddleware<CustomMiddleware>();

// using extension methods
app.UseCustomMiddleware();

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("hello world");
});

app.Run();

