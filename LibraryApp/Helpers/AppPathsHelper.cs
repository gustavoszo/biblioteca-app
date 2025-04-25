using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Helpers
{
    internal static class AppPathsHelper
    {
        public static string BasePath => Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "LibraryApp");

        public static string DbFilePath => Path.Combine(BasePath, "database.enc");
        public static string UserFilePath => Path.Combine(BasePath, "user.enc");
    }
}
