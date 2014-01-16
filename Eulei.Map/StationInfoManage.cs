using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Eulei.Map.Code;
using TaskInterface;
namespace Eulei.Map
{
    public partial class StationInfoManage : Form
    {
        #region field
        private FormStatus _status;
        private static StationInfoManage _Init;
        private StationInfo _stationInfo;
        private string imageTargetPath = AppDomain.CurrentDomain.BaseDirectory + "Images\\";
        private List<StationImageInfo> _stationImageInfos;
        Task _task;
        #endregion
        private StationInfoManage(Guid id)
        {
            InitializeComponent();
            _task = Task.Init();
            if (_task.TaskStation.ExistsStationInfo(id)>0)
            {
                this._stationInfo = _task.TaskStation.GetStationInfo(id);
                this._status = FormStatus.Edit;
            }
            else
            {
                this._stationInfo = new StationInfo() { ID = Guid.NewGuid(), FID = id };
                this._status = FormStatus.Add;
            }                  
        
            this.FormClosed += new FormClosedEventHandler((sender1, e1) =>
            {
                _task.Dispose();
                _task = null;
                _Init = null;
            });
            this.BindDate();
        }
        private void BindDate()
        {
            this.lv_man.Items.Clear();
            this.il_main.Images.Clear();
            this.bs_main.DataSource = this._stationInfo;
            this._stationImageInfos=_task.TaskStation.GetStationImageInfoList(this._stationInfo.FID);
            this.lv_man.View = View.LargeIcon;
            this.lv_man.LargeImageList = this.il_main;
            this.lv_man.BeginUpdate();
            foreach (var item in this._stationImageInfos)
            {
                string _path=this.imageTargetPath+item.ImagePath;
                if (File.Exists(_path))
                {
                    Image _im = Image.FromFile(_path);
                    this.il_main.Images.Add(item.ID.ToString(), _im);
                    ListViewItem _lvi = new ListViewItem();
                    _lvi.ImageKey = item.ID.ToString();
                    _lvi.Text = item.Title;
                    this.lv_man.Items.Add(_lvi);
                }
                else
                {
                    _path = AppDomain.CurrentDomain.BaseDirectory + "Resources\\Lose.jpg";
                    if (File.Exists(_path))
                    {
                        Image _im = Image.FromFile(_path);
                        this.il_main.Images.Add(item.ID.ToString(), _im);                       
                        ListViewItem _lvi = new ListViewItem();
                        _lvi.ImageKey = item.ID.ToString();
                        _lvi.Text = item.Title;
                        this.lv_man.Items.Add(_lvi);
                    }
                }
            }
      
            //for (int _i = 0; _i < this.il_main.Images.Count; _i++)
            //{
            //    ListViewItem _lvi = new ListViewItem();
            //    _lvi.ImageKey = this._stationImageInfos[_i].ID.ToString();
            //    _lvi.Text = this._stationImageInfos[_i].Title;
            //    this.lv_man.Items.Add(_lvi);
            //}
            this.lv_man.EndUpdate();
        }

        public static StationInfoManage Init(Guid id)
        {
            if (_Init == null)
                _Init = new StationInfoManage(id);
            return _Init;
        }
        #region event

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (this._status.Equals(FormStatus.Add))
            {
                Task.Init().TaskStation.AddStationInfo(this._stationInfo);
            }
            else if (this._status.Equals(FormStatus.Edit))
            {
                Task.Init().TaskStation.EditStationInfo(this._stationInfo);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bt_ImageInfo_Click(object sender, EventArgs e)
        {
            if (this._status.Equals(FormStatus.Add))
            {
                if (MessageBox.Show("当前新增详细信息未保存，设置图像需要先保存！是否保存并继续？", "提醒", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    Task.Init().TaskStation.AddStationInfo(this._stationInfo);
                    this._status = FormStatus.Edit;

                }
                else
                {
                    return;
                }
            }
            ImageInfoManage _iim = ImageInfoManage.Init(FormStatus.Add,this._stationInfo.FID);
            _iim.FormClosed += new FormClosedEventHandler(
                (sender1, e1) =>
                {
                    this.BindDate();
                }
                );
            _iim.ShowDialog();
           
        }
        #endregion

        private void bt_editImageInfo_Click(object sender, EventArgs e)
        {
            ListView _sender = this.lv_man as ListView;
            if (_sender.SelectedItems.Count < 1)
            {
                MessageBox.Show("请选选择一张图片！");
            }
            foreach (var item in _sender.SelectedItems)
            {
                ListViewItem _lvi = item as ListViewItem;
                Guid _id =Guid.Parse(_lvi.ImageKey);
                ImageInfoManage _iim = ImageInfoManage.Init(FormStatus.Edit, _id);
                _iim.FormClosed += new FormClosedEventHandler(
                    (sender1, e1) =>
                    {
                        this.BindDate();
                    }
                    );
                _iim.ShowDialog();
            }

        }

        private void tb_del_Click(object sender, EventArgs e)
        {
            ListView _sender = this.lv_man as ListView;
            if (_sender.SelectedItems.Count < 1)
            {
                MessageBox.Show("请选选择一张图片！");
            }
            foreach (var item in _sender.SelectedItems)
            {
                ListViewItem _lvi = item as ListViewItem;
                Guid _id = Guid.Parse(_lvi.ImageKey);
                if (MessageBox.Show("确定要删除图片吗？", "警告", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    if (_task.TaskStation.DeleteStationImageInfo(_id))
                    {
                        MessageBox.Show("成功删除");
                        this.BindDate();
                    }
                }
            }
        }
    }
}
