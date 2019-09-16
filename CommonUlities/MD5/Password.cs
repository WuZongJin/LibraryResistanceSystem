using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CommonUlities
{
    public sealed class Password
    {

        public static string GetMd5Hash(string salt,string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input+salt));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static bool VerifyMd5Hash(string salt,string input,string hash)
        {

            string hashOfInput = GetMd5Hash(salt, input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
                return true;
            else
                return false;
        }
    }
}
