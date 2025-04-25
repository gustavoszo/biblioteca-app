using System;

namespace LibraryApp.Helpers
{
    internal static class DirectoriesManager
    {
        public static bool DirectoryExists()
        {
            return Directory.Exists(AppPathsHelper.BasePath);
        }

        public static void CreateDirectories()
        {
            try
            {
                Directory.CreateDirectory(AppPathsHelper.BasePath);
                File.Create(AppPathsHelper.UserFilePath).Close();
                File.Create(AppPathsHelper.DbFilePath).Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void RemoveDirectories()
        {
            try
            {
                Directory.Delete(AppPathsHelper.BasePath, true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
