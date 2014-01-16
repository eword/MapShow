using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Eulei.Map.Code;
using System.Web.Security;

namespace Eulei.Map
{
    public partial class LoginForm : Form
    {
        #region Field
        private Root _root;
        private List<UserInfo> _userList;
        #endregion
        public LoginForm()
        {
            InitializeComponent();
            this.Init();
        }
        #region Method
        private void Init()
        {
            //初始化历史用户信息
            UserHistory.Init().Load();
            _root = UserHistory.Init().UserRoot;
            _userList = _root.UserList.ToList<UserInfo>();
            this.cb_userName.DataSource = _userList;
            this.cb_userName.DisplayMember = "Name";
            this.cb_userName.ValueMember = "Name";
            this.cb_userName.SelectedValue = _root.LastUser;

        }
        #endregion
        #region event
        private void bt_OK_Click(object sender, EventArgs e)
        {

            try
            {
                //初始化membership
                TaskMemberShip _memberShipProvider = TaskMemberShip.Init();
                //验证账号信息
                if (_memberShipProvider.MembershipService.ValidateUser(this.cb_userName.Text, this.tb_PassWord.Text))
                {
                    //验证通过、处理历史用户信息配置
                    if (_userList.Count > 1)
                    {
                        //查询是否当前用户名已经存在历史用户列表中
                        var _currentUser = _userList.Where(m => m.Name.Equals(this.cb_userName.Text));
                        if (_currentUser.Count() < 1)
                        {
                            //添加当前用户到历史用户列表
                            _userList.Add(new UserInfo() { Name = this.cb_userName.Text });
                        }
                    }
                    else
                    {
                        //添加当前用户到历史用户列表
                        _userList.Add(new UserInfo() { Name = this.cb_userName.Text });
                    }

                    if (this.cb_remember.Checked)
                    {
                        //设置自动登陆
                        _root.RememberMe = true;
                        //_root.HistoryUser = DESHelper.DESEncrypt(this.cb_userName.Text);
                        _root.HistoryUser = this.cb_userName.Text;
                    }
                    else
                    {
                        //取消自动登陆
                        _root.RememberMe = false;
                        _root.HistoryUser = null;
                    }
                    //移除空节点（如果存在的话）
                    _userList.RemoveAll(m => string.IsNullOrEmpty(m.Name));
                    _root.LastUser = this.cb_userName.Text;
                    _root.UserList = _userList.ToArray();
                    //保存历史用户列表，并释放资源。
                    UserHistory.Init().Save(_root);
                    UserHistory.Init().Dispose();
                    //返回登入成功信息
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("登入失败\r\n账号或密码不正确", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                //记录异常信息。
                Eulei.Log.FileOperation.WriteErrorLog(ex.Message);
                MessageBox.Show(ex.Message);
            }

        }
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            //取消并关闭登陆框
            this.DialogResult = DialogResult.No;
        }
        #endregion
    }
}
