using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Eulei.Map.Code;
using System.IO;
using Eulei.Log;
namespace Eulei.Map
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool _autoLoginStatus = false;

            //尝试自动登陆
            try
            {
                //判断历史用户配置文件是否存在
                if (File.Exists(UserHistory.filePath))
                {

                    //载录历史用户配置文件
                    UserHistory.Init().Load();

                    //判断用户是否陪了自动登陆
                    if (UserHistory.Init().UserRoot.RememberMe)
                    {

                        //string _userName = DESHelper.DESDecrypt(UserHistory.Init().UserRoot.LastUser);
                        string _userName = UserHistory.Init().UserRoot.LastUser;

                        if (TaskMemberShip.Init().MembershipService.AutoLogin(_userName) != null)
                        {

                            //成功登陆，加载主窗体
                            _autoLoginStatus = true;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                //记录异常信息。
                Eulei.Log.FileOperation.WriteErrorLog(ex.Message);
                MessageBox.Show("自动登入设置异常！" + ex.Message);
            }
            //显示登陆框
            try
            {
                if (_autoLoginStatus)
                    Application.Run(new MainForm());
                else
                    Login();
            }
            catch (Exception ex)
            {
                //记录异常信息。
                Eulei.Log.FileOperation.WriteErrorLog(ex.Message);
                if (MessageBox.Show(ex.Message + "\r\n是否重新打开程序？", "提醒", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    Application.Run(new MainForm());
                }
            }


        }
        static void Login()
        {
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog().Equals(DialogResult.OK))
            {
                Application.Run(new MainForm());
            }
        }
    }
}
