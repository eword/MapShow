using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using System.Web.Security;
using Eulei.IMemberShip;
namespace Eulei.MemberShip
{
    #region Services
    [Export(typeof(IMembershipService))]
    public class AccountMembershipService : IMembershipService
    {
        private readonly MembershipProvider _provider;
        /// <summary>
        /// 构造函数
        /// </summary>
        public AccountMembershipService()
            : this(null)
        {
        }
        /// <summary>
        /// 初始化MemberShip提供程序
        /// </summary>
        /// <param name="provider"></param>
        public AccountMembershipService(MembershipProvider provider)
        {
            _provider = provider ?? Membership.Provider;
        }
        /// <summary>
        /// 最小密码长度
        /// </summary>
        public int MinPasswordLength
        {
            get
            {
                return _provider.MinRequiredPasswordLength;
            }
        }
        /// <summary>
        /// 验证用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>验证成功与否</returns>
        public bool ValidateUser(string userName, string password)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException("Value cannot be null or empty.", "userName");
            if (String.IsNullOrEmpty(password)) throw new ArgumentException("Value cannot be null or empty.", "password");
            return _provider.ValidateUser(userName, password);
        }
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>操作状态MembershipCreateStatus类型</returns>
        public MembershipCreateStatus CreateUser(string userName, string password)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException("Value cannot be null or empty.", "userName");
            if (String.IsNullOrEmpty(password)) throw new ArgumentException("Value cannot be null or empty.", "password");
            //if (String.IsNullOrEmpty(email)) throw new ArgumentException("Value cannot be null or empty.", "email");

            MembershipCreateStatus status;
            //_provider.CreateUser(userName, password, email, null, null, true, null, out status);
            _provider.CreateUser(userName, password, null, null, null, true, null, out status);
            return status;
        }
        /// <summary>
        /// 更改密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="oldPassword">旧密码</param>
        /// <param name="newPassword">新密码</param>
        /// <returns>是否成功更改密码</returns>
        public bool ChangePassword(string userName, string oldPassword, string newPassword)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException("Value cannot be null or empty.", "userName");
            if (String.IsNullOrEmpty(oldPassword)) throw new ArgumentException("Value cannot be null or empty.", "oldPassword");
            if (String.IsNullOrEmpty(newPassword)) throw new ArgumentException("Value cannot be null or empty.", "newPassword");

            // The underlying ChangePassword() will throw an exception rather
            // than return false in certain failure scenarios.
            try
            {
                MembershipUser currentUser = _provider.GetUser(userName, true /* userIsOnline */);
                return currentUser.ChangePassword(oldPassword, newPassword);
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (MembershipPasswordException)
            {
                return false;
            }
        }

        /// <summary>
        /// 重置用户密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>是否成功重置用户密码</returns>
        public bool ResetPassWord(string userName, string password)
        {
            //try
            //{
                if (_provider.GetUser(userName, false).IsLockedOut)
                {
                    _provider.UnlockUser(userName);
                }
                string _pw = _provider.ResetPassword(userName, null);
                return _provider.ChangePassword(userName, _pw, password);
            //}
            //catch
            //{

            //    return false;
            //}


        }
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>是否成功删除</returns>
        public bool DeleteUser(string userName)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        /// <summary>
        /// 自动登入
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>是否验证成功</returns>
        public MembershipUser AutoLogin(string userName)
        {
            MembershipUser _user = _provider.GetUser(userName, true);
            return _user;
        }
    }
    [Export(typeof(IFormsAuthenticationService))]
    public class FormsAuthenticationService : IFormsAuthenticationService
    {          /// <summary>
        /// 登入
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="RememberMe">是否自动登陆</param>
        public void SignIn(string userName, bool RememberMe)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException("Value cannot be null or empty.", "userName");

            //FormsAuthentication.SetAuthCookie(userName, createPersistentCookie,"eulei.Mapx");            
        }
        /// <summary>
        /// 登出
        /// </summary>
        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
    #endregion
}
