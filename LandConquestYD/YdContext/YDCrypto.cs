﻿using System;
using System.IO;
using System.Linq;
using System.Text;

namespace LandConquestYD
{
    public static class YDCrypto
    {
        public static string Decrypt(string cipherText)
        {
            return Decryption(cipherText);
        }
        private static string Decryption(string cipherText)
        {
            byte[] array = Convert.FromBase64String(cipherText);
            byte[] salt = array.Take(32).ToArray();
            byte[] rgbIV = array.Skip(32).Take(32).ToArray();
            byte[] array2 = array.Skip(64).Take(array.Length - 64).ToArray();
            using (var rfc2898DeriveBytes = new System.Security.Cryptography.Rfc2898DeriveBytes(Properties.Settings.Default.Token, salt, 1000))
            {
                byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
                using (var rijndaelManaged = new System.Security.Cryptography.RijndaelManaged())
                {
                    rijndaelManaged.BlockSize = 256;
                    rijndaelManaged.Mode = System.Security.Cryptography.CipherMode.CBC;
                    rijndaelManaged.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
                    using (var transform = rijndaelManaged.CreateDecryptor(bytes, rgbIV))
                    {
                        using (var memoryStream = new MemoryStream(array2))
                        {
                            using (var cryptoStream = new System.Security.Cryptography.CryptoStream(memoryStream, transform, System.Security.Cryptography.CryptoStreamMode.Read))
                            {
                                byte[] array3 = new byte[array2.Length];
                                int count = cryptoStream.Read(array3, 0, array3.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(array3, 0, count);
                            }
                        }
                    }
                }
            }
        }
        public static string Encrypt(string plainText)
        {
            return Encryption(plainText);
        }
        private static string Encryption(string plainText)
        {
            byte[] array = Generate256BitsOfRandomEntropy();
            byte[] array2 = Generate256BitsOfRandomEntropy();
            byte[] bytes = Encoding.UTF8.GetBytes(plainText);
            using (var rfc2898DeriveBytes = new System.Security.Cryptography.Rfc2898DeriveBytes(Properties.Settings.Default.Token, array, 1000))
            {
                byte[] bytes2 = rfc2898DeriveBytes.GetBytes(32);
                using (var rijndaelManaged = new System.Security.Cryptography.RijndaelManaged())
                {
                    rijndaelManaged.BlockSize = 256;
                    rijndaelManaged.Mode = System.Security.Cryptography.CipherMode.CBC;
                    rijndaelManaged.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
                    using (var transform = rijndaelManaged.CreateEncryptor(bytes2, array2))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new System.Security.Cryptography.CryptoStream(memoryStream, transform, System.Security.Cryptography.CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(bytes, 0, bytes.Length);
                                cryptoStream.FlushFinalBlock();
                                byte[] first = array;
                                first = first.Concat(array2).ToArray();
                                first = first.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(first);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            byte[] array = new byte[32];
            using (var rNGCryptoServiceProvider = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rNGCryptoServiceProvider.GetBytes(array);
            }
            return array;
        }

        public static string SHA512(string input)
        {
            return SHA512Encrypt(input);
        }

        private static string SHA512Encrypt(string input)
        {
            var bytes = Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                var hashedInputStringBuilder = new StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }

    }
}
