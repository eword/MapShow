using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Eulei.IMemberShip
{
    #region Services

    public interface IMembershipService:IDisposable
    {
        int MinPasswordLength { get; }
        /// <summary>
        /// 验证用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>验证成功与否</returns>
        bool ValidateUser(string userName, string password);
        //MembershipCreateStatus CreateUser(string userName, string password, string email);
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>操作状态MembershipCreateStatus类型</returns>
        MembershipCreateStatus CreateUser(string userName, string password);
        /// <summary>
        /// 更改密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="oldPassword">旧密码</param>
        /// <param name="newPassword">新密码</param>
        /// <returns>是否成功更改密码</returns>
        bool ChangePassword(string userName, string oldPassword, string newPassword);
        /// <summary>
        /// 重置用户密码
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>是否成功重置用户密码</returns>
        bool ResetPassWord(string userName, string password);
        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>是否成功删除</returns>
        bool DeleteUser(string userName);
        /// <summary>
        /// 自动登入
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>返回用户信息</returns>
        MembershipUser AutoLogin(string userName);
    }

    public interface IFormsAuthenticationService : IDisposable
    {
        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="RememberMe">是否自动登陆</param>
        void SignIn(string userName, bool RememberMe);
        /// <summary>
        /// 登出
        /// </summary>
        void SignOut();
    }

    #endregion
}
