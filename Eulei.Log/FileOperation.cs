/*=================================================================
 * 
 * Eulei Log 1.0.0.0
 * 
 * http://www.eulei.com
 * 
 * Author daomi 2013[eword@eword.name] 
 * 
 * ===============================================================*/
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Reflection;
using System.Diagnostics;
namespace Eulei.Log
{
    public class FileOperation
    {
        /// <summary>
        /// 根路径
        /// </summary>
        static string BASE_PATH
        {
            get
            {
                try
                {
                    Assembly myAssembly = Assembly.GetExecutingAssembly();
                    string path = myAssembly.CodeBase;
                    int start = 8;// 去除file:///  
                    int end = path.LastIndexOf('/');// 去除文件名xxx.dll及文件名前的/  
                    path = path.Substring(start, end - start);
                    DirectoryInfo dr = new DirectoryInfo(path);
                    path = dr.FullName;
                    return path + "\\";
                }
                catch (Exception ex)
                {
                    throw new Exception("\r\n" + ex.Message + "@Eulei.Log.FileOperation.BASE_PATH");
                }
            }
        }
        /// <summary>
        /// 异常日志文件名
        /// </summary>
        static string ERROR_FILE_NAME
        {
            get
            {
                try
                {
                    XDocument xDoc = XDocument.Load(BASE_PATH + "LogConfig.xml");
                    XElement root = xDoc.Element("configuration");
                    return root.Element("appSettings").Element("ERROR_FILE_NAME").Value.Trim();
                }
                catch (Exception ex)
                {
                    throw new Exception("\r\n" + ex.Message + "@Eulei.Log.FileOperation.ERROR_FILE_NAME");
                }
            }
        }
        /// <summary>
        /// 操作日志文件名
        /// </summary>
        static string OPERATE_FILE_NAME
        {
            get
            {
                try
                {
                    XDocument xDoc = XDocument.Load(BASE_PATH + "LogConfig.xml");
                    XElement root = xDoc.Element("configuration");
                    return root.Element("appSettings").Element("OPERATE_FILE_NAME").Value.Trim();
                }
                catch (Exception ex)
                {
                    throw new Exception("\r\n" + ex.Message + "@Eulei.Log.FileOperation.OPERATE_FILE_NAME");
                }
            }
        }
        /// <summary>
        /// 日志路径名
        /// </summary>
        static string LOG_FIRST_PATH
        {
            get
            {
                try
                {
                    XDocument xDoc = XDocument.Load(BASE_PATH + "LogConfig.xml");
                    XElement root = xDoc.Element("configuration");
                    return root.Element("appSettings").Element("LOG_FIRST_PATH").Value.Trim();
                }
                catch (Exception ex)
                {
                    throw new Exception("\r\n" + ex.Message + "@Eulei.Log.FileOperation.LOG_FIRST_PATH");
                }
            }
        }
        /// <summary>
        /// 异常日志末级路径名
        /// </summary>
        static string ERROR_SECOND_PATH
        {
            get
            {
                try
                {
                    XDocument xDoc = XDocument.Load(BASE_PATH + "LogConfig.xml");
                    XElement root = xDoc.Element("configuration");
                    return root.Element("appSettings").Element("ERROR_SECOND_PATH").Value.Trim();
                }
                catch (Exception ex)
                {
                    throw new Exception("\r\n" + ex.Message + "@Eulei.Log.FileOperation.ERROR_SECOND_PATH");
                }
            }
        }
        /// <summary>
        /// 操作日志末级路径名
        /// </summary>
        static string OPERATE_SECOND_PATH
        {
            get
            {
                try
                {
                    XDocument xDoc = XDocument.Load(BASE_PATH + "LogConfig.xml");
                    XElement root = xDoc.Element("configuration");
                    return root.Element("appSettings").Element("OPERATE_SECOND_PATH").Value.Trim();
                }
                catch (Exception ex)
                {
                    throw new Exception("\r\n" + ex.Message + "@Eulei.Log.FileOperation.OPERATE_SECOND_PATH");
                }
            }
        }
        /// <summary>
        /// 默认文件大小，当日志文件大于该值时，将创建新文件
        /// </summary>
        static Int64 DEFAULT_FILE_SIZE
        {
            get
            {
                try
                {
                    XDocument xDoc = XDocument.Load(BASE_PATH + "LogConfig.xml");
                    XElement root = xDoc.Element("configuration");
                    return Int64.Parse(root.Element("appSettings").Element("DEFAULT_FILE_SIZE").Value.Trim());
                }
                catch (Exception ex)
                {
                    throw new Exception("\r\n" + ex.Message + "@Eulei.Log.FileOperation.DEFAULT_FILE_SIZE");
                }
            }
        }
        /// <summary>
        /// 路径探测
        /// </summary>
        /// <param name="path">路径</param>
        /// <returns>如果存在，则返回路径，否则创建后返回。</returns>
        private static string DetectDirectory(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                return path;
            }
            catch (Exception ex)
            {
                throw new Exception("\r\n" + ex.Message + "@Eulei.Log.FileOperation.DetectDirectory");
            }
        }
        /// <summary>
        /// 记录异常日志条目并写入到文件
        /// </summary>
        /// <param name="str">日志信息</param>
        public static void WriteErrorLog(string str)
        {
            try
            {
                //路径合成
                string path = BASE_PATH + LOG_FIRST_PATH;
                path = DetectDirectory(path);
                path += "\\" + ERROR_SECOND_PATH;
                path = DetectDirectory(path);
                //设置当前路径
                Directory.SetCurrentDirectory(path);
                StreamWriter sr;
                //最经路径（判断当前最新日志文件路径）
                int _fileOrder = 0;
                string filePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMdd") + _fileOrder.ToString() + ERROR_FILE_NAME;
                while (File.Exists(filePath))
                {
                    _fileOrder++;
                    filePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMdd") + _fileOrder.ToString() + ERROR_FILE_NAME;
                };
                _fileOrder = _fileOrder > 0 ? _fileOrder - 1 : 0;
                filePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMdd") + _fileOrder.ToString() + ERROR_FILE_NAME;
                //日志文件操作
                if (File.Exists(filePath)) //如果文件存在,则创建File.AppendText对象 
                {
                    FileInfo _fileinfo = new FileInfo(filePath);
                    //判断文件大小
                    if (!(_fileinfo.Length > DEFAULT_FILE_SIZE))
                    { //小于默认值时，在尾部添加日志内容
                        sr = File.AppendText(filePath);
                    }
                    else
                    {//大于默认值，创建新文件
                        _fileOrder++;
                        filePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMdd") + _fileOrder.ToString() + ERROR_FILE_NAME;
                        sr = File.CreateText(filePath);

                    }
                }
                else    //如果文件不存在,则创建File.CreateText对象 
                {
                    sr = File.CreateText(filePath);
                }

                //-----获取调用的方法强命名，并添加到日志信息尾部----------
                StackTrace ss = new StackTrace(true);
                MethodBase mb = ss.GetFrame(1).GetMethod();
                //取得父方法类全名
                str += " @At{"+mb.DeclaringType.FullName +"."+mb.Name+ "}\n";
                //----------------------------------
                //写入日志信息，并释放资源
                sr.WriteLine(DateTime.Now.ToString() + ":=>" + str);
                sr.Flush();
                sr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("\r\n" + ex.Message + "@Eulei.Log.FileOperation.WriteErrorLog");
            }
        }
        /// <summary>
        /// 记录操作日志条目并写入文件
        /// </summary>
        /// <param name="str">日志信息</param>
        public static void WriteOperateLog(string str)
        {
            try
            {
                //路径合成
                string path = BASE_PATH + LOG_FIRST_PATH;
                path = DetectDirectory(path);
                path += "\\" + OPERATE_SECOND_PATH;
                path = DetectDirectory(path);
                //设置当前路径
                Directory.SetCurrentDirectory(path);
                StreamWriter sr;
                //最经路径（判断当前最新日志文件路径）
                int _fileOrder = 0;
                string filePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMdd") + _fileOrder.ToString() + OPERATE_FILE_NAME;
                while (File.Exists(filePath))
                {
                    _fileOrder++;
                    filePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMdd") + _fileOrder.ToString() + OPERATE_FILE_NAME;
                };
                _fileOrder = _fileOrder > 0 ? _fileOrder - 1 : 0;
                filePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMdd") + _fileOrder.ToString() + OPERATE_FILE_NAME;
               //日志文件操作
                if (File.Exists(filePath)) //如果文件存在,则创建File.AppendText对象 
                {
                    FileInfo _fileinfo = new FileInfo(filePath);
                    //判断文件大小
                    if (!(_fileinfo.Length > DEFAULT_FILE_SIZE))
                    {
                        //小于默认值时，在尾部添加日志内容
                        sr = File.AppendText(filePath);
                    }
                    else
                    {
                        //大于默认值，创建新文件
                        _fileOrder++;
                        filePath = Directory.GetCurrentDirectory() + "\\" + DateTime.Now.ToString("yyyyMMdd") + _fileOrder.ToString() + OPERATE_FILE_NAME;
                        sr = File.CreateText(filePath);
                    }
                }
                else    //如果文件不存在,则创建File.CreateText对象 
                {
                    sr = File.CreateText(filePath);
                }
                //-----获取调用的方法强命名，并添加到日志信息尾部----------
                StackTrace ss = new StackTrace(true);
                MethodBase mb = ss.GetFrame(1).GetMethod();
                //取得父方法类全名
                str += " @At{" + mb.DeclaringType.FullName + "." + mb.Name + "}\n";
                //----------------------------------
                //写入日志信息，并释放资源
                sr.WriteLine(DateTime.Now.ToString() + ":=>" + str);
                sr.Flush();
                sr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("\r\n" + ex.Message + "@Eulei.Log.FileOperation.WriteOperateLog");
            }
        }


    }
}
