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
    public partial class StationManage : Form
    {
        #region field
        private FormStatus _status;
        private static StationManage _Init;
        private Station _station;
        Task _task;
        #endregion
        private StationManage(FormStatus status, Guid id)
        {
            InitializeComponent();
            _task = Task.Init();
            if (status.Equals(FormStatus.Add))
            {
                this._station = new Station() { ID = id };

            }
            else if (status.Equals(FormStatus.Edit))
            {
                this._station = _task.TaskStation.GetStation(id);
            }
            this.bs_bindingSource.DataSource = this._station;
            this.bs_areabindingSource.DataSource = _task.TaskStation.GetAreaList();
            this.bs_OrganisationbindingSource.DataSource = _task.TaskStation.GetOrganisationList();
            this._status = status;
            this.FormClosed += new FormClosedEventHandler((sender1, e1) =>
            {
                _task.Dispose();
                _task = null;
                _Init = null;
            });
        }
        public static StationManage Init(FormStatus status, Guid id)
        {
            if (_Init == null)
                _Init = new StationManage(status, id);
            return _Init;
        }
        #region method
        /// <summary>
        /// 输入验证
        /// </summary>
        /// <returns>true:通过验证；false：未通过</returns>
        private bool InputValidation()
        {
            bool _return = true;
            string _str = string.Empty;
            if (string.IsNullOrEmpty(this.tb_num.Text))
                _str += "请输入网点编号\r\n";
            if (string.IsNullOrEmpty(this.tb_name.Text))
                _str += "请输入网点名称\r\n";
            if (string.IsNullOrEmpty(this.tb_tel.Text))
                _str += "请输入网点电话\r\n";
            if (string.IsNullOrEmpty(this.cb_area.Text))
                _str += "请选择区域\r\n";
            if (string.IsNullOrEmpty(this.cb_organization.Text))
                _str += "请选择机构\r\n";
            if (!string.IsNullOrEmpty(_str))
            {
                MessageBox.Show(_str);
                _return = false;
            }
            return _return;
        }
        #endregion
        #region event
        private void bt_getPoint_Click(object sender, EventArgs e)
        {
            GetPoint _gp = new GetPoint();
            _gp.GetPointCloed += new Code.GetPointCloedEventHandler((sender1, e1) =>
            {
                this.lb_lon.Text = e1.Lon.ToString();
                this.lb_lat.Text = e1.Lat.ToString();
            });
            _gp.ShowDialog();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (!this.InputValidation())
            {
                return;
            }
            if (this._status.Equals(FormStatus.Add))
            {
                Task.Init().TaskStation.AddStation(this._station);
            }
            else if (this._status.Equals(FormStatus.Edit))
            {
                Task.Init().TaskStation.EditStation(this._station);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void tb_sataionInfo_Click(object sender, EventArgs e)
        {

            if (this._status.Equals(FormStatus.Add))
            {
                if (MessageBox.Show("当前新增详细信息未保存，是否保存并继续？", "提醒", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                {
                    if (!this.InputValidation())
                    {
                        return;
                    }
                    Task.Init().TaskStation.AddStation(this._station);
                    this._status = FormStatus.Edit;
                }
                else
                {
                    return;
                }
            }
            StationInfoManage _si = StationInfoManage.Init(this._station.ID);
            _si.FormClosed += new FormClosedEventHandler(
                (sender1, e1) =>
                {

                }
                );
            _si.ShowDialog();

        }
        #endregion
    }
}
