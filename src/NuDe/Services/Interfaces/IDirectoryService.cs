using System.Collections.Generic;

namespace NuDe.Services.Interfaces
{
    /// <summary>
    /// interface for all directory related methods
    /// </summary>
    public interface IDirectoryService
    {
        /// <summary>
        /// Checks the validity of the path parameter and tries to find
        /// .sln, .csproj, .fsproj, .vbproj files in the specified path or any sub folders.
        /// </summary>
        /// <param name="path">The path to directory and sub folders to scan.</param>
        /// <returns>Paths to project and solutions files.</returns>
        List<string> FindAllFilesOfExtensionsInDirectory(string path);
    }
}