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
    public partial class OrganisationList : Form
    {
        private static OrganisationList _organisationList;
        private List<Organisation> _Organisations;
        Task _task;
        private OrganisationList()
        {
            InitializeComponent();
            _task = Task.Init();
            this.BindData();
            this.FormClosed += new FormClosedEventHandler(
                (sender1, e1) =>
                {
                    _organisationList = null;
                }
                );
        }
        public static OrganisationList Init()
        {
            if (_organisationList == null)
                _organisationList = new OrganisationList();
            return _organisationList;
        }
        public void BindData()
        {
            _Organisations = _task.TaskStation.GetOrganisationList();
            this.organisationBindingSource.DataSource = _Organisations;
        }
        #region event
        private void tsb_add_Click(object sender, EventArgs e)
        {
            OrganisationManage _om = OrganisationManage.Init(FormStatus.Add, Guid.NewGuid());
            _om.FormClosed += new FormClosedEventHandler(
                (sender1, e1) =>
                {
                    this.BindData();
                });
            _om.ShowDialog();
        }

        private void tsb_edit_Click(object sender, EventArgs e)
        {
            if (this.dgv_main.SelectedRows.Count > 0)
            {
                var _item = Guid.Parse(this.dgv_main.SelectedRows[0].Cells["ID"].Value.ToString());

                OrganisationManage _om = OrganisationManage.Init(FormStatus.Edit, _item);
                _om.FormClosed += new FormClosedEventHandler(
                    (sender1, e1) =>
                    {
                        this.BindData();
                    });
                _om.ShowDialog();
            }
        }

        private void tsb_del_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dgv_main.SelectedRows.Count > 0)
                {
                    var _name = this.dgv_main.SelectedRows[0].Cells["name"].Value.ToString();

                    if (!MessageBox.Show("确定要删除“" + _name + "”吗？", "确认", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                        return;

                    var _item = Guid.Parse(this.dgv_main.SelectedRows[0].Cells["ID"].Value.ToString());
                    if (Task.Init().TaskStation.DeleteOrganisation(_item))
                        this.BindData();
                    else
                        MessageBox.Show("删除失败！详情请查看日志！");
                }
            }
            catch (Exception ex)
            {
                Log.FileOperation.WriteErrorLog(ex.Message);
                MessageBox.Show("删除失败！详情请查看日志！");
            }
        }

        private void tsb_search_Click(object sender, EventArgs e)
        {
            var _result = _Organisations.Where(m => m.Name.Contains(this.tstb_searchText.Text));
            this.organisationBindingSource.DataSource = _result.ToList<Organisation>();
        }
        #endregion
    }
}
