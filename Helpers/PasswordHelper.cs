

namespace WeatherApp.Helpers
{
    public class PasswordHelpers
    {
        private string? _password;

        public PasswordHelpers(string? password)
        {
            _password = password;
        }

        public string HashPassword(out byte[] salt)
        {
            string hash;
            string salt;
            return struct {hash; salt;};
        }
    }
}