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
    public partial class AreaList : Form
    {
        List<AreaInfo> _areaInfos;
        public AreaList()
        {
            InitializeComponent();
            this.SetMenu();
            this.Init();
          
        }
        #region 权限控制
        private void SetMenu()
        {
            AuthortyControl _ac = AuthortyControl.Init();
            this.tsb_add.Visible = _ac.Control.GetAuthority("AreaInfoAdd");
            this.tsb_del.Visible = _ac.Control.GetAuthority("AreaInfoAdd"); 
            _ac.Dispose();
        }
        #endregion
        void Init()
        {_areaInfos= Task.Init().TaskStation.GetAreaList();
        this.bindingSource1.DataSource = _areaInfos;

        }

        private void tsb_add_Click(object sender, EventArgs e)
        {
            AreaManage _al = AreaManage.Init(FormStatus.Add, Guid.NewGuid());
            _al.FormClosed += new FormClosedEventHandler(
                (sender1, e1) =>
                {
                    this.Init();
                });
            _al.ShowDialog();
        }

        private void tsb_edit_Click(object sender, EventArgs e)
        {
            if (this.dgv_main.SelectedRows.Count > 0)
            {
                var _item = Guid.Parse(this.dgv_main.SelectedRows[0].Cells["ID"].Value.ToString());

                AreaManage _al = AreaManage.Init(FormStatus.Edit, _item);
                _al.FormClosed += new FormClosedEventHandler(
                    (sender1, e1) =>
                    {
                        this.Init();
                    });
                _al.ShowDialog();
            }
        }

        private void tsb_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgv_main.SelectedRows.Count > 0)
                {
                    var _name = this.dgv_main.SelectedRows[0].Cells["areaName"].Value.ToString();
                    if (!MessageBox.Show("确定要删除“" + _name + "”吗？", "确认", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                        return;

                    var _item = Guid.Parse(this.dgv_main.SelectedRows[0].Cells["ID"].Value.ToString());
                    if (Task.Init().TaskStation.DeleteAreaInfo(_item))
                        this.Init();
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
            var _result = _areaInfos.Where(m => m.Name.Contains(this.tstb_searchText.Text));
            this.bindingSource1.DataSource = _result.ToList<AreaInfo>();
        }
    }
}
