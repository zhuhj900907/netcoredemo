  using Microsoft.AspNetCore.Builder;
  using Microsoft.AspNetCore.Hosting;
  using Microsoft.AspNetCore.Http;
  using Microsoft.Extensions.DependencyInjection;
  namespace ConsoleApplication
  {
      public class Startup
      {
        public void Configure(IApplicationBuilder app)
         {             
             app.Run(context =>
             {
                 return context.Response.WriteAsync("Hello World!");
             });
         }
        public void ConfigureServices(IServiceCollection services)
         {
             // 注入MVC框架             
             services.AddMvc();
         }
     }
 }