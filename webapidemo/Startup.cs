  using Microsoft.AspNetCore.Builder;
  using Microsoft.AspNetCore.Hosting;
  using Microsoft.AspNetCore.Http;
  using Microsoft.Extensions.DependencyInjection;
  using Microsoft.Extensions.Logging;
  namespace ConsoleApplication
  {
      public class Startup
      {
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
         {             
            //  app.Run(context =>
            //  {
            //      return context.Response.WriteAsync("Hello World!");
            //  });
             // 设置日志最小级别Warning
            loggerFactory.AddConsole(LogLevel.Warning);
            loggerFactory.AddConsole();
            loggerFactory.AddDebug();
             app.UseMvc();
         }
        public void ConfigureServices(IServiceCollection services)
         {
             // 注入MVC框架             
             services.AddMvc();
         }
     }
 }