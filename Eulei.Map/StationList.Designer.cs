namespace Eulei.Map
{
    partial class StationList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationList));
            Eulei.Map.MyControl.CurrentPageIndexChangedEventArgs currentPageIndexChangedEventArgs1 = new Eulei.Map.MyControl.CurrentPageIndexChangedEventArgs();
            Eulei.Map.Code.PageInfo pageInfo1 = new Eulei.Map.Code.PageInfo();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.cb_organisation = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_add = new System.Windows.Forms.ToolStripButton();
            this.tsb_edit = new System.Windows.Forms.ToolStripButton();
            this.tsb_del = new System.Windows.Forms.ToolStripButton();
            this.tsb_refresh = new System.Windows.Forms.ToolStripButton();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaInfoNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organisationNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationInfoPrincipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationInfoPrincipalTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationInfoSetLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationInfoPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationInfoBusinessModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_main = new System.Windows.Forms.BindingSource(this.components);
            this.pager1 = new Eulei.Map.MyControl.Pager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_main)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pager1);
            this.splitContainer1.Panel2.Controls.Add(this.dgv_main);
            this.splitContainer1.Size = new System.Drawing.Size(755, 608);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息搜索";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_num, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_tel, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_area, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_organisation, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网点名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "电    话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "区    域:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "机    构:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(68, 3);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(174, 21);
            this.tb_Name.TabIndex = 5;
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(313, 3);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(174, 21);
            this.tb_num.TabIndex = 6;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(564, 3);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(174, 21);
            this.tb_tel.TabIndex = 7;
            // 
            // cb_area
            // 
            this.cb_area.DisplayMember = "ID";
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Location = new System.Drawing.Point(68, 53);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(174, 20);
            this.cb_area.TabIndex = 8;
            this.cb_area.ValueMember = "ID";
            // 
            // cb_organisation
            // 
            this.cb_organisation.DisplayMember = "ID";
            this.cb_organisation.FormattingEnabled = true;
            this.cb_organisation.Location = new System.Drawing.Point(313, 53);
            this.cb_organisation.Name = "cb_organisation";
            this.cb_organisation.Size = new System.Drawing.Size(174, 20);
            this.cb_organisation.TabIndex = 9;
            this.cb_organisation.ValueMember = "ID";
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.bt_reset);
            this.panel1.Controls.Add(this.bt_search);
            this.panel1.Location = new System.Drawing.Point(493, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 44);
            this.panel1.TabIndex = 10;
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(113, 3);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_reset.TabIndex = 1;
            this.bt_reset.Text = "重置";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(31, 3);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 23);
            this.bt_search.TabIndex = 0;
            this.bt_search.Text = "查询";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "编    号:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_add,
            this.tsb_edit,
            this.tsb_del,
            this.tsb_refresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(755, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_add
            // 
            this.tsb_add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_add.Image")));
            this.tsb_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_add.Name = "tsb_add";
            this.tsb_add.Size = new System.Drawing.Size(52, 22);
            this.tsb_add.Text = "添加";
            this.tsb_add.Click += new System.EventHandler(this.winGridViewPager1_OnAddNew);
            // 
            // tsb_edit
            // 
            this.tsb_edit.Image = ((System.Drawing.Image)(resources.GetObject("tsb_edit.Image")));
            this.tsb_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_edit.Name = "tsb_edit";
            this.tsb_edit.Size = new System.Drawing.Size(52, 22);
            this.tsb_edit.Text = "编辑";
            this.tsb_edit.Click += new System.EventHandler(this.winGridViewPager1_OnEditSelected);
            // 
            // tsb_del
            // 
            this.tsb_del.Image = ((System.Drawing.Image)(resources.GetObject("tsb_del.Image")));
            this.tsb_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_del.Name = "tsb_del";
            this.tsb_del.Size = new System.Drawing.Size(52, 22);
            this.tsb_del.Text = "删除";
            this.tsb_del.Click += new System.EventHandler(this.winGridViewPager1_OnDeleteSelected);
            // 
            // tsb_refresh
            // 
            this.tsb_refresh.Image = ((System.Drawing.Image)(resources.GetObject("tsb_refresh.Image")));
            this.tsb_refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_refresh.Name = "tsb_refresh";
            this.tsb_refresh.Size = new System.Drawing.Size(52, 22);
            this.tsb_refresh.Text = "刷新";
            this.tsb_refresh.Click += new System.EventHandler(this.winGridViewPager1_OnRefresh);
            // 
            // dgv_main
            // 
            this.dgv_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_main.AutoGenerateColumns = false;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.numDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.areaInfoNameDataGridViewTextBoxColumn,
            this.organisationNameDataGridViewTextBoxColumn,
            this.tELDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.stationInfoPrincipalDataGridViewTextBoxColumn,
            this.stationInfoPrincipalTELDataGridViewTextBoxColumn,
            this.stationInfoSetLevelDataGridViewTextBoxColumn,
            this.stationInfoPostalCodeDataGridViewTextBoxColumn,
            this.stationInfoBusinessModelDataGridViewTextBoxColumn});
            this.dgv_main.DataSource = this.bs_main;
            this.dgv_main.Location = new System.Drawing.Point(3, 3);
            this.dgv_main.MultiSelect = false;
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowTemplate.Height = 23;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(747, 429);
            this.dgv_main.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "网点编号";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "网点名称";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // areaInfoNameDataGridViewTextBoxColumn
            // 
            this.areaInfoNameDataGridViewTextBoxColumn.DataPropertyName = "AreaInfoName";
            this.areaInfoNameDataGridViewTextBoxColumn.HeaderText = "区域";
            this.areaInfoNameDataGridViewTextBoxColumn.Name = "areaInfoNameDataGridViewTextBoxColumn";
            // 
            // organisationNameDataGridViewTextBoxColumn
            // 
            this.organisationNameDataGridViewTextBoxColumn.DataPropertyName = "OrganisationName";
            this.organisationNameDataGridViewTextBoxColumn.HeaderText = "机构";
            this.organisationNameDataGridViewTextBoxColumn.Name = "organisationNameDataGridViewTextBoxColumn";
            // 
            // tELDataGridViewTextBoxColumn
            // 
            this.tELDataGridViewTextBoxColumn.DataPropertyName = "TEL";
            this.tELDataGridViewTextBoxColumn.HeaderText = "电话";
            this.tELDataGridViewTextBoxColumn.Name = "tELDataGridViewTextBoxColumn";
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "传真";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "地址";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // stationInfoPrincipalDataGridViewTextBoxColumn
            // 
            this.stationInfoPrincipalDataGridViewTextBoxColumn.DataPropertyName = "StationInfoPrincipal";
            this.stationInfoPrincipalDataGridViewTextBoxColumn.HeaderText = "负责人";
            this.stationInfoPrincipalDataGridViewTextBoxColumn.Name = "stationInfoPrincipalDataGridViewTextBoxColumn";
            // 
            // stationInfoPrincipalTELDataGridViewTextBoxColumn
            // 
            this.stationInfoPrincipalTELDataGridViewTextBoxColumn.DataPropertyName = "StationInfoPrincipalTEL";
            this.stationInfoPrincipalTELDataGridViewTextBoxColumn.HeaderText = "负责人电话";
            this.stationInfoPrincipalTELDataGridViewTextBoxColumn.Name = "stationInfoPrincipalTELDataGridViewTextBoxColumn";
            // 
            // stationInfoSetLevelDataGridViewTextBoxColumn
            // 
            this.stationInfoSetLevelDataGridViewTextBoxColumn.DataPropertyName = "StationInfoSetLevel";
            this.stationInfoSetLevelDataGridViewTextBoxColumn.HeaderText = "设置等级";
            this.stationInfoSetLevelDataGridViewTextBoxColumn.Name = "stationInfoSetLevelDataGridViewTextBoxColumn";
            // 
            // stationInfoPostalCodeDataGridViewTextBoxColumn
            // 
            this.stationInfoPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "StationInfoPostalCode";
            this.stationInfoPostalCodeDataGridViewTextBoxColumn.HeaderText = "邮政编码";
            this.stationInfoPostalCodeDataGridViewTextBoxColumn.Name = "stationInfoPostalCodeDataGridViewTextBoxColumn";
            // 
            // stationInfoBusinessModelDataGridViewTextBoxColumn
            // 
            this.stationInfoBusinessModelDataGridViewTextBoxColumn.DataPropertyName = "StationInfoBusinessModel";
            this.stationInfoBusinessModelDataGridViewTextBoxColumn.HeaderText = "营业模式";
            this.stationInfoBusinessModelDataGridViewTextBoxColumn.Name = "stationInfoBusinessModelDataGridViewTextBoxColumn";
            // 
            // bs_main
            // 
            this.bs_main.DataSource = typeof(TaskInterface.VW_Statuion);
            // 
            // pager1
            // 
            this.pager1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pager1.Location = new System.Drawing.Point(3, 432);
            this.pager1.Name = "pager1";
            pageInfo1.CurrentPageIndex = 1;
            pageInfo1.PageSize = 0;
            pageInfo1.RecordCount = 0;
            currentPageIndexChangedEventArgs1.PageInfo = pageInfo1;
            this.pager1.PageInfoEventArgs = currentPageIndexChangedEventArgs1;
            this.pager1.Size = new System.Drawing.Size(747, 25);
            this.pager1.TabIndex = 1;
            this.pager1.CurrentPageIndexChanged += new Eulei.Map.MyControl.CurrentPageIndexChangedEventHandler(this.pager1_CurrentPageIndexChanged);
            // 
            // StationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 608);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StationList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "网点列表";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.ComboBox cb_area;
        private System.Windows.Forms.ComboBox cb_organisation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_add;
        private System.Windows.Forms.ToolStripButton tsb_edit;
        private System.Windows.Forms.ToolStripButton tsb_del;
        private System.Windows.Forms.ToolStripButton tsb_refresh;
        private System.Windows.Forms.BindingSource bs_main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.DataGridView dgv_main;
        private MyControl.Pager pager1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaInfoNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organisationNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationInfoPrincipalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationInfoPrincipalTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationInfoSetLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationInfoPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stationInfoBusinessModelDataGridViewTextBoxColumn;


    }
}