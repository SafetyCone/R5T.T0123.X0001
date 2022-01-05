using System;

using R5T.T0123;

using Instances = R5T.T0123.X0001.Instances;


namespace System
{
    public static class IRepositoryPathOperatorExtensions
    {
        /// <summary>
        /// Gets "C:\Repositories\Repository\" from "C:\Repositories\Repository\source\Solution.sln"
        /// </summary>
        public static string GetRepositoryDirectoryPathFromSolutionFilePathInSourceDirectory(this IRepositoryPathOperator _,
            string solutionFilePath)
        {
            var sourceSolutionDirectoryPath = Instances.PathOperator.GetDirectoryPathOfFilePath(solutionFilePath);

            var repositoryDirectoryPath = Instances.PathOperator.GetParentDirectoryPath(sourceSolutionDirectoryPath);
            return repositoryDirectoryPath;
        }
    }   
}
