namespace Eulei.Map
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VW_StatuionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cms_listView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_showSatationForListView = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.miniToolStrip = new System.Windows.Forms.StatusStrip();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsb_NoSelected = new System.Windows.Forms.ToolStripButton();
            this.tsb_zoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsb_zoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsb_Pan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_fullShowMap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_reset = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmi_systemManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_openGST = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_saveCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_default = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_logOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_infoManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_organisationList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_areas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_stationList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_skin = new System.Windows.Forms.ToolStripMenuItem();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.eP_siteList = new BSE.Windows.Forms.Panel();
            this.sc_main = new System.Windows.Forms.SplitContainer();
            this.bt_serch = new System.Windows.Forms.Button();
            this.tb_searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tv_main = new System.Windows.Forms.TreeView();
            this.lb_pageInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llb_last = new System.Windows.Forms.LinkLabel();
            this.llb_first = new System.Windows.Forms.LinkLabel();
            this.llb_down = new System.Windows.Forms.LinkLabel();
            this.llb_up = new System.Windows.Forms.LinkLabel();
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_map = new System.Windows.Forms.TabPage();
            this.axMap1 = new AxMapXLib.AxMap();
            this.tp_report = new System.Windows.Forms.TabPage();
            this.rv_main = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tsc_main = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cms_organisation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_organisation = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.VW_StatuionBindingSource)).BeginInit();
            this.cms_listView.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.eP_siteList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).BeginInit();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tc_main.SuspendLayout();
            this.tp_map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.tp_report.SuspendLayout();
            this.tsc_main.ContentPanel.SuspendLayout();
            this.tsc_main.TopToolStripPanel.SuspendLayout();
            this.tsc_main.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cms_organisation.SuspendLayout();
            this.SuspendLayout();
            // 
            // VW_StatuionBindingSource
            // 
            this.VW_StatuionBindingSource.DataSource = typeof(TaskInterface.VW_Statuion);
            // 
            // cms_listView
            // 
            this.cms_listView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_showSatationForListView});
            this.cms_listView.Name = "cms_listView";
            this.cms_listView.Size = new System.Drawing.Size(149, 26);
            // 
            // tsmi_showSatationForListView
            // 
            this.tsmi_showSatationForListView.Name = "tsmi_showSatationForListView";
            this.tsmi_showSatationForListView.Size = new System.Drawing.Size(148, 22);
            this.tsmi_showSatationForListView.Text = "显示详细信息";
            this.tsmi_showSatationForListView.Click += new System.EventHandler(this.tsmi_showSatationForListView_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(1143, 23);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1141, 22);
            this.miniToolStrip.TabIndex = 2;
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.BackColor = System.Drawing.Color.White;
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_NoSelected,
            this.tsb_zoomIn,
            this.tsb_zoomOut,
            this.tsb_Pan,
            this.toolStripSeparator1,
            this.tsb_fullShowMap,
            this.toolStripSeparator3,
            this.tsb_reset});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(804, 39);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // tsb_NoSelected
            // 
            this.tsb_NoSelected.BackColor = System.Drawing.Color.Transparent;
            this.tsb_NoSelected.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_NoSelected.Image = global::Eulei.Map.Properties.Resources.NoSelected;
            this.tsb_NoSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_NoSelected.Name = "tsb_NoSelected";
            this.tsb_NoSelected.Size = new System.Drawing.Size(36, 36);
            this.tsb_NoSelected.Text = "未选择";
            this.tsb_NoSelected.ToolTipText = "未选择";
            this.tsb_NoSelected.Click += new System.EventHandler(this.tsb_NoSelected_Click);
            // 
            // tsb_zoomIn
            // 
            this.tsb_zoomIn.BackColor = System.Drawing.Color.Transparent;
            this.tsb_zoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_zoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsb_zoomIn.Image")));
            this.tsb_zoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_zoomIn.Name = "tsb_zoomIn";
            this.tsb_zoomIn.Size = new System.Drawing.Size(36, 36);
            this.tsb_zoomIn.Text = "放大";
            this.tsb_zoomIn.ToolTipText = "放大";
            this.tsb_zoomIn.Click += new System.EventHandler(this.tsb_zoomIn_Click);
            // 
            // tsb_zoomOut
            // 
            this.tsb_zoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_zoomOut.Image = global::Eulei.Map.Properties.Resources.zoomOut;
            this.tsb_zoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_zoomOut.Name = "tsb_zoomOut";
            this.tsb_zoomOut.Size = new System.Drawing.Size(36, 36);
            this.tsb_zoomOut.Text = "缩小";
            this.tsb_zoomOut.ToolTipText = "缩小";
            this.tsb_zoomOut.Click += new System.EventHandler(this.tsb_zoomOut_Click);
            // 
            // tsb_Pan
            // 
            this.tsb_Pan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Pan.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Pan.Image")));
            this.tsb_Pan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Pan.Name = "tsb_Pan";
            this.tsb_Pan.Size = new System.Drawing.Size(36, 36);
            this.tsb_Pan.Text = "拖动";
            this.tsb_Pan.Click += new System.EventHandler(this.tsb_Pan_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsb_fullShowMap
            // 
            this.tsb_fullShowMap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_fullShowMap.Image = ((System.Drawing.Image)(resources.GetObject("tsb_fullShowMap.Image")));
            this.tsb_fullShowMap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_fullShowMap.Name = "tsb_fullShowMap";
            this.tsb_fullShowMap.Size = new System.Drawing.Size(60, 36);
            this.tsb_fullShowMap.Tag = "notChange";
            this.tsb_fullShowMap.Text = "地图全屏";
            this.tsb_fullShowMap.Click += new System.EventHandler(this.tsb_fullShowMap_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsb_reset
            // 
            this.tsb_reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_reset.Image = ((System.Drawing.Image)(resources.GetObject("tsb_reset.Image")));
            this.tsb_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_reset.Name = "tsb_reset";
            this.tsb_reset.Size = new System.Drawing.Size(36, 36);
            this.tsb_reset.Tag = "notChange";
            this.tsb_reset.Text = "重置";
            this.tsb_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_systemManage,
            this.tsmi_infoManage,
            this.tsmi_tools});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmi_systemManage
            // 
            this.tsmi_systemManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_openGST,
            this.tsmi_saveCurrent,
            this.tsmi_default,
            this.tsmi_logOut});
            this.tsmi_systemManage.Name = "tsmi_systemManage";
            this.tsmi_systemManage.Size = new System.Drawing.Size(68, 21);
            this.tsmi_systemManage.Text = "系统管理";
            // 
            // tsmi_openGST
            // 
            this.tsmi_openGST.Name = "tsmi_openGST";
            this.tsmi_openGST.Size = new System.Drawing.Size(148, 22);
            this.tsmi_openGST.Text = "打开地图";
            this.tsmi_openGST.Click += new System.EventHandler(this.tsmi_openGST_Click);
            // 
            // tsmi_saveCurrent
            // 
            this.tsmi_saveCurrent.Name = "tsmi_saveCurrent";
            this.tsmi_saveCurrent.Size = new System.Drawing.Size(148, 22);
            this.tsmi_saveCurrent.Text = "保存默认位置";
            this.tsmi_saveCurrent.Click += new System.EventHandler(this.tsmi_saveCurrent_Click);
            // 
            // tsmi_default
            // 
            this.tsmi_default.Name = "tsmi_default";
            this.tsmi_default.Size = new System.Drawing.Size(148, 22);
            this.tsmi_default.Text = "还原默认位置";
            this.tsmi_default.Click += new System.EventHandler(this.tsmi_default_Click);
            // 
            // tsmi_logOut
            // 
            this.tsmi_logOut.Name = "tsmi_logOut";
            this.tsmi_logOut.Size = new System.Drawing.Size(148, 22);
            this.tsmi_logOut.Text = "退出";
            this.tsmi_logOut.Click += new System.EventHandler(this.tsmi_logOut_Click);
            // 
            // tsmi_infoManage
            // 
            this.tsmi_infoManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_organisationList,
            this.tsmi_areas,
            this.tsmi_stationList});
            this.tsmi_infoManage.Name = "tsmi_infoManage";
            this.tsmi_infoManage.Size = new System.Drawing.Size(92, 21);
            this.tsmi_infoManage.Text = "基础信息管理";
            // 
            // tsmi_organisationList
            // 
            this.tsmi_organisationList.Name = "tsmi_organisationList";
            this.tsmi_organisationList.Size = new System.Drawing.Size(124, 22);
            this.tsmi_organisationList.Text = "机构管理";
            this.tsmi_organisationList.Click += new System.EventHandler(this.tsmi_organisationList_Click);
            // 
            // tsmi_areas
            // 
            this.tsmi_areas.Name = "tsmi_areas";
            this.tsmi_areas.Size = new System.Drawing.Size(124, 22);
            this.tsmi_areas.Text = "区域管理";
            this.tsmi_areas.Click += new System.EventHandler(this.tsmi_areas_Click);
            // 
            // tsmi_stationList
            // 
            this.tsmi_stationList.Name = "tsmi_stationList";
            this.tsmi_stationList.Size = new System.Drawing.Size(124, 22);
            this.tsmi_stationList.Text = "网点管理";
            this.tsmi_stationList.Click += new System.EventHandler(this.tsmi_stationList_Click);
            // 
            // tsmi_tools
            // 
            this.tsmi_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_skin});
            this.tsmi_tools.Name = "tsmi_tools";
            this.tsmi_tools.Size = new System.Drawing.Size(44, 21);
            this.tsmi_tools.Text = "工具";
            // 
            // tsmi_skin
            // 
            this.tsmi_skin.Name = "tsmi_skin";
            this.tsmi_skin.Size = new System.Drawing.Size(124, 22);
            this.tsmi_skin.Text = "外观设置";
            this.tsmi_skin.Click += new System.EventHandler(this.tsmi_skin_Click);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(1141, 605);
            // 
            // eP_siteList
            // 
            this.eP_siteList.BackColor = System.Drawing.Color.Transparent;
            this.eP_siteList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.eP_siteList.CaptionFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.eP_siteList.CaptionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eP_siteList.CloseIconForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eP_siteList.CollapsedCaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.eP_siteList.ColorCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.eP_siteList.ColorCaptionGradientEnd = System.Drawing.SystemColors.ButtonShadow;
            this.eP_siteList.ColorCaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.eP_siteList.ColorContentPanelGradientBegin = System.Drawing.Color.Empty;
            this.eP_siteList.ColorContentPanelGradientEnd = System.Drawing.Color.Empty;
            this.eP_siteList.ColorScheme = BSE.Windows.Forms.ColorScheme.Custom;
            this.eP_siteList.Controls.Add(this.sc_main);
            this.eP_siteList.Dock = System.Windows.Forms.DockStyle.Right;
            this.eP_siteList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eP_siteList.Image = null;
            this.eP_siteList.InnerBorderColor = System.Drawing.Color.White;
            this.eP_siteList.Location = new System.Drawing.Point(804, 0);
            this.eP_siteList.Name = "eP_siteList";
            this.eP_siteList.ShowExpandIcon = true;
            this.eP_siteList.Size = new System.Drawing.Size(337, 619);
            this.eP_siteList.TabIndex = 4;
            this.eP_siteList.Text = "网点列表";
            // 
            // sc_main
            // 
            this.sc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main.Location = new System.Drawing.Point(1, 26);
            this.sc_main.Name = "sc_main";
            this.sc_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc_main.Panel1
            // 
            this.sc_main.Panel1.AutoScroll = true;
            this.sc_main.Panel1.Controls.Add(this.bt_serch);
            this.sc_main.Panel1.Controls.Add(this.tb_searchText);
            this.sc_main.Panel1.Controls.Add(this.label1);
            // 
            // sc_main.Panel2
            // 
            this.sc_main.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.sc_main.Size = new System.Drawing.Size(335, 592);
            this.sc_main.SplitterDistance = 31;
            this.sc_main.SplitterWidth = 1;
            this.sc_main.TabIndex = 2;
            // 
            // bt_serch
            // 
            this.bt_serch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_serch.Location = new System.Drawing.Point(253, 3);
            this.bt_serch.Name = "bt_serch";
            this.bt_serch.Size = new System.Drawing.Size(75, 23);
            this.bt_serch.TabIndex = 3;
            this.bt_serch.Text = "快速查询";
            this.bt_serch.UseVisualStyleBackColor = true;
            this.bt_serch.Click += new System.EventHandler(this.bt_serch_Click);
            // 
            // tb_searchText
            // 
            this.tb_searchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_searchText.Location = new System.Drawing.Point(68, 3);
            this.tb_searchText.Name = "tb_searchText";
            this.tb_searchText.Size = new System.Drawing.Size(179, 21);
            this.tb_searchText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询内容:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tv_main, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_pageInfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 560);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tv_main
            // 
            this.tv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_main.Location = new System.Drawing.Point(3, 3);
            this.tv_main.Name = "tv_main";
            this.tv_main.Size = new System.Drawing.Size(329, 512);
            this.tv_main.TabIndex = 3;
            // 
            // lb_pageInfo
            // 
            this.lb_pageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_pageInfo.Location = new System.Drawing.Point(3, 518);
            this.lb_pageInfo.Name = "lb_pageInfo";
            this.lb_pageInfo.Size = new System.Drawing.Size(329, 19);
            this.lb_pageInfo.TabIndex = 1;
            this.lb_pageInfo.Text = "每页{0}项目，共{1}页，第{2}页";
            this.lb_pageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.llb_last);
            this.panel1.Controls.Add(this.llb_first);
            this.panel1.Controls.Add(this.llb_down);
            this.panel1.Controls.Add(this.llb_up);
            this.panel1.Location = new System.Drawing.Point(52, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 17);
            this.panel1.TabIndex = 2;
            // 
            // llb_last
            // 
            this.llb_last.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_last.AutoSize = true;
            this.llb_last.Location = new System.Drawing.Point(184, 3);
            this.llb_last.Name = "llb_last";
            this.llb_last.Size = new System.Drawing.Size(29, 12);
            this.llb_last.TabIndex = 3;
            this.llb_last.TabStop = true;
            this.llb_last.Text = "末页";
            this.llb_last.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_last_LinkClicked);
            // 
            // llb_first
            // 
            this.llb_first.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_first.AutoSize = true;
            this.llb_first.Location = new System.Drawing.Point(13, 3);
            this.llb_first.Name = "llb_first";
            this.llb_first.Size = new System.Drawing.Size(29, 12);
            this.llb_first.TabIndex = 2;
            this.llb_first.TabStop = true;
            this.llb_first.Text = "首页";
            this.llb_first.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_first_LinkClicked);
            // 
            // llb_down
            // 
            this.llb_down.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_down.AutoSize = true;
            this.llb_down.Location = new System.Drawing.Point(123, 4);
            this.llb_down.Name = "llb_down";
            this.llb_down.Size = new System.Drawing.Size(41, 12);
            this.llb_down.TabIndex = 1;
            this.llb_down.TabStop = true;
            this.llb_down.Text = "下一页";
            this.llb_down.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_down_LinkClicked);
            // 
            // llb_up
            // 
            this.llb_up.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_up.AutoSize = true;
            this.llb_up.Location = new System.Drawing.Point(62, 4);
            this.llb_up.Name = "llb_up";
            this.llb_up.Size = new System.Drawing.Size(41, 12);
            this.llb_up.TabIndex = 0;
            this.llb_up.TabStop = true;
            this.llb_up.Text = "上一页";
            this.llb_up.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_up_LinkClicked);
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tp_map);
            this.tc_main.Controls.Add(this.tp_report);
            this.tc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_main.Location = new System.Drawing.Point(0, 39);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(804, 580);
            this.tc_main.TabIndex = 5;
            this.tc_main.SelectedIndexChanged += new System.EventHandler(this.tc_main_SelectedIndexChanged);
            // 
            // tp_map
            // 
            this.tp_map.Controls.Add(this.axMap1);
            this.tp_map.Location = new System.Drawing.Point(4, 22);
            this.tp_map.Name = "tp_map";
            this.tp_map.Padding = new System.Windows.Forms.Padding(3);
            this.tp_map.Size = new System.Drawing.Size(796, 554);
            this.tp_map.TabIndex = 0;
            this.tp_map.Text = "地图";
            this.tp_map.UseVisualStyleBackColor = true;
            // 
            // axMap1
            // 
            this.axMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(3, 3);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(790, 548);
            this.axMap1.TabIndex = 0;
            this.axMap1.DblClick += new System.EventHandler(this.axMap1_DblClick);
            this.axMap1.MouseMoveEvent += new AxMapXLib.CMapXEvents_MouseMoveEventHandler(this.axMap1_MouseMoveEvent);
            this.axMap1.MapViewChanged += new System.EventHandler(this.axMap1_MapViewChanged);
            // 
            // tp_report
            // 
            this.tp_report.Controls.Add(this.rv_main);
            this.tp_report.Location = new System.Drawing.Point(4, 22);
            this.tp_report.Name = "tp_report";
            this.tp_report.Padding = new System.Windows.Forms.Padding(3);
            this.tp_report.Size = new System.Drawing.Size(796, 554);
            this.tp_report.TabIndex = 1;
            this.tp_report.Text = "报表";
            this.tp_report.UseVisualStyleBackColor = true;
            // 
            // rv_main
            // 
            this.rv_main.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.VW_StatuionBindingSource;
            this.rv_main.LocalReport.DataSources.Add(reportDataSource7);
            this.rv_main.LocalReport.ReportEmbeddedResource = "Eulei.Map.Report2.rdlc";
            this.rv_main.Location = new System.Drawing.Point(3, 3);
            this.rv_main.Name = "rv_main";
            this.rv_main.Size = new System.Drawing.Size(790, 548);
            this.rv_main.TabIndex = 0;
            // 
            // tsc_main
            // 
            this.tsc_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsc_main.BottomToolStripPanelVisible = false;
            // 
            // tsc_main.ContentPanel
            // 
            this.tsc_main.ContentPanel.AutoScroll = true;
            this.tsc_main.ContentPanel.Controls.Add(this.tc_main);
            this.tsc_main.ContentPanel.Controls.Add(this.MainToolStrip);
            this.tsc_main.ContentPanel.Controls.Add(this.eP_siteList);
            this.tsc_main.ContentPanel.Size = new System.Drawing.Size(1141, 619);
            this.tsc_main.LeftToolStripPanelVisible = false;
            this.tsc_main.Location = new System.Drawing.Point(0, 0);
            this.tsc_main.Name = "tsc_main";
            this.tsc_main.RightToolStripPanelVisible = false;
            this.tsc_main.Size = new System.Drawing.Size(1141, 644);
            this.tsc_main.TabIndex = 5;
            this.tsc_main.Text = "toolStripContainer1";
            // 
            // tsc_main.TopToolStripPanel
            // 
            this.tsc_main.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 647);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1141, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // cms_organisation
            // 
            this.cms_organisation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_organisation});
            this.cms_organisation.Name = "cms_organisation";
            this.cms_organisation.Size = new System.Drawing.Size(173, 26);
            // 
            // tsmi_organisation
            // 
            this.tsmi_organisation.Name = "tsmi_organisation";
            this.tsmi_organisation.Size = new System.Drawing.Size(172, 22);
            this.tsmi_organisation.Text = "筛选当前法人企业";
            this.tsmi_organisation.Click += new System.EventHandler(this.tsmi_organisation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 669);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsc_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "泉州市邮政管理局快递企业分布电子地图";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VW_StatuionBindingSource)).EndInit();
            this.cms_listView.ResumeLayout(false);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.eP_siteList.ResumeLayout(false);
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel1.PerformLayout();
            this.sc_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).EndInit();
            this.sc_main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tc_main.ResumeLayout(false);
            this.tp_map.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.tp_report.ResumeLayout(false);
            this.tsc_main.ContentPanel.ResumeLayout(false);
            this.tsc_main.ContentPanel.PerformLayout();
            this.tsc_main.TopToolStripPanel.ResumeLayout(false);
            this.tsc_main.TopToolStripPanel.PerformLayout();
            this.tsc_main.ResumeLayout(false);
            this.tsc_main.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cms_organisation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ContextMenuStrip cms_listView;
        private System.Windows.Forms.ToolStripMenuItem tsmi_showSatationForListView;
        private System.Windows.Forms.BindingSource VW_StatuionBindingSource;
        private System.Windows.Forms.StatusStrip miniToolStrip;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton tsb_NoSelected;
        private System.Windows.Forms.ToolStripButton tsb_zoomIn;
        private System.Windows.Forms.ToolStripButton tsb_zoomOut;
        private System.Windows.Forms.ToolStripButton tsb_Pan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_fullShowMap;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_systemManage;
        private System.Windows.Forms.ToolStripMenuItem tsmi_openGST;
        private System.Windows.Forms.ToolStripMenuItem tsmi_saveCurrent;
        private System.Windows.Forms.ToolStripMenuItem tsmi_default;
        private System.Windows.Forms.ToolStripMenuItem tsmi_logOut;
        private System.Windows.Forms.ToolStripMenuItem tsmi_infoManage;
        private System.Windows.Forms.ToolStripMenuItem tsmi_organisationList;
        private System.Windows.Forms.ToolStripMenuItem tsmi_areas;
        private System.Windows.Forms.ToolStripMenuItem tsmi_stationList;
        private System.Windows.Forms.ToolStripMenuItem tsmi_tools;
        private System.Windows.Forms.ToolStripMenuItem tsmi_skin;
        private BSE.Windows.Forms.Panel eP_siteList;
        private System.Windows.Forms.SplitContainer sc_main;
        private System.Windows.Forms.Button bt_serch;
        private System.Windows.Forms.TextBox tb_searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_pageInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llb_last;
        private System.Windows.Forms.LinkLabel llb_first;
        private System.Windows.Forms.LinkLabel llb_down;
        private System.Windows.Forms.LinkLabel llb_up;
        private System.Windows.Forms.TabControl tc_main;
        private System.Windows.Forms.TabPage tp_map;
        private AxMapXLib.AxMap axMap1;
        private System.Windows.Forms.TabPage tp_report;
        private Microsoft.Reporting.WinForms.ReportViewer rv_main;
        private System.Windows.Forms.ToolStripContainer tsc_main;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_reset;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TreeView tv_main;
        private System.Windows.Forms.ContextMenuStrip cms_organisation;
        private System.Windows.Forms.ToolStripMenuItem tsmi_organisation;





    }
}

