using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IS2
{
    public class CryptoService
    {
        // Set the key size
        private const int KeySize = 256;

        // Encrypts the given plain text using the CFB mode and the specified key and IV
        public string EncryptCFB(string plainText, string key)
        {
            // Create a new AES crypto service provider instance
            using (var aes = new AesCryptoServiceProvider())
            {
                // Set the key size to 256 bits
                aes.KeySize = KeySize;
                // Set the block size to 128 bits
                aes.BlockSize = 128;
                // Set the cipher mode to CFB
                aes.Mode = CipherMode.CFB;
                // Generate a random IV
                aes.GenerateIV();
                byte[] iv = aes.IV;

                // Convert the key string to a byte array
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                // Derive a key from the password and IV using PBKDF2
                using (var deriveBytes = new Rfc2898DeriveBytes(keyBytes, iv, 10000))
                {
                    byte[] derivedKey = deriveBytes.GetBytes(KeySize / 8);
                    // Create a new encryptor instance using the derived key and IV
                    using (var encryptor = aes.CreateEncryptor(derivedKey, iv))
                    // Create a new memory stream to hold the encrypted data
                    using (var msEncrypt = new MemoryStream())
                    // Create a new crypto stream using the encryptor and memory stream
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        // Convert the plain text to a byte array
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                        // Write the plain text byte array to the crypto stream
                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                        // Flush the final block of data to the crypto stream
                        csEncrypt.FlushFinalBlock();

                        // Get the encrypted data from the memory stream
                        byte[] encryptedBytes = msEncrypt.ToArray();
                        // Combine the IV and encrypted data into a single byte array
                        byte[] combinedBytes = new byte[iv.Length + encryptedBytes.Length];
                        Buffer.BlockCopy(iv, 0, combinedBytes, 0, iv.Length);
                        Buffer.BlockCopy(encryptedBytes, 0, combinedBytes, iv.Length, encryptedBytes.Length);

                        // Convert the combined byte array to a Base64-encoded string and return it
                        return Convert.ToBase64String(combinedBytes);
                    }
                }
            }
        }

        // Decrypts the given encrypted text using the CFB mode and the specified key and IV
        public string DecryptCFB(string encryptedText, string key)
        {
            // Convert the encrypted text from Base64 to a byte array
            byte[] combinedBytes = Convert.FromBase64String(encryptedText);
            // Extract the IV from the combined byte array
            byte[] iv = new byte[16];
            Buffer.BlockCopy(combinedBytes, 0, iv, 0, iv.Length);
            // Extract the encrypted data from the combined byte array
            byte[] encryptedBytes = new byte[combinedBytes.Length - iv.Length];
            Buffer.BlockCopy(combinedBytes, iv.Length, encryptedBytes, 0, encryptedBytes.Length);
            // Convert the key string to a byte array
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            // Derive a key from the password and IV using PBKDF2
            using (var deriveBytes = new Rfc2898DeriveBytes(keyBytes, iv, 10000))
            {
                byte[] derivedKey = deriveBytes.GetBytes(KeySize / 8);
                // Create a new AES crypto service provider instance
                using (var aes = new AesCryptoServiceProvider())
                {
                    // Set the key size to 256 bits
                    aes.KeySize = KeySize;
                    // Set the block size to 128 bits
                    aes.BlockSize = 128;
                    // Set the cipher mode to CFB
                    aes.Mode = CipherMode.CFB;
                    // Create a new decryptor instance using the derived key and IV
                    using (var decryptor = aes.CreateDecryptor(derivedKey, iv))
                    // Create a new memory stream to hold the decrypted data
                    using (var msDecrypt = new MemoryStream(encryptedBytes))
                    // Create a new crypto stream using the decryptor and memory stream
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    // Create a new stream reader to read the decrypted data
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        // Read the decrypted data from the stream reader and return it
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
        public string EncryptCBC(string plainText, string key)
        {
            // Create a new AES crypto service provider instance
            using (var aes = new AesCryptoServiceProvider())
            {
                // Set the key size to 256 bits
                aes.KeySize = KeySize;
                // Set the block size to 128 bits
                aes.BlockSize = 128;
                // Set the cipher mode to CBC
                aes.Mode = CipherMode.CBC;
                // Generate a random IV
                aes.GenerateIV();
                byte[] iv = aes.IV;

                // Convert the key string to a byte array
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                // Derive a key from the password and iv using PBKDF2
                using (var deriveBytes = new Rfc2898DeriveBytes(keyBytes, iv, 10000))
                {
                    byte[] derivedKey = deriveBytes.GetBytes(KeySize / 8);
                    // Create a new encryptor instance using the derived key and IV
                    using (var encryptor = aes.CreateEncryptor(derivedKey, iv))
                    // Create a new memory stream to hold the encrypted data
                    using (var msEncrypt = new MemoryStream())
                    // Create a new crypto stream using the encryptor and memory stream
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        // Convert the plain text to a byte array
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                        // Write the plain text byte array to the crypto stream
                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                        // Flush the final block of data to the crypto stream
                        csEncrypt.FlushFinalBlock();

                        // Get the encrypted data from the memory stream
                        byte[] encryptedBytes = msEncrypt.ToArray();
                        // Combine the iv and encrypted data into a single byte array
                        byte[] combinedBytes = new byte[iv.Length + encryptedBytes.Length];
                        Buffer.BlockCopy(iv, 0, combinedBytes, 0, iv.Length);
                        Buffer.BlockCopy(encryptedBytes, 0, combinedBytes, iv.Length, encryptedBytes.Length);

                        // Convert the combined byte array to a Base64-encoded string and return it
                        return Convert.ToBase64String(combinedBytes);
                    }
                }
            }
        }

        public string DecryptCBC(string encryptedText, string key)
        {
            // Convert the encrypted text from Base64 to a byte array
            byte[] combinedBytes = Convert.FromBase64String(encryptedText);
            // Extract the iv from the combined byte array
            byte[] salt = new byte[16];
            Buffer.BlockCopy(combinedBytes, 0, salt, 0, salt.Length);
            // Extract the encrypted data from the combined byte array
            byte[] encryptedBytes = new byte[combinedBytes.Length - salt.Length];
            Buffer.BlockCopy(combinedBytes, salt.Length, encryptedBytes, 0, encryptedBytes.Length);

            // Convert the key string to a byte array
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            // Derive a key from the password and iv using PBKDF2
            using (var deriveBytes = new Rfc2898DeriveBytes(keyBytes, salt, 10000))
            {
                byte[] derivedKey = deriveBytes.GetBytes(KeySize / 8);
                // Create a new AES crypto service provider instance
                using (var aes = new AesCryptoServiceProvider())
                {
                    // Set the key size to 256 bits
                    aes.KeySize = KeySize;
                    // Set the block size to 128 bits
                    aes.BlockSize = 128;
                    // Set the cipher mode to CBC
                    aes.Mode = CipherMode.CBC;
                    // Create a new decryptor instance using the derived key and IV
                    using (var decryptor = aes.CreateDecryptor(derivedKey, salt))
                    // Create a new memory stream to hold the decrypted data
                    using (var msDecrypt = new MemoryStream(encryptedBytes))
                    // Create a new crypto stream using the decryptor and memory stream
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    // Create a new stream reader to read the decrypted data
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        // Read the decrypted data from the stream reader and return it
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
        // Encrypts the given plain text using the ECB mode and the specified key
        public string EncryptECB(string plainText, string key)
        {
            // Create a new AES crypto service provider instance
            using (var aes = new AesCryptoServiceProvider())
            {
                // Set the key size to 256 bits
                aes.KeySize = KeySize;
                // Set the block size to 128 bits
                aes.BlockSize = 128;
                // Set the cipher mode to ECB
                aes.Mode = CipherMode.ECB;
                // Convert the key string to a byte array
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                // Derive a key from the password using SHA-256
                using (var sha256 = SHA256.Create())
                {
                    byte[] derivedKey = sha256.ComputeHash(keyBytes);
                    // Create a new encryptor instance using the derived key and IV
                    using (var encryptor = aes.CreateEncryptor(derivedKey, null))
                    // Create a new memory stream to hold the encrypted data
                    using (var msEncrypt = new MemoryStream())
                    // Create a new crypto stream using the encryptor and memory stream
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        // Convert the plain text to a byte array
                        byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
                        // Write the plain text byte array to the crypto stream
                        csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                        // Flush the final block of data to the crypto stream
                        csEncrypt.FlushFinalBlock();

                        // Get the encrypted data from the memory stream
                        byte[] encryptedBytes = msEncrypt.ToArray();

                        // Convert the encrypted byte array to a Base64-encoded string and return it
                        return Convert.ToBase64String(encryptedBytes);
                    }
                }
            }
        }

        // Decrypts the given cipher text using the ECB mode and the specified key
        public string DecryptECB(string cipherText, string key)
        {
            // Create a new AES crypto service provider instance
            using (var aes = new AesCryptoServiceProvider())
            {
                // Set the key size to 256 bits
                aes.KeySize = KeySize;
                // Set the block size to 128 bits
                aes.BlockSize = 128;
                // Set the cipher mode to ECB
                aes.Mode = CipherMode.ECB;
                // Convert the key string to a byte array
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                // Derive a key from the password using SHA-256
                using (var sha256 = SHA256.Create())
                {
                    byte[] derivedKey = sha256.ComputeHash(keyBytes);
                    // Create a new decryptor instance using the derived key and IV
                    using (var decryptor = aes.CreateDecryptor(derivedKey, null))
                    // Convert the cipher text from Base64 to a byte array
                    using (var msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                    // Create a new crypto stream using the decryptor and memory stream
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    // Create a new stream reader to read the decrypted data from the crypto stream
                    using (var srDecrypt = new StreamReader(csDecrypt))
                    {
                        // Read the decrypted data from the stream reader
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }
}
