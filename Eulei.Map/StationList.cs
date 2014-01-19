using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using TaskInterface;
using Eulei.Map.Code;
using Eulei.Linq;
using System.Web;
namespace Eulei.Map
{
    public partial class StationList : Form
    {
        #region Field
        private static StationList _stationList;
        private List<AreaInfo> _areaInfo;
        private Guid _areaInfoID = Guid.NewGuid();
        private Guid _organisationID = Guid.NewGuid();
        private List<Organisation> _organisation;
        private List<VW_Statuion> _vw_stations;
        Task _task;
        string _sql = " 1=1 ";
        object[] _params = new string[] { "" };
        #endregion
        public StationList()
        {
            InitializeComponent();
            this.Load += StationList_Load;

        }

        void StationList_Load(object sender, EventArgs e)
        {
            _task = Task.Init();
            this.FormClosed += new FormClosedEventHandler(
                (sender1, e1) =>
                {
                    _task.Dispose();
                    _stationList = null;
                }
                );
            this._areaInfo = _task.TaskStation.GetAreaList();
            this._organisation = _task.TaskStation.GetOrganisationList();
            this._areaInfo.Add(new AreaInfo() { ID = _areaInfoID, Name = "全部" });
            this._organisation.Add(new Organisation() { ID = _organisationID, Name = "全部" });
            this.cb_area.DataSource = _areaInfo;
            this.cb_organisation.DataSource = _organisation;
            this.cb_area.DisplayMember = "Name";
            this.cb_area.ValueMember = "ID";
            this.cb_organisation.DisplayMember = "Name";
            this.cb_organisation.ValueMember = "ID";
            this.cb_area.SelectedValue = _areaInfoID;
            this.cb_organisation.SelectedValue = _organisationID;
            this.pager1.PageInfoEventArgs.PageInfo.PageSize = 20;
            this.pager1.PageInfoEventArgs.PageInfo.CurrentPageIndex = 1;
            this.pager1.PageInfoEventArgs.PageInfo.RecordCount =0;
            BindData();
            this.pager1.Refresh();
            ////this.winGridViewPager1.AppendedMenu = this.contextMenuStrip1;
        }
        #region method
        public static StationList Init()
        {
            if (_stationList == null)
                _stationList = new StationList();
            return _stationList;
        }
        public void BindData()
        {
            this.pager1.PageInfoEventArgs.PageInfo.RecordCount = _task.TaskStation.GetVW_StatuionList(this._sql, this._params);
            this._vw_stations = _task.TaskStation.GetVW_StatuionList(this._sql, this._params, this.pager1.PageInfoEventArgs.PageInfo.PageSize * (this.pager1.PageInfoEventArgs.PageInfo.CurrentPageIndex - 1), this.pager1.PageInfoEventArgs.PageInfo.PageSize);
            this.bs_main.DataSource = this._vw_stations;
            //#region 添加别名解析
            //this.winGridViewPager1.AddColumnAlias("ID", "编号");
            //this.winGridViewPager1.AddColumnAlias("Num", "网点编号");
            //this.winGridViewPager1.AddColumnAlias("Name", "网点名称");
            //this.winGridViewPager1.AddColumnAlias("TEL", "联系电话");
            //this.winGridViewPager1.AddColumnAlias("Fax", "传真");
            //this.winGridViewPager1.AddColumnAlias("Address", "地址");
            //this.winGridViewPager1.AddColumnAlias("AreaInfoName", "区域");
            //this.winGridViewPager1.AddColumnAlias("OrganisationName", "机构");
            //#endregion

            ////每页记录数
            //this.winGridViewPager1.PagerInfo.PageSize = 10;
            ////查询
            //_vw_stations = _task.TaskStation.GetVW_StatuionList(this._sql,this._params, this.winGridViewPager1.PagerInfo.PageSize * (this.winGridViewPager1.PagerInfo.CurrenetPageIndex - 1), this.winGridViewPager1.PagerInfo.PageSize);
            ////总记录数
            //this.winGridViewPager1.PagerInfo.RecordCount = _task.TaskStation.GetVW_StatuionList(this._sql,this._params);           
            ////显示哪些列
            //this.winGridViewPager1.DisplayColumns = @"Num,Name,TEL,Fax,Address,AreaInfoName,OrganisationName";
            //this.winGridViewPager1.DataSource = new WHC.Pager.WinControl.SortableBindingList<VW_Statuion>(_vw_stations.ToList<VW_Statuion>());
            //this.winGridViewPager1.dataGridView1.Refresh();
        }
        #endregion
        #region event
        private void winGridViewPager1_OnRefresh(object sender, EventArgs e)
        {
            BindData();
        }

