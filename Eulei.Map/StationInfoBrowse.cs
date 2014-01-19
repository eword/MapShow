using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TaskInterface;
using Eulei.Map.Code;
using System.IO;
namespace Eulei.Map
{
    public partial class StationInfoBrowse : Form
    {
        #region method
        private string _icoBasePath = AppDomain.CurrentDomain.BaseDirectory + "Resources\\";
        private static StationInfoBrowse _init;
        private Task _task;
        private VW_Statuion _vw_statuion;
        private List<StationImageInfo> _stationImageInfos;
        private string imageTargetPath = AppDomain.CurrentDomain.BaseDirectory + "Images\\";
        private Guid _id;
        #endregion
        private StationInfoBrowse(Guid id)
        {
            InitializeComponent();
            this._id = id;
            this._task = Task.Init();
            this.BindData();
            this.FormClosed += new FormClosedEventHandler((sender1, e1) =>
            {
                _task.Dispose();
                _task = null;
                _init = null;
            });
            this.bt_playOrpause.Text = this.timer1.Enabled ? "‖" : "Play";
            this.lb_timer.Text = string.Format("{0}.{1}秒", this.trackBar1.Value / 1000, (this.trackBar1.Value % 1000) / 100);
        }
        private void BindData()
        {           
            this._vw_statuion = _task.TaskStation.GetVW_Station(this._id);
            this._stationImageInfos = _task.TaskStation.GetStationImageInfoList(this._id);
            foreach (var item in this._stationImageInfos)
            {
                item.ImagePath = imageTargetPath + item.ImagePath;
            }
            string icopatch = _icoBasePath + this._vw_statuion.ImageName + ".ico";
            if (File.Exists(icopatch))
            {
                this.Icon = new Icon(icopatch);
            }
            else
            {
                MessageBox.Show(icopatch);
            }
            this.Info_bindingSource.DataSource = this._vw_statuion;
            this.bs_picture.DataSource = this._stationImageInfos;
        }
        public static StationInfoBrowse Init(Guid id)
        {
            if (_init == null)
                _init = new StationInfoBrowse(id);
            return _init;
        }

        private void bt_left_Click(object sender, EventArgs e)
        {
            int _currentIndex = this.bs_picture.IndexOf(this.bs_picture.Current);
            if (_currentIndex.Equals(0))
            {
                this.bs_picture.MoveLast();
            }
            else
            {
                this.bs_picture.MovePrevious();
            }
        }

        private void bt_playOrpause_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = !this.timer1.Enabled;
            this.bt_playOrpause.Text = this.timer1.Enabled ? "‖" : "Play";
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            this.bt_playOrpause.Text = this.timer1.Enabled ? "‖" : "Play";
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            int _currentIndex = this.bs_picture.IndexOf(this.bs_picture.Current);
           
            if ((_currentIndex + 1) < this.bs_picture.Count)
            {
                this.bs_picture.MoveNext();
            }
            else
            {
                this.bs_picture.MoveFirst();
            }
        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        bool _isFullPlay = false;
        Form _showForm;
        private void bt_fullPlay_Click(object sender, EventArgs e)
        {

            if (_isFullPlay)
            {
                _showForm.Close();
            }
            else
            {
                _showForm = new Form();
                _showForm.FormBorderStyle = FormBorderStyle.None;
                _showForm.WindowState = FormWindowState.Maximized;
                _showForm.TopMost = true;
                _showForm.Show();
                _showForm.FormClosed += new FormClosedEventHandler((sender1, e1) =>
                {
                    this.bt_fullPlay.Text = "全屏";
                    this.pl_playBox.Dock = DockStyle.Fill;
                    SetParent(this.pl_playBox.Handle, this.gb_picBox.Handle);
                    _isFullPlay = !_isFullPlay;
                    this.Focus();
                });
                _showForm.KeyUp += new KeyEventHandler((sender1, e1) =>
                {

                    if (e1.KeyCode.Equals(Keys.Escape))
                    {
                        ((Form)sender1).Close();
                    }
                });

                this.pl_playBox.Dock = DockStyle.None;
                this.pl_playBox.Left = 0;
                this.pl_playBox.Top = 0;
                this.pl_playBox.Width = Screen.PrimaryScreen.Bounds.Width;
                this.pl_playBox.Height = Screen.PrimaryScreen.WorkingArea.Height;
                SetParent(this.pl_playBox.Handle, _showForm.Handle);
                this.bt_fullPlay.Text = "退出全屏";
                _isFullPlay = !_isFullPlay;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int _currentIndex = this.bs_picture.IndexOf(this.bs_picture.Current);
            if ((_currentIndex + 1) <this.bs_picture.Count)
            {
                this.bs_picture.MoveNext();
            }
            else
            {
                this.bs_picture.MoveFirst();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.timer1.Interval = this.trackBar1.Value;
            this.lb_timer.Text = string.Format("{0}.{1}秒", this.trackBar1.Value / 1000, (this.trackBar1.Value%1000)/100);
        }

        private void llb_edit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (this._vw_statuion != null)
            {

                StationManage _sm = StationManage.Init(FormStatus.Edit, this._vw_statuion.ID);
                    if (_sm.ShowDialog().Equals(DialogResult.OK))
                    {
                        BindData();
                    }
              
           
            }
        }


    }
}
