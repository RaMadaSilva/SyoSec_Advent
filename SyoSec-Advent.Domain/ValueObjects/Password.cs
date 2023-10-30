using SyosecAdvent.Domain.ExceptionsCustomized;
using System.Security.Cryptography;
using System.Text;

namespace SyosecAdvent.Domain.ValueObjects
{
    public sealed class Password : ValueObject
    {
        public Password(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new PasswordException("Password Não pode ser vazia");

            if (text.Length < 5)
                throw new PasswordException("Password muito Fraca");

            Text = EncryptPass(text);
        }

        public string Text { get; private set; }

        public static implicit operator Password(string text) => new Password(text);
        public static implicit operator string(Password password) => password.ToString();
        public override string ToString() => Text;

        private string EncryptPass(string password)
        {
            var md5 = MD5.Create();
            var code = Encoding.ASCII.GetBytes(password);
            var hash = md5.ComputeHash(code);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
                sb.Append(hash[i].ToString("X2"));
            return sb.ToString();
        }
    }
}
