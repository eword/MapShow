namespace Eulei.Map
{
    partial class AreaManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaManage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_areaName = new System.Windows.Forms.TextBox();
            this.bs_bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tb_easyCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_lon = new System.Windows.Forms.Label();
            this.lb_lat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_postalCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_zoom = new System.Windows.Forms.Label();
            this.tb_order = new System.Windows.Forms.TextBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_getPoint = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.tb_areaName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_easyCode, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_lon, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_lat, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_postalCode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_zoom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_order, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 143);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "区域名称：";
            // 
            // tb_areaName
            // 
            this.tb_areaName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_areaName.Location = new System.Drawing.Point(74, 3);
            this.tb_areaName.Name = "tb_areaName";
            this.tb_areaName.Size = new System.Drawing.Size(179, 21);
            this.tb_areaName.TabIndex = 1;
            // 
            // bs_bindingSource
            // 
            this.bs_bindingSource.DataSource = typeof(TaskInterface.AreaInfo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "简    码：";
            // 
            // tb_easyCode
            // 
            this.tb_easyCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "EasyCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_easyCode.Location = new System.Drawing.Point(330, 3);
            this.tb_easyCode.Name = "tb_easyCode";
            this.tb_easyCode.Size = new System.Drawing.Size(196, 21);
            this.tb_easyCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "经    度：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "纬    度：";
            // 
            // lb_lon
            // 
            this.lb_lon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "lon", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_lon.Location = new System.Drawing.Point(74, 36);
            this.lb_lon.Name = "lb_lon";
            this.lb_lon.Size = new System.Drawing.Size(179, 23);
            this.lb_lon.TabIndex = 6;
            this.lb_lon.Text = "0.0";
            // 
            // lb_lat
            // 
            this.lb_lat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "lat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_lat.Location = new System.Drawing.Point(330, 36);
            this.lb_lat.Name = "lb_lat";
            this.lb_lat.Size = new System.Drawing.Size(196, 23);
            this.lb_lat.TabIndex = 7;
            this.lb_lat.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "邮    编：";
            // 
            // tb_postalCode
            // 
            this.tb_postalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "PostalCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_postalCode.Location = new System.Drawing.Point(74, 111);
            this.tb_postalCode.Name = "tb_postalCode";
            this.tb_postalCode.Size = new System.Drawing.Size(179, 21);
            this.tb_postalCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "缩 放 率：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "排 序 号：";
            // 
            // lb_zoom
            // 
            this.lb_zoom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "Zoom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lb_zoom.Location = new System.Drawing.Point(74, 72);
            this.lb_zoom.Name = "lb_zoom";
            this.lb_zoom.Size = new System.Drawing.Size(179, 23);
            this.lb_zoom.TabIndex = 12;
            this.lb_zoom.Text = "0";
            // 
            // tb_order
            // 
            this.tb_order.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_bindingSource, "Order", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_order.Location = new System.Drawing.Point(330, 75);
            this.tb_order.Name = "tb_order";
            this.tb_order.Size = new System.Drawing.Size(196, 21);
            this.tb_order.TabIndex = 13;
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(342, 178);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(75, 23);
            this.bt_OK.TabIndex = 1;
            this.bt_OK.Text = "确定";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.Location = new System.Drawing.Point(450, 178);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 2;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_getPoint
            // 
            this.bt_getPoint.Location = new System.Drawing.Point(17, 178);
            this.bt_getPoint.Name = "bt_getPoint";
            this.bt_getPoint.Size = new System.Drawing.Size(75, 23);
            this.bt_getPoint.TabIndex = 3;
            this.bt_getPoint.Text = "选取坐标";
            this.bt_getPoint.UseVisualStyleBackColor = true;
            this.bt_getPoint.Click += new System.EventHandler(this.bt_getPoint_Click);
            // 
            // AreaManage
            // 
            this.AcceptButton = this.bt_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.bt_cancel;
            this.ClientSize = new System.Drawing.Size(551, 318);
            this.Controls.Add(this.bt_getPoint);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AreaManage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "区域管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AreaManage_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_bindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_areaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_easyCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_lon;
        private System.Windows.Forms.Label lb_lat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_postalCode;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_getPoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_zoom;
        private System.Windows.Forms.TextBox tb_order;
    }
}