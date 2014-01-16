using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Eulei.Map.Code
{
    /// <summary>
    /// 文件复制类
    /// </summary>
    public static class CopyFileHelper
    {
        /// <summary>
        /// 文件复制
        /// </summary>
        /// <param name="source">源文件</param>
        /// <param name="target">目标目录</param>
        /// <returns></returns>
        public static bool CopyFile(string source, string target)
        {
            bool _result = true;
            try
            {
                string _path = Path.GetDirectoryName(target);
                if (!Directory.Exists(_path))
                {
                    Directory.CreateDirectory(_path);
                }
                File.Copy(source, target);
            }
            catch
            {
                _result = false;
            }
            return _result;
        }
    }
}
