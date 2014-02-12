using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Eulei.Map.Code;
using TaskInterface;
namespace Eulei.Map
{
    public partial class OrganisationManage : Form
    {
        private FormStatus _status;
        private static OrganisationManage _Init;
        private Organisation _organisation;
        private OrganisationManage(FormStatus status, Guid id)
        {
            InitializeComponent();
            if (status.Equals(FormStatus.Add))
            {
                this._organisation = new Organisation() { ID = id };

            }
            else if (status.Equals(FormStatus.Edit))
            {
                this._organisation = Task.Init().TaskStation.GetOrganisation(id);
            }
            this.bs_bindingSource.DataSource = this._organisation;
            this._status = status;
            this.FormClosed += new FormClosedEventHandler((sender1, e1) => {
                _Init = null;
            });
        }
        public static OrganisationManage Init(FormStatus status, Guid id)
        {
            if (_Init == null)
                _Init = new OrganisationManage(status, id);
            return _Init;
        }
        #region event
        /// <summary>
        /// 输入验证
        /// </summary>
        /// <returns>true:通过验证；false：未通过</returns>
        private bool InputValidation()
        {
            bool _return = true;
            string _str = string.Empty;
            if (!(double.Parse(this.lb_mapZoom.Text) > 0))
            {
                this.lb_mapZoom.Text = "1";
            }
            if (string.IsNullOrEmpty(this.tb_name.Text))
                _str += "请输入机构名称\r\n";
            if (string.IsNullOrEmpty(this.tb_centerName.Text))
                _str += "请输入主要办公点名称\r\n";
            if (string.IsNullOrEmpty(this.lb_mapZoom.Text))
                _str += "请输入经纬度及缩放率\r\n";
            if (string.IsNullOrEmpty(this.tb_order.Text))
                _str += "请输入排序号\r\n";
            if (!string.IsNullOrEmpty(_str))
            {
                MessageBox.Show(_str);
                _return = false;
            }
            return _return;
        }
        private void bt_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.InputValidation())
                {
                    return;
                }
                if (this._status.Equals(FormStatus.Add))
                {
                    Task.Init().TaskStation.AddOrganisation(this._organisation);
                }
                else if (this._status.Equals(FormStatus.Edit))
                {
                    Task.Init().TaskStation.EditOrganisation(this._organisation);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Log.FileOperation.WriteErrorLog(ex.Message);
                MessageBox.Show("保存失败，详情请查看日志！@"+ex.Message);
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bt_getPoint_Click(object sender, EventArgs e)
        {
            GetPoint _gp;
            if ((this._organisation.Maplon * this._organisation.Maplat).Equals(0))
            {
                 _gp = new GetPoint(null);
            }
            else
            {
                GetPoint.MapPosition _mp = new GetPoint.MapPosition();
                _mp.X = this._organisation.Maplon;
                _mp.Y = this._organisation.Maplat;
                _mp.Zoom = this._organisation.MapZoom;
                _gp = new GetPoint(_mp);
            }
            _gp.GetPointCloed += new Code.GetPointCloedEventHandler((sender1, e1) =>
            {
                this.lb_lon.Text = e1.Lon.ToString();
                this.lb_lat.Text = e1.Lat.ToString();
                this.lb_mapLon.Text = e1.Lon.ToString();
                this.lb_mapLat.Text = e1.Lat.ToString();
                this.lb_mapZoom.Text = e1.Zoom.ToString();
            });
            _gp.ShowDialog();
        }
        #endregion

    }
}
