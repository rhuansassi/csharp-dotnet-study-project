using System.Security.Cryptography;
using System.Text;

namespace MyRecipeBook.Application.Services.Criptography
{
    public class PasswordEncripter
    {
        public string Encript(string password)
        {
            var chaveAdicional = "ABC";

            var newPassword = $"{password}{chaveAdicional}";

            var bytes = Encoding.UTF8.GetBytes(password);
            var hashBytes = SHA512.HashData(bytes);

            return StringBytes(hashBytes);
        }

        private static string StringBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (var b in bytes)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
