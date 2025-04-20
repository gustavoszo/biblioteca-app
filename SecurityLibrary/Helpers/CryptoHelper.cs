using System;
using System.Security.Cryptography;
using System.Text;
using SecurityLibrary.Helpers;

namespace LibraryApp.Security
{
    public static class CryptoHelper
    {
        public static void EncryptFile(string content, string outputPath, AesKeyInfo keyInfo)
        {
            byte[] encrypted = EncryptStringToBytes_Aes(content, keyInfo);
            File.WriteAllBytes(outputPath, encrypted);
        }

        public static string DecryptFile(string encryptedFilePath, AesKeyInfo keyInfo)
        {
            byte[] encryptedData = File.ReadAllBytes(encryptedFilePath);
            return DecryptStringFromBytes_Aes(encryptedData, keyInfo);
        }

        private static byte[] EncryptStringToBytes_Aes(string plainText, AesKeyInfo keyInfo)
        {
            using Aes aesAlg = Aes.Create();
            aesAlg.Key = keyInfo.Key;
            aesAlg.IV = keyInfo.IV;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

            using MemoryStream msEncrypt = new();
            using CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write);
            using StreamWriter swEncrypt = new(csEncrypt);

            swEncrypt.Write(plainText);
            swEncrypt.Flush();
            csEncrypt.FlushFinalBlock();

            return msEncrypt.ToArray();
        }

        private static string DecryptStringFromBytes_Aes(byte[] cipherText, AesKeyInfo keyInfo)
        {
            using Aes aesAlg = Aes.Create();
            aesAlg.Key = keyInfo.Key;
            aesAlg.IV = keyInfo.IV;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using MemoryStream msDecrypt = new(cipherText);
            using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
            using StreamReader srDecrypt = new(csDecrypt);
            return srDecrypt.ReadToEnd();
        }
    }

}
