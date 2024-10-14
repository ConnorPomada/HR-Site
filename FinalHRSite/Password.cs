using System.Security.Cryptography;
using System.Text;

namespace PasswordController
{
    public class PasswordSalt
    {
        const int keysize = 64;
        const int iterations = 350000;
        HashAlgorithmName hashAlgo = HashAlgorithmName.SHA512;

        public string HashPassword(string password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(keysize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), salt, iterations, hashAlgo, keysize);
            return Convert.ToHexString(hash);
        }

        public bool VerifyPassword(string password, string hash, byte[] salt)
        {
            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(password, salt, iterations, hashAlgo, keysize);
            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }
    }
}
