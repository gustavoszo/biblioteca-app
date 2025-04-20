using System;
using System.Text.Json;
using LibraryApp.Data;
using LibraryApp.Helpers;
using SecurityLibrary.Helpers;

namespace LibraryApp.Security
{
    internal class DbSecurity
    {
        private static string _dbFilePath = AppPathsHelper.DbFilePath;

        private static AesKeyInfo _aesKeyInfo;

        static DbSecurity()
        {
            AesKeyManager.EnsureKeyExists();
            _aesKeyInfo = AesKeyManager.LoadKey();
        }

        public static DbConfig LoadDatabaseConfig()
        {
            try
            {
                var data = CryptoHelper.DecryptFile(_dbFilePath, _aesKeyInfo);
                return JsonSerializer.Deserialize<DbConfig>(data);
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao carregar a configuração do banco de dados.", ex);
            }
        }
    }
}
