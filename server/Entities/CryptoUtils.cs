using System;
using System.Security.Cryptography;
using System.Text;

namespace Entities
{
    public class CryptoUtils
    {
        private static readonly int _saltSize = 16; //128 bit

        public static bool VerifyPassword(string password, string storedPassword)
        {
            Span<byte> hashedArray = Convert.FromBase64String(storedPassword);
            var storedPasswordSalt = hashedArray.Slice(0, _saltSize).ToArray();
            var storedPasswordHash = hashedArray.Slice(_saltSize).ToArray();
            var passwordHash = HashPassword(password, storedPasswordSalt);
            if (CryptographicOperations.FixedTimeEquals(passwordHash, storedPasswordHash))
            {
                return true;
            }
            return false;
        }

        public static byte[] HashPassword(string password, byte[] salt)
        {
            byte[] hash;
            using (var hashAlgorithm = HashAlgorithm.Create(HashAlgorithmName.SHA256.Name))
            {
                byte[] input = Encoding.UTF8.GetBytes(password);
                hashAlgorithm.TransformBlock(salt, 0, salt.Length, salt, 0);
                hashAlgorithm.TransformFinalBlock(input, 0, input.Length);
                hash = hashAlgorithm.Hash;
            }

            return hash;
        }

        public static string HashPassword(string password)
        {
            var salt = GenerateSalt();
            var hashedPassword = HashPassword(password, salt);
            var resultArray = new byte[salt.Length + hashedPassword.Length];
            Buffer.BlockCopy(salt, 0, resultArray, 0, salt.Length);
            Buffer.BlockCopy(hashedPassword, 0, resultArray, salt.Length, hashedPassword.Length);
            return Convert.ToBase64String(resultArray);
        }

        public static byte[] GenerateSalt() 
        {
            using var cryptoServiceProvider = new RNGCryptoServiceProvider();
            var data = new byte[_saltSize];
            cryptoServiceProvider.GetBytes(data);
            return data;
        }
    }
}
