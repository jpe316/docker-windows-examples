using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace GreetingService
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new WebHostBuilder()
                .UseStartup<Program>()
                .UseKestrel()
                .UseUrls("http://*:8081")
                .Build())
            {
                host.Run();
            }
        }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async ctx =>
            {
                ctx.Response.ContentType = "text/plain";
                await ctx.Response.WriteAsync("Hello, World!");
            });
        } 
    }
}
