using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TaskInterface;
using Eulei.Map.Code;
namespace Eulei.Map
{
    public partial class ImageInfoManage : Form
    {

        #region field
        private FormStatus _status;
        private static ImageInfoManage _Init;
        private StationImageInfo _stationImageInfo;
        //程序路径
        private string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private string imageTargetPath = AppDomain.CurrentDomain.BaseDirectory + "Images\\";
        Task _task;
        #endregion
        private ImageInfoManage(FormStatus status, Guid id)
        {
            InitializeComponent();
            _task = Task.Init();
            if (status.Equals(FormStatus.Add))
            {
                this._stationImageInfo = new StationImageInfo() { PID = id, ID = Guid.NewGuid() };
            }
            else if (status.Equals(FormStatus.Edit))
            {
                this._stationImageInfo = _task.TaskStation.GetStationImageInfo(id);
            }
            this._status = status;
            this.FormClosed += new FormClosedEventHandler((sender1, e1) =>
            {
                _task.Dispose();
                _task = null;
                _Init = null;
            });
            this.BindDate();
        }
        public static ImageInfoManage Init(FormStatus status, Guid id)
        {
            if (_Init == null)
                _Init = new ImageInfoManage(status, id);
            return _Init;
        }
        private void BindDate()
        {
            this.bs_main.DataSource = this._stationImageInfo;
            this.pictureBox1.ImageLocation =this.imageTargetPath+ this._stationImageInfo.ImagePath;
        }
        #region event
        private void bt_uploadOrSelect_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.DefaultExt = "*.jpg|*.gif|*.png|*.bmp|*";
                openFileDialog1.InitialDirectory = this.imageTargetPath;
                openFileDialog1.Filter = "jpg file (*.jpg)|*.jpg|gif file (*.gif)|*.gif|png file (*.png)|*.png|bmp file (*.bmp)|*.bmp|all file (*.*)|*.*";
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                if (openFileDialog1.FileName == "")
                    return;
                string sourcePath = openFileDialog1.FileName;
                if (!sourcePath.Contains(this.imageTargetPath))
                {
                    if (MessageBox.Show("当前选中文件不在程序文件夹，是否复制到程序文件夹？选No着不复制，重新选择！"
                         , "提醒", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)
                         )
                    {
                        string targetPath = this.imageTargetPath + openFileDialog1.SafeFileName;
                        if (!CopyFileHelper.CopyFile(sourcePath, targetPath))
                        {
                            MessageBox.Show("文件复制失败！");
                            return;
                        }
                    }
                }
                this.tb_path.Text = openFileDialog1.SafeFileName;
                this.pictureBox1.ImageLocation = this.imageTargetPath + openFileDialog1.SafeFileName;
            }
            catch (Exception ex)
            {
                Log.FileOperation.WriteErrorLog(ex.Message);
                MessageBox.Show("文件复制失败！");
            }
        }
        /// <summary>
        /// 输入验证
        /// </summary>
        /// <returns>true:通过验证；false：未通过</returns>
        private bool InputValidation()
        {
            bool _return = true;
            string _str = string.Empty;
            if (string.IsNullOrEmpty(this.tb_title.Text))
                _str += "请输入图片标题\r\n";
            if (string.IsNullOrEmpty(this.tb_path.Text))
                _str += "请选择一张图片\r\n";           
            if (!string.IsNullOrEmpty(_str))
            {
                MessageBox.Show(_str);
                _return = false;
            }
            return _return;
        }
        private void tb_OK_Click(object sender, EventArgs e)
        {
            if (!this.InputValidation())
            {
                return;
            }

            if (this._status.Equals(FormStatus.Add))
            {
                Task.Init().TaskStation.AddStationImageInfo(this._stationImageInfo);
            }
            else if (this._status.Equals(FormStatus.Edit))
            {
                Task.Init().TaskStation.EditStationImageInfo(this._stationImageInfo);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void tb_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}
