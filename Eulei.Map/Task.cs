using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskInterface;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using WHC.Pager.Entity;

namespace Eulei.Map
{
    /// <summary>
    /// 数据库作业类
    /// </summary>
    public class Task:IDisposable
    {
        private static Task _task;      
        private Task()
        {
            //创建目录
            var catalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory, "DBTask.dll");
            //根据目录初始化实例
            var container = new CompositionContainer(catalog);      
            //组合部件
            container.ComposeParts(this);

        }
        /// <summary>
        /// 单例模式初始化
        /// </summary>
        /// <returns>Task对象</returns>
        public static Task Init()
        {
            if (_task == null)
                _task = new Task();
            return _task;                
        }
        /// <summary>
        /// 返回支持IStation接口和MEF的部件
        /// </summary>
        [Import(typeof(IStation))]
        public IStation TaskStation { get; set; }
        /// <summary>
        /// 返回支持IConfig接口和MEF的部件
        /// </summary>
        [Import(typeof(IConfig))]
        public IConfig TaskConfig { get; set; }



       public  DataTable GetStationDataTable(PagerInfo _pageInfo)
        {
           return _task.TaskStation.GetStationList(_pageInfo.PageSize*(_pageInfo.CurrenetPageIndex-1),_pageInfo.PageSize);
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            TaskStation.Dispose();
            TaskConfig.Dispose();
            _task = null;
        }
    }
}
