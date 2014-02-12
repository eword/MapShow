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
    public partial class AreaManage : Form
    {
        AreaInfo _areaInfo;
        static AreaManage _areaManage;
        FormStatus _status;
        private AreaManage(FormStatus status, Guid id)
        {
            InitializeComponent();
            if (status.Equals(FormStatus.Add))
            {
                this._areaInfo = new AreaInfo() { ID = id };
                
            }
            else if (status.Equals(FormStatus.Edit))
            {
                this._areaInfo = Task.Init().TaskStation.GetAreaInfo(id);
            }
            this.bs_bindingSource.DataSource = this._areaInfo;
            this._status = status;
        }
        public static AreaManage Init(FormStatus status, Guid id)
        {
        
            if (_areaManage == null)
                _areaManage = new AreaManage(status, id);
            return _areaManage;
        }



        private void bt_getPoint_Click(object sender, EventArgs e)
        {
            GetPoint _gp;
            if ((this._areaInfo.lon * this._areaInfo.lat).Equals(0))
            {
                 _gp = new GetPoint(null);
            }
            else
            {
                GetPoint.MapPosition _mp = new GetPoint.MapPosition();
                _mp.X = this._areaInfo.lon;
                _mp.Y = this._areaInfo.lat;
                _mp.Zoom = this._areaInfo.Zoom;
                 _gp = new GetPoint(_mp);
            }
            _gp.GetPointCloed += new Code.GetPointCloedEventHandler((sender1, e1) =>
            {
                this.lb_lon.Text = e1.Lon.ToString();
                this.lb_lat.Text = e1.Lat.ToString();
                this.lb_zoom.Text = e1.Zoom.ToString();
            });
            _gp.ShowDialog();
        }
        /// <summary>
        /// 输入验证
        /// </summary>
        /// <returns>true:通过验证；false：未通过</returns>
        private bool InputValidation()
        {
            bool _return = true;
            string _str = string.Empty;
            if (!(double.Parse(this.lb_zoom.Text) > 0))
            {
                this.lb_zoom.Text = "1";
            }
            if (string.IsNullOrEmpty(this.tb_areaName.Text))
                _str += "请输入区域名称\r\n";
            if (string.IsNullOrEmpty(this.tb_easyCode.Text))
                _str += "请输入简码名称\r\n";
            if (string.IsNullOrEmpty(this.lb_lon.Text))
                _str += "请输入经度\r\n";
            if (string.IsNullOrEmpty(this.lb_lat.Text))
                _str += "请输入纬度\r\n";
            if (string.IsNullOrEmpty(this.lb_zoom.Text))
                _str += "请输入缩放率\r\n";
            if (string.IsNullOrEmpty(this.tb_order.Text))
                _str += "请输入排序号\r\n";
            if (!string.IsNullOrEmpty(_str))
            {
                MessageBox.Show(_str);
                _return = false;
            }
            return _return;
        }
        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (!this.InputValidation())
            {
                return;
            }
            try
            {
                if (this._status.Equals(FormStatus.Add))
                {
                    Task.Init().TaskStation.AddAreaInfo(this._areaInfo);
                }
                else if (this._status.Equals(FormStatus.Edit))
                {
                    Task.Init().TaskStation.EditAreaInfo(this._areaInfo);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Log.FileOperation.WriteErrorLog(ex.Message);
                MessageBox.Show("保存失败，详情请查看日志！@" + ex.Message);
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AreaManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            _areaManage =null;
        }
    }
}
