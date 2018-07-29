using System;
using System.Security.Cryptography;
using System.Text;

namespace Wykop.Auth
{
    public class AuthSignature
    {
        private readonly string _appSecret;
        private readonly Uri _url;

        public AuthSignature(string appSecret, Uri url)
        {
            if (appSecret == null)
                throw new ArgumentNullException(nameof(appSecret));
            if (url == null)
                throw new ArgumentNullException(nameof(url));

            _appSecret = appSecret;
            _url = url;
        }

        public string FetchSignature()
        {
            var sb = new StringBuilder();
            sb.Append(_appSecret);
            sb.Append(_url);

            return ComputeMD5(sb.ToString());
        }

        public static string ComputeMD5(string str)
        {
            // Use input string to calculate MD5 hash
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(str);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}