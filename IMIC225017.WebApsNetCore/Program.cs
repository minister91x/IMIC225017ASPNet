using IMIC225017.WebApsNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.Use(async (context, next) =>
{
    // Do work that can write to the Response.
    await next.Invoke();
    // Do logging or other work that doesn't write to the Response.
});

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello world!");
//});

//app.UseMiddleware<IMIC225017.WebApsNetCore.CustomMiddleWare.MyCustomMiddleWare>();
app.UseMyCustomMiddleware();


app.Run(async context =>
{
    await context.Response.WriteAsync("Hello world!");
});
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
