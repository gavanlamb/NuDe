using Microsoft.Extensions.DependencyInjection;
using NuDe.Extensions;

namespace NuDe.Console
{
    /// <summary>
    /// For services related functions for the NuDe project.
    /// </summary>
    public class ContainerRegistration
    {
        /// <summary>
        /// Register all of NuDe's services to the applications ServiceCollection
        /// </summary>
        /// <param name="services">Collection of registered services.</param>
        public static ServiceProvider RegisterAndFetchAllContainers()
        {
            var services = new ServiceCollection();
            
            services.AddNuDe();

            return services.BuildServiceProvider();
        }
    }
}