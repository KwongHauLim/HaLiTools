﻿using System.Linq;
using System.Text;

namespace HaLi.Tools.Hashcode
{
    public sealed class MD5 : IHashCalc
    {
        public Encoding Encoding { get; set; } = Encoding.UTF8;
        public bool UpperCase { get; set; } = true;

        public string GetHash(byte[] binary)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] hash = md5.ComputeHash(binary);
                string format = UpperCase ? "X2" : "x2";
                return string.Concat(hash.Select(b => b.ToString(format)));
            }
        }

        public string GetHash(string str)
        {
            return GetHash(Encoding.GetBytes(str));
        }
    }
}