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
    #region Models
    public class UserInfo
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Display(Name = "用户名：")]
        public string UserName { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        [Display(Name = "用户ID：")]
        public Guid UserID { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        [Display(Name = "Email：")]
        public string Email { get; set; }
        /// <summary>
        /// FriendlyName
        /// </summary>
        [Display(Name = "友好名")]
        public string FriendlyName { get; set; }
        /// <summary>
        /// TEL
        /// </summary>
        [Display(Name = "电话")]
        public string TEL { get; set; }
    }


    public class ChangePasswordModel
    {
        /// <summary>
        /// 当前密码
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "当前密码：")]
        public string OldPassword { get; set; }
        /// <summary>
        /// 新密码
        /// </summary>
        [Required] 
        [DataType(DataType.Password)]
        [Display(Name = "新密码")]
        public string NewPassword { get; set; }
        /// <summary>
        /// 验证新密码
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "验证新密码")]     
        public string ConfirmPassword { get; set; }
    }

    public class LogOnModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [Display(Name = "用户名：")]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码：")]
        public string Password { get; set; }
        /// <summary>
        /// 自动登入
        /// </summary>
        [Display(Name = "自动登入?")]
        public bool RememberMe { get; set; }
    }


    public class RegisterModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        [Required]
        [Display(Name = "用户名：")]
        public string UserName { get; set; }

        //[Required]
        //[DataType(DataType.EmailAddress)]
        //[Display(Name = "Email：")]
        //public string Email { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }
        /// <summary>
        /// 验证密码
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "验证密码")]
        public string ConfirmPassword { get; set; }
    }
    #endregion
}
