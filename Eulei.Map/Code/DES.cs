using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eulei.Security;
namespace Eulei.Map.Code
{
    public class DESHelper
    {
        //密钥
        private static readonly string strDESKey = "euleicom";
        //向量
        private static readonly string strDESIV = "00000000";
        /// <summary>
        /// DES加密方法
        /// </summary>
        /// <param name="strPlain">明文</param>
        /// <returns>密文</returns>
        public static string DESEncrypt(string strPlain)
        {
            return DES.DESEncrypt(strPlain, strDESKey, strDESIV);
        }
        /// <summary>
        /// DES解密方法
        /// </summary>
        /// <param name="strCipher">密文</param>
        /// <returns>明文</returns>
        public static string DESDecrypt(string strCipher)
        {
            return DES.DESDecrypt(strCipher, strDESKey, strDESIV);
        }
    }
}
