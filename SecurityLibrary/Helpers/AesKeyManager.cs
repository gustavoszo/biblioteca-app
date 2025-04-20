using System;
using System.Text.Json;
using System.Security.Cryptography;

namespace SecurityLibrary.Helpers
{
    public class AesKeyInfo
    {
        public byte[] Key { get; set; }
        public byte[] IV { get; set; }
    }

    public class AesKeyManager
    {
        private static string _keyFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "LibraryApp", "aes.key"
        );

        public static void GenerateAndSaveKey()
        {
            AesKeyInfo keyInfo = new()
            {
                Key = RandomNumberGenerator.GetBytes(32),
                IV = RandomNumberGenerator.GetBytes(16)
            };

            string json = JsonSerializer.Serialize(keyInfo);
            File.WriteAllText(_keyFilePath, json);
        }

        public static AesKeyInfo LoadKey()
        {
            string json = File.ReadAllText(_keyFilePath);
            return JsonSerializer.Deserialize<AesKeyInfo>(json);
        }

        public static void EnsureKeyExists()
        {
            if (!File.Exists(_keyFilePath))
                GenerateAndSaveKey();
        }
    }
}