        private void winGridViewPager1_OnDeleteSelected(object sender, EventArgs e)
        {
            DataGridView grid = this.dgv_main;
            if (grid != null)
            {
                foreach (DataGridViewRow row in grid.SelectedRows)
                {
                    string _name = row.Cells["Name"].Value != null ? row.Cells["Name"].Value.ToString() :
                        row.Cells["Num"].Value != null ? row.Cells["Num"].Value.ToString() : "";
                    if (!MessageBox.Show("您确定删除“" + _name + "”这条记录么？", "提醒", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
                    {
                        return;
                    }
                    _task.TaskStation.DeleteStation(Guid.Parse(row.Cells["ID"].Value.ToString()));
                }
                BindData();
            }
        }

        private void winGridViewPager1_OnEditSelected(object sender, EventArgs e)
        {
             DataGridView grid = this.dgv_main;
            if (grid != null)
            {
                foreach (DataGridViewRow row in grid.SelectedRows)
                {
                    StationManage _sm = StationManage.Init(FormStatus.Edit, Guid.Parse(row.Cells["ID"].Value.ToString()));
                    if (_sm.ShowDialog().Equals(DialogResult.OK))
                    {
                        BindData();
                    }
                    break;
                }
            }
        }

        private void winGridViewPager1_OnAddNew(object sender, EventArgs e)
        {
            StationManage _sm = StationManage.Init(FormStatus.Add, Guid.NewGuid());
            if (DialogResult.OK == _sm.ShowDialog())
            {
                BindData();
            }
        }
 


        private void bt_reset_Click(object sender, EventArgs e)
        {
            this._sql = " 1=1 ";
            this._params = null;
            this._params = new string[]{""};
            this.tb_Name.Text = string.Empty;
            this.tb_num.Text = string.Empty;
            this.tb_tel.Text = string.Empty;
            this.cb_area.SelectedValue = _areaInfoID;
            this.cb_organisation.SelectedValue = _organisationID;
            this.BindData();
        }
        private void bt_search_Click(object sender, EventArgs e)
        {  
            string m_searchName = string.IsNullOrWhiteSpace(this.tb_Name.Text) ? "" : this.tb_Name.Text.Trim();
            string m_searchNum = string.IsNullOrWhiteSpace(this.tb_num.Text) ? "" : this.tb_num.Text.Trim();
            string m_searchTEL = string.IsNullOrWhiteSpace(this.tb_tel.Text) ? "" : this.tb_tel.Text.Trim();
            Guid m_searchAreaID = this.cb_area.SelectedValue.Equals(_areaInfoID) ? _areaInfoID : (Guid)this.cb_area.SelectedValue;
            Guid m_searchOrganisation = this.cb_organisation.SelectedValue.Equals(_organisationID) ? _organisationID : (Guid)this.cb_organisation.SelectedValue;
            this._params = null;
            this._params = new object[2];
            //生成查询语句
            _sql = " 1=1 ";
            //网点名称     
            if (!string.IsNullOrEmpty(m_searchName))
                if (_sql.Equals(""))
                {
                    _sql = _sql
                        + " ("
                        + "StationName.Contains(\"" + m_searchName + "\")"
                        + ")";
                }
                else
                {
                    _sql = _sql
                        + "  and  "
                        + "  ("
                        + "StationName.Contains(\"" + m_searchName + "\")"
                        + ")";
                }

            //网点编号
            if (!string.IsNullOrEmpty(m_searchNum))
                if (_sql.Equals(""))
                {
                    _sql = _sql
                        + " ("
                        + "StationNum.Contains(\"" + m_searchNum + "\")"
                        + ") ";
                }
                else
                {
                    _sql = _sql
                       + "  and  "
                        + "  ("
                        + "StationNum.Contains(\"" + m_searchNum + "\")"
                        + ") ";
                }

            //网点电话

            if (!string.IsNullOrEmpty(m_searchTEL))
                if (_sql.Equals(""))
                {
                    _sql = _sql
                        + " ("
                        + "StationTEL.Contains(\"" + m_searchTEL + "\")"
                        + ")";
                }
                else
                {
                    _sql = _sql
                      + "  and "
                        + "  ("
                        + "StationTEL.Contains(\"" + m_searchTEL + "\")"
                        + ")";
                }

            //网点区域ID

            if (!m_searchAreaID.Equals(_areaInfoID))
            {
                if (_sql.Equals(""))
                {
                    _sql = _sql
                        + " ("
                        + "StationAreaID.Equals(@0)"
                        + ")";
                }
                else
                {
                    _sql = _sql
                      + " and "
                        + "  ("
                        + "StationAreaID.Equals(@0)"
                        + ")";
                }
                this._params[0] = m_searchAreaID;
            }
            //网点机构ID

            if (!m_searchOrganisation.Equals(_organisationID))
            {
                if (_sql.Equals(""))
                {
                    _sql = _sql
                        + " ("
                        + "StationOrganisationID.Equals(@1)"
                        + ")";
                }
                else
                {
                    _sql = _sql
                      + " and "
                        + "  ("
                        + "StationOrganisationID.Equals(@1)"
                        + ")";
                }
                this._params[1] = m_searchOrganisation;
            }    
            this.BindData();
        }
        #endregion

        private void pager1_CurrentPageIndexChanged(object sender, MyControl.CurrentPageIndexChangedEventArgs e)
        {
            this.BindData();
        }


    }
}

