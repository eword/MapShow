namespace Eulei.Map
{
    partial class OrganisationManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganisationManage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.bs_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_centerName = new System.Windows.Forms.TextBox();
            this.lb_lon = new System.Windows.Forms.Label();
            this.lb_lat = new System.Windows.Forms.Label();
            this.bt_getPoint = new System.Windows.Forms.Button();
            this.bt_Ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_bindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.tb_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_centerName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_lon, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_lat, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "机  构  名  称：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "主要办公点名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "主要办公点经度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "主要办公点纬度：";
            // 
            // tb_name
            // 
            this.tb_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_name.Location = new System.Drawing.Point(110, 3);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(244, 21);
            this.tb_name.TabIndex = 4;
            // 
            // bs_bindingSource
            // 
            this.bs_bindingSource.DataSource = typeof(TaskInterface.Organisation);
            // 
            // tb_centerName
            // 
            this.tb_centerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "CenterName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_centerName.Location = new System.Drawing.Point(467, 3);
            this.tb_centerName.Name = "tb_centerName";
            this.tb_centerName.Size = new System.Drawing.Size(244, 21);
            this.tb_centerName.TabIndex = 5;
            // 
            // lb_lon
            // 
            this.lb_lon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "lon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_lon.Location = new System.Drawing.Point(110, 50);
            this.lb_lon.Name = "lb_lon";
            this.lb_lon.Size = new System.Drawing.Size(244, 23);
            this.lb_lon.TabIndex = 6;
            this.lb_lon.Text = "0.0";
            // 
            // lb_lat
            // 
            this.lb_lat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "lat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_lat.Location = new System.Drawing.Point(467, 50);
            this.lb_lat.Name = "lb_lat";
            this.lb_lat.Size = new System.Drawing.Size(244, 23);
            this.lb_lat.TabIndex = 7;
            this.lb_lat.Text = "0,0";
            // 
            // bt_getPoint
            // 
            this.bt_getPoint.Location = new System.Drawing.Point(13, 134);
            this.bt_getPoint.Name = "bt_getPoint";
            this.bt_getPoint.Size = new System.Drawing.Size(75, 23);
            this.bt_getPoint.TabIndex = 1;
            this.bt_getPoint.Text = "获取坐标";
            this.bt_getPoint.UseVisualStyleBackColor = true;
            this.bt_getPoint.Click += new System.EventHandler(this.bt_getPoint_Click);
            // 
            // bt_Ok
            // 
            this.bt_Ok.Location = new System.Drawing.Point(541, 133);
            this.bt_Ok.Name = "bt_Ok";
            this.bt_Ok.Size = new System.Drawing.Size(75, 23);
            this.bt_Ok.TabIndex = 2;
            this.bt_Ok.Text = "确定";
            this.bt_Ok.UseVisualStyleBackColor = true;
            this.bt_Ok.Click += new System.EventHandler(this.bt_Ok_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(633, 134);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // OrganisationManage
            // 
            this.AcceptButton = this.bt_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancel;
            this.ClientSize = new System.Drawing.Size(738, 163);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_Ok);
            this.Controls.Add(this.bt_getPoint);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganisationManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "机构管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_centerName;
        private System.Windows.Forms.Label lb_lon;
        private System.Windows.Forms.Label lb_lat;
        private System.Windows.Forms.Button bt_getPoint;
        private System.Windows.Forms.Button bt_Ok;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.BindingSource bs_bindingSource;
    }
}