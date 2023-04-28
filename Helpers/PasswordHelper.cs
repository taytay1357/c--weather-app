using System;
using System.Security.Cryptography;
using System.Text;

namespace WeatherApp.Helpers
{
    public class PasswordHelpers
    {
        private string? _password;
        private IDictionary<string, string> passwordObject = new Dictionary<string, string>();
        private static RandomNumberGenerator _rng = RandomNumberGenerator.Create();
        public PasswordHelpers(string? password)
        {
            _password = password;
            
        }
        public string GenerateSalt()
        {
            var bytes = new byte[128/8];
            _rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }
        
        public string HashPassword(byte[] salt)
        {
            byte[] bytesToHash = Encoding.UTF8.GetBytes(_password ?? "");
            var byteResult = new Rfc2898DeriveBytes(bytesToHash, salt, 10000, HashAlgorithmName.SHA512);
            return Convert.ToBase64String(byteResult.GetBytes(24));
        }

    }
}