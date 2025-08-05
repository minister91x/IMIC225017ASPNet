using IMIC225017.DataAccessNetCore.DbContext;
using IMIC225017.DataAccessNetCore.IRespository;
using IMIC225017.DataAccessNetCore.Repository;
using IMIC225017.WebApsNetCore;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddDbContext<IMIC072250DbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("ConnStrIMIC_052025")));

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IMIC225017.DataAccessNetCore.IRespository.IProductRepository, IMIC225017.DataAccessNetCore.Repository.ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddSession();
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
//app.UseMyCustomMiddleware();


//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Hello world!");
//});
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
   );
app.UseSession();
app.Run();
