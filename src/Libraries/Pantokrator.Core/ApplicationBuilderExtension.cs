using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Pantokrator.Core
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder ApplicationBuilder(this IApplicationBuilder app)
        {
            var env = app.ApplicationServices.GetService<IHostingEnvironment>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }


            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            //app.UseHttpsRedirection();
            app.UseMvc();

            return app;
        }
    }
}