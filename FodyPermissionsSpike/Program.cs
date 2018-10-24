using FodyPermissionsSpike.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FodyPermissionsSpike
{
    class Program
    {
        static void Main(string[] args)
        {
            // setup di container
            var serviceProvider = new ServiceCollection()
                .AddScoped<UserResolver>()
                .AddScoped<PermissionsResolver>()
                .AddScoped<BizFilter>()
                .BuildServiceProvider();

            // setup authorization container

            // this bit makes me a little sad
            // unfortunately you can't do constructor injection into attributes - hence this
            
            BizAuthorizedConfig.Setup(() =>
            {
                var filter = serviceProvider.GetService<BizFilter>();
                return filter.CheckPermissions;
            });

            var business = new ExampleBusinessService();

            business.ReleaseTheHounds();
            business.ReleaseTheHounds();

            business.FreeForAll();

            try
            {
                business.NoPermission();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("User tried to run something they shouldn't");
            }


            Console.WriteLine("Done");

            Console.ReadLine();
        }
    }
}
