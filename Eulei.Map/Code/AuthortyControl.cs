using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eulei.IControl;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
namespace Eulei.Map.Code
{
    public class AuthortyControl : IDisposable
    {
        private static AuthortyControl _authortyControl;
        private AuthortyControl()
        {
            //创建目录
            var catalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory + "Libs\\", ConfigurationManager.AppSettings["ControlType"].ToString()+".dll");
            //根据目录初始化实例
            var container = new CompositionContainer(catalog);
            //组合部件
            container.ComposeParts(this);

        }
        /// <summary>
        /// 单例模式初始化
        /// </summary>
        /// <returns>Task对象</returns>
        public static AuthortyControl Init()
        {
            if (_authortyControl == null)
                _authortyControl = new AuthortyControl();
            return _authortyControl;
        }
        /// <summary>
        /// 返回支持IEuleiControl接口和MEF的部件
        /// </summary>
        [Import(typeof(IEuleiControl))]
        public IEuleiControl Control { get; set; }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            Control.Dispose();
            _authortyControl = null;
        }
    }
}
