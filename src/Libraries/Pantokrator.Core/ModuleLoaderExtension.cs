using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Pantokrator.Core
{
    public static class ModuleLoaderExtension
    {
        public static IServiceCollection ModuleLoader(this IServiceCollection services)
        {
            var mvcBuilder = services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var serviceProvider = services.BuildServiceProvider();
            var config = serviceProvider.GetService<IConfiguration>();
            var hostingEnv = serviceProvider.GetService<IHostingEnvironment>();

            var modulesPath = $@"{hostingEnv.ContentRootPath}\{config.GetValue<string>("Settings:ModulesPath")}";

            var modules = LoadModules(modulesPath);

            foreach (var assembly in modules)
            {
                mvcBuilder.AddApplicationPart(assembly);
            }

            return services;
        }


        private static Assembly[] LoadModules(string modulesPath)
        {
            string[] files = Directory.GetFiles(modulesPath, "*.dll", SearchOption.AllDirectories);
            var assemblies = files.Select(Assembly.LoadFile);

            var moduleAssembly = (from assembly in assemblies
                from type in assembly.GetTypes()
                where type.BaseType == typeof(Controller)
                select assembly).ToArray();

            return moduleAssembly;
        }
    }
}