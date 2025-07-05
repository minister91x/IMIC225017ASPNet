using IMIC225017.WebApsNetCore.CustomMiddleWare;

namespace IMIC225017.WebApsNetCore
{
    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyCustomMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyCustomMiddleWare>();
        }
    }
}
