namespace Eulei.Map
{
    partial class StationInfoManage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_principal = new System.Windows.Forms.TextBox();
            this.bs_main = new System.Windows.Forms.BindingSource(this.components);
            this.tb_principalTEL = new System.Windows.Forms.TextBox();
            this.tb_setLevel = new System.Windows.Forms.TextBox();
            this.tb_businessModel = new System.Windows.Forms.TextBox();
            this.bs_postalCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_OpeningHoursEnd = new System.Windows.Forms.TextBox();
            this.tb_OpeningHoursBegin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_businessScope = new System.Windows.Forms.TextBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_ImageInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_man = new System.Windows.Forms.ListView();
            this.il_main = new System.Windows.Forms.ImageList(this.components);
            this.bt_editImageInfo = new System.Windows.Forms.Button();
            this.tb_del = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_main)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_principal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_principalTEL, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_setLevel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_businessModel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.bs_postalCode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_businessScope, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 199);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "负 责 人：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "负责人电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "市县名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "经营模式:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "邮政编码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "营业时间：";
            // 
            // tb_principal
            // 
            this.tb_principal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_main, "Principal", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_principal.Location = new System.Drawing.Point(74, 3);
            this.tb_principal.Name = "tb_principal";
            this.tb_principal.Size = new System.Drawing.Size(324, 21);
            this.tb_principal.TabIndex = 8;
            // 
            // bs_main
            // 
            this.bs_main.DataSource = typeof(TaskInterface.StationInfo);
            // 
            // tb_principalTEL
            // 
            this.tb_principalTEL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_main, "PrincipalTEL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_principalTEL.Location = new System.Drawing.Point(487, 3);
            this.tb_principalTEL.Name = "tb_principalTEL";
            this.tb_principalTEL.Size = new System.Drawing.Size(324, 21);
            this.tb_principalTEL.TabIndex = 9;
            // 
            // tb_setLevel
            // 
            this.tb_setLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_main, "SetLevel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_setLevel.Location = new System.Drawing.Point(74, 41);
            this.tb_setLevel.Name = "tb_setLevel";
            this.tb_setLevel.Size = new System.Drawing.Size(324, 21);
            this.tb_setLevel.TabIndex = 10;
            // 
            // tb_businessModel
            // 
            this.tb_businessModel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_main, "BusinessModel", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_businessModel.Location = new System.Drawing.Point(487, 41);
            this.tb_businessModel.Name = "tb_businessModel";
            this.tb_businessModel.Size = new System.Drawing.Size(324, 21);
            this.tb_businessModel.TabIndex = 11;
            // 
            // bs_postalCode
            // 
            this.bs_postalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_main, "PostalCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.bs_postalCode.Location = new System.Drawing.Point(74, 79);
            this.bs_postalCode.Name = "bs_postalCode";
            this.bs_postalCode.Size = new System.Drawing.Size(324, 21);
            this.bs_postalCode.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_OpeningHoursEnd);
            this.panel1.Controls.Add(this.tb_OpeningHoursBegin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(487, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 32);
            this.panel1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "<-->";
            // 
            // tb_OpeningHoursEnd
            // 
            this.tb_OpeningHoursEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_main, "OpeningHoursEnd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_OpeningHoursEnd.Location = new System.Drawing.Point(179, 3);
            this.tb_OpeningHoursEnd.Name = "tb_OpeningHoursEnd";
            this.tb_OpeningHoursEnd.Size = new System.Drawing.Size(143, 21);
            this.tb_OpeningHoursEnd.TabIndex = 16;
            // 
            // tb_OpeningHoursBegin
            // 
            this.tb_OpeningHoursBegin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_main, "OpeningHoursBegin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_OpeningHoursBegin.Location = new System.Drawing.Point(5, 2);
            this.tb_OpeningHoursBegin.Name = "tb_OpeningHoursBegin";
            this.tb_OpeningHoursBegin.Size = new System.Drawing.Size(130, 21);
            this.tb_OpeningHoursBegin.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "业务范围：";
            // 
            // tb_businessScope
            // 
            this.tb_businessScope.AcceptsReturn = true;
            this.tableLayoutPanel1.SetColumnSpan(this.tb_businessScope, 3);
            this.tb_businessScope.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_main, "BusinessScope", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_businessScope.Location = new System.Drawing.Point(74, 117);
            this.tb_businessScope.Multiline = true;
            this.tb_businessScope.Name = "tb_businessScope";
            this.tb_businessScope.Size = new System.Drawing.Size(747, 72);
            this.tb_businessScope.TabIndex = 14;
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(657, 233);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(75, 23);
            this.bt_OK.TabIndex = 1;
            this.bt_OK.Text = "确定";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(748, 233);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 2;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_ImageInfo
            // 
            this.bt_ImageInfo.Location = new System.Drawing.Point(17, 233);
            this.bt_ImageInfo.Name = "bt_ImageInfo";
            this.bt_ImageInfo.Size = new System.Drawing.Size(97, 23);
            this.bt_ImageInfo.TabIndex = 3;
            this.bt_ImageInfo.Text = "添加图片信息";
            this.bt_ImageInfo.UseVisualStyleBackColor = true;
            this.bt_ImageInfo.Click += new System.EventHandler(this.bt_ImageInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_man);
            this.groupBox1.Location = new System.Drawing.Point(17, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 600);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图片信息";
            // 
            // lv_man
            // 
            this.lv_man.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_man.Location = new System.Drawing.Point(3, 17);
            this.lv_man.MultiSelect = false;
            this.lv_man.Name = "lv_man";
            this.lv_man.Size = new System.Drawing.Size(794, 580);
            this.lv_man.TabIndex = 0;
            this.lv_man.UseCompatibleStateImageBehavior = false;
            // 
            // il_main
            // 
            this.il_main.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.il_main.ImageSize = new System.Drawing.Size(250, 150);
            this.il_main.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bt_editImageInfo
            // 
            this.bt_editImageInfo.Location = new System.Drawing.Point(136, 233);
            this.bt_editImageInfo.Name = "bt_editImageInfo";
            this.bt_editImageInfo.Size = new System.Drawing.Size(96, 23);
            this.bt_editImageInfo.TabIndex = 5;
            this.bt_editImageInfo.Text = "编辑图片信息";
            this.bt_editImageInfo.UseVisualStyleBackColor = true;
            this.bt_editImageInfo.Click += new System.EventHandler(this.bt_editImageInfo_Click);
            // 
            // tb_del
            // 
            this.tb_del.Location = new System.Drawing.Point(251, 233);
            this.tb_del.Name = "tb_del";
            this.tb_del.Size = new System.Drawing.Size(107, 23);
            this.tb_del.TabIndex = 6;
            this.tb_del.Text = "删除图片信息";
            this.tb_del.UseVisualStyleBackColor = true;
            this.tb_del.Click += new System.EventHandler(this.tb_del_Click);
            // 
            // StationInfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 900);
            this.Controls.Add(this.tb_del);
            this.Controls.Add(this.bt_editImageInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_ImageInfo);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StationInfoManage";
            this.Text = "网点详细信息";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_main)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_principal;
        private System.Windows.Forms.TextBox tb_principalTEL;
        private System.Windows.Forms.TextBox tb_setLevel;
        private System.Windows.Forms.TextBox tb_businessModel;
        private System.Windows.Forms.TextBox bs_postalCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_businessScope;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_OpeningHoursEnd;
        private System.Windows.Forms.TextBox tb_OpeningHoursBegin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_ImageInfo;
        private System.Windows.Forms.BindingSource bs_main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_man;
        private System.Windows.Forms.ImageList il_main;
        private System.Windows.Forms.Button bt_editImageInfo;
        private System.Windows.Forms.Button tb_del;
    }
}