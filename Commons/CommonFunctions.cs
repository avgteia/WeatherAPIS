using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Commons
{
    public class CommonFunctions
    {
        #region ---------------------------------------------------------- Public methods ---------------------------------------------------
        public static string GenerateComparableDataString(params object[] properties)
        {
            return MD5Hash(string.Join("|", properties));
        }

        #endregion
        #region ---------------------------------------------------------- Private methods ---------------------------------------------------
        public static string MD5Hash(string text)
        {
            MD5 mD = MD5.Create();

            mD.ComputeHash(Encoding.ASCII.GetBytes(text));

            byte[] hash = mD.Hash;
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                stringBuilder.Append(hash[i].ToString("x2"));
            }

            return stringBuilder.ToString();
        }

        #endregion
    }
}
