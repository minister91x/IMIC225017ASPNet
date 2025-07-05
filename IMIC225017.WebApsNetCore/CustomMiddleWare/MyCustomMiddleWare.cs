namespace IMIC225017.WebApsNetCore.CustomMiddleWare
{
    public class MyCustomMiddleWare
    {
        RequestDelegate _next;
        public MyCustomMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Do work that can write to the Response.
             context.Response.Headers.Add("X-Custom-Header", "HACK_BY_MR_QUAN");
            await context.Response.WriteAsync("Hello from MyCustomMiddleWare!\n");
            // Call the next delegate/middleware in the pipeline
            await _next(context);
            // Do logging or other work that doesn't write to the Response.
           // await context.Response.WriteAsync("Goodbye from MyCustomMiddleWare!\n");
        }
    }
}
