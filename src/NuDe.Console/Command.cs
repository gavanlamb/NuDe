using System;
using McMaster.Extensions.CommandLineUtils;
using NuDe.Services.Interfaces;

namespace NuDe.Console
{
    /// <summary>
    /// The main command class 
    /// </summary>
    [Command(Name = "NuDe", Description = "An app to find all those outdated dependencies.")]
    [HelpOption("-?")]
    public class Command
    {
        private readonly IDirectoryService _directoryService;
        
        /// <summary>
        /// Creates a new instance of command.
        /// </summary>
        /// <param name="directoryService">Service to use for all the directory interactions</param>
        public Command(IDirectoryService directoryService)
        {
            _directoryService = directoryService;
        }

        /// <summary>
        /// The path of the folder to scan.
        /// </summary>
        [Option]
        public string Path { get; set; }
        
        /// <summary>
        /// The method to call for the execution of the command.
        /// </summary>
        private void OnExecute()
        {
            //Get the current directory if the directory hasn't been set.
            if (string.IsNullOrEmpty(Path))
                Path =  System.IO.Directory.GetCurrentDirectory();

            try
            {
                var pathsToSoultionAndProjectFiles = _directoryService.FindAllFilesOfExtensionsInDirectory(Path);

                foreach (var pathToSoultionAndProjectFile in pathsToSoultionAndProjectFiles)
                {
                    System.Console.WriteLine(pathToSoultionAndProjectFile);
                }
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message);
            }
        }
    }
}
