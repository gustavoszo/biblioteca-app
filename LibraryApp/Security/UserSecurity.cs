using System;
using System.Text.Json;
using LibraryApp.Models;
using SecurityLibrary.Helpers;

namespace LibraryApp.Security
{
    internal static class UserSecurity
    {
        private static string _userFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "LibraryApp", "user.enc"
        );

        private static AesKeyInfo _aesKeyInfo;

        static UserSecurity()
        {
            AesKeyManager.EnsureKeyExists();    
            _aesKeyInfo = AesKeyManager.LoadKey();
        }
        
        public static bool IsValidCredential(string username, string password)
        {
            var credentials = CryptoHelper.DecryptFile(_userFilePath, _aesKeyInfo);
            var admin = JsonSerializer.Deserialize<Admin>(credentials);

            return admin.Username.Equals(username) && HashHelper.VerifyPassword(password, admin.Hash, admin.Salt);
        }
    }
}
