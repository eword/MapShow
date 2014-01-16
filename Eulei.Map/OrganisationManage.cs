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
        private void bt_Ok_Click(object sender, EventArgs e)
        {
            try
            {
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
                MessageBox.Show("保存失败，详情请查看日志！");
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

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
        #endregion

    }
}
