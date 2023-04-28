using System;
using System.Security.Cryptography;
using System.Text;

namespace WeatherApp.Helpers
{
    public class PasswordHelpers
    {
        private string? _password;
        private IDictionary<string, string> passwordObject = new Dictionary<string, string>();

        public PasswordHelpers(string? password)
        {
            _password = password;
        }

        public byte[] GenerateSalt()
        {
            var bytes = new byte[128 / 8];
            using(var rng = new RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
            
        }
        public string HashPassword(out byte[] salt)
        {
            
        }
    }
}