using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using Eulei.IMemberShip;
namespace ResetPassWord
{
  
    /// <summary>
    /// MemberShip作业类
    /// </summary>
    public class Task : IDisposable
    {
        private static Task _task;
        private Task()
        {
            //创建目录
            var catalog = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory + "Libs\\","Eulei.MemberShip.dll");

            //根据目录初始化实例
            var container = new CompositionContainer(catalog);
            //组合部件
            container.ComposeParts(this);


        }
        /// <summary>
        /// 单例模式初始化
        /// </summary>
        /// <returns>TaskMemberShip对象</returns
        public static Task Init()
        {
            if (_task == null)
                _task = new Task();
            return _task;
        }
        /// <summary>
        /// 返回支持IFormsAuthenticationService接口和MEF的部件
        /// </summary>
        [Import(typeof(IFormsAuthenticationService))]
        public IFormsAuthenticationService FormsService { get; set; }
        /// <summary>
        /// 返回支持IMembershipService接口和MEF的部件
        /// </summary>
        [Import(typeof(IMembershipService))]
        public IMembershipService MembershipService { get; set; }





        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            FormsService.Dispose();
            MembershipService.Dispose();
            _task = null;
        }
    }
}
