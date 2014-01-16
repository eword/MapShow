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
