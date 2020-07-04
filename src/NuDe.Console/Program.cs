using McMaster.Extensions.CommandLineUtils;

namespace NuDe.Console
{
    class Program
    {
        static int Main(string[] args)
        {
            var services = ContainerRegistration.RegisterAndFetchAllContainers();
            
            var app = new CommandLineApplication<Command>();
            app.Conventions
                .UseDefaultConventions()
                .UseConstructorInjection(services);
            
            return app.Execute(args);
        } 
    }
}