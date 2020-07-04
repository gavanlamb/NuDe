using System.Collections.Generic;
using System.IO;
using NuDe.Exceptions;
using NuDe.Services.Interfaces;

namespace NuDe.Services
{
    /// <summary>
    /// Class for all directory related methods
    /// </summary>
    public class DirectoryService : IDirectoryService
    {
        /// <summary>
        /// The list of file extension to search for.
        /// </summary>
        private static readonly List<string> FileExtension = new List<string>
        {
            ".sln",
            ".csproj",
            ".fsproj",
            ".vbproj"
        };

        /// <summary>
        /// Checks the validity of the path parameter and tries to find
        /// .sln, .csproj, .fsproj, .vbproj files in the specified path or any sub folders.
        /// </summary>
        /// <param name="path">The path to directory and sub folders to scan.</param>
        /// <returns>Paths to project and solutions files.</returns>
        /// <exception cref="PathIsAFileException">The supplied path is a path to a file.</exception>
        /// <exception cref="DirectoryNotFoundException">The directory was not found.</exception>
        public List<string> FindAllFilesOfExtensionsInDirectory(string path)
        {
            //Make sure this is not a file
            if(File.Exists(path))
                throw new PathIsAFileException($"Directory: {path} is a file");
            
            //Make sure this is a directory
            if(Directory.Exists(path))
                throw new DirectoryNotFoundException($"Directory: {path} was not found");
            
            var directories = new List<string>();
        
            foreach (var fileExtension in FileExtension)
                directories.AddRange(Directory.GetFiles(path, fileExtension, SearchOption.AllDirectories));
        
            return directories;
        }
    }
}