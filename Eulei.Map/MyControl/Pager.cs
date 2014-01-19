using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Eulei.Map.Code;
namespace Eulei.Map.MyControl
{
    public delegate void CurrentPageIndexChangedEventHandler(object sender, CurrentPageIndexChangedEventArgs e); 
    public partial class Pager : UserControl
    {
        private CurrentPageIndexChangedEventArgs _pageInfoEventArgs = new CurrentPageIndexChangedEventArgs();
        public CurrentPageIndexChangedEventArgs PageInfoEventArgs
        {           
            
            set
            {
                this._pageInfoEventArgs = value;
            }
            get
            {
                return this._pageInfoEventArgs;
            }
        }

        public event CurrentPageIndexChangedEventHandler CurrentPageIndexChanged;
        private void OnCurrentPageIndexChanged(CurrentPageIndexChangedEventArgs e)
        {
            if (this.CurrentPageIndexChanged != null)
                this.CurrentPageIndexChanged(this, e);
        }
        public Pager()
        {
            InitializeComponent();
            this.PageInfoEventArgs.PageInfo.PageSize = 20;
            this.PageInfoEventArgs.PageInfo.RecordCount = 0;
            this.PageInfoEventArgs.PageInfo.CurrentPageIndex = 1;
            this.Refresh();
        }
        public Pager(PageInfo pageInfo)
        {
            InitializeComponent();
            this.PageInfoEventArgs.PageInfo = pageInfo;
            this.Refresh();
        }
        private void llb_last_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int _i = this._pageInfoEventArgs.PageInfo.RecordCount / this._pageInfoEventArgs.PageInfo.PageSize + (this._pageInfoEventArgs.PageInfo.RecordCount % this._pageInfoEventArgs.PageInfo.PageSize > 0 ? 1 : 0);
            this._pageInfoEventArgs.PageInfo.CurrentPageIndex = _i;
            this.Refresh();
            this.OnCurrentPageIndexChanged(this._pageInfoEventArgs);
        }

        private void llb_down_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this._pageInfoEventArgs.PageInfo.CurrentPageIndex++;
            this.Refresh();
            this.OnCurrentPageIndexChanged(this._pageInfoEventArgs);
        }

        private void llb_up_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this._pageInfoEventArgs.PageInfo.CurrentPageIndex --;
            this.Refresh();
            this.OnCurrentPageIndexChanged(this._pageInfoEventArgs);
        }

        private void llb_first_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this._pageInfoEventArgs.PageInfo.CurrentPageIndex = 1;
            this.Refresh();
            this.OnCurrentPageIndexChanged(this._pageInfoEventArgs);
        }
        /// <summary>
        /// 刷新页数、记录数、当前页等信息
        /// </summary>
        public void Refresh()
        {
            int _i0 = this._pageInfoEventArgs.PageInfo.RecordCount;
            int _i1 = this._pageInfoEventArgs.PageInfo.PageSize;
            int _i2 = this._pageInfoEventArgs.PageInfo.RecordCount / this._pageInfoEventArgs.PageInfo.PageSize + (this._pageInfoEventArgs.PageInfo.RecordCount % this._pageInfoEventArgs.PageInfo.PageSize > 0 ? 1 : 0);
            int _i3 = this._pageInfoEventArgs.PageInfo.CurrentPageIndex;
            this.lb_pageInfo.Text = string.Format("共{0}项，每页{1}项，共{2}页，当前第{3}页", _i0, _i1, _i2, _i3);
            if (_i3<=1)
            {
                this.llb_first.Enabled = false;
                this.llb_up.Enabled = false;
            }
            else
            {
                this.llb_first.Enabled = true;
                this.llb_up.Enabled = true;
            }
            if (_i3>=_i2)
            {
                this.llb_last.Enabled = false;
                this.llb_down.Enabled = false;
            }
            else
            {
                this.llb_last.Enabled = true;
                this.llb_down.Enabled = true;
            }
        }
    }
    public class CurrentPageIndexChangedEventArgs : EventArgs
    {
        private PageInfo _pageInfo = new PageInfo();
        public PageInfo PageInfo
        {
            set
            {
                this._pageInfo = value;
            }
            get
            {
                return this._pageInfo;
            }
        }
    }
}
