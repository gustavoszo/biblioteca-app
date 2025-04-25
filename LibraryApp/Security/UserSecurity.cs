using System;
using System.Text.Json;
using LibraryApp.Helpers;
using LibraryApp.Models;
using SecurityLibrary.Helpers;

namespace LibraryApp.Security
{
    internal static class UserSecurity
    {
        private static string _userFilePath = AppPathsHelper.UserFilePath;

        private static AesKeyInfo _aesKeyInfo;

        static UserSecurity()
        {
            _aesKeyInfo = AesKeyManager.LoadKey();
        }

        public static bool IsValidCredential(string username, string password)
        {
            try
            {
                var credentials = CryptoHelper.DecryptFile(_userFilePath, _aesKeyInfo);
                var admin = JsonSerializer.Deserialize<Admin>(credentials);

                if (admin == null) return false;

                return admin.Username.Equals(username) && HashHelper.VerifyPassword(password, admin.Hash, admin.Salt);
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao carregar as credenciais do administrador.", ex);
            }
        }

        public static void RegisterAdmin(string username, string password)
        {
            try
            {
                var (hash, salt) = HashHelper.HashPassword(password);
                var admin = new Admin(username, hash, salt);

                var json = JsonSerializer.Serialize(admin);
                CryptoHelper.EncryptFile(json, _userFilePath, _aesKeyInfo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}