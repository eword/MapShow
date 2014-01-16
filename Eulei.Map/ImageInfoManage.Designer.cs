namespace Eulei.Map
{
    partial class ImageInfoManage
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_title = new System.Windows.Forms.TextBox();
            this.bs_main = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.bt_uploadOrSelect = new System.Windows.Forms.Button();
            this.tb_OK = new System.Windows.Forms.Button();
            this.tb_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "标题：";
            // 
            // tb_title
            // 
            this.tb_title.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_main, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_title.Location = new System.Drawing.Point(61, 13);
            this.tb_title.Name = "tb_title";
            this.tb_title.Size = new System.Drawing.Size(541, 21);
            this.tb_title.TabIndex = 1;
            // 
            // bs_main
            // 
            this.bs_main.DataSource = typeof(TaskInterface.StationImageInfo);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "图片：";
            // 
            // tb_path
            // 
            this.tb_path.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_main, "ImagePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_path.Location = new System.Drawing.Point(63, 54);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(452, 21);
            this.tb_path.TabIndex = 3;
            // 
            // bt_uploadOrSelect
            // 
            this.bt_uploadOrSelect.Location = new System.Drawing.Point(519, 53);
            this.bt_uploadOrSelect.Name = "bt_uploadOrSelect";
            this.bt_uploadOrSelect.Size = new System.Drawing.Size(75, 23);
            this.bt_uploadOrSelect.TabIndex = 4;
            this.bt_uploadOrSelect.Text = "上传/选择";
            this.bt_uploadOrSelect.UseVisualStyleBackColor = true;
            this.bt_uploadOrSelect.Click += new System.EventHandler(this.bt_uploadOrSelect_Click);
            // 
            // tb_OK
            // 
            this.tb_OK.Location = new System.Drawing.Point(425, 432);
            this.tb_OK.Name = "tb_OK";
            this.tb_OK.Size = new System.Drawing.Size(75, 23);
            this.tb_OK.TabIndex = 6;
            this.tb_OK.Text = "确定";
            this.tb_OK.UseVisualStyleBackColor = true;
            this.tb_OK.Click += new System.EventHandler(this.tb_OK_Click);
            // 
            // tb_cancel
            // 
            this.tb_cancel.Location = new System.Drawing.Point(507, 432);
            this.tb_cancel.Name = "tb_cancel";
            this.tb_cancel.Size = new System.Drawing.Size(75, 23);
            this.tb_cancel.TabIndex = 7;
            this.tb_cancel.Text = "取消";
            this.tb_cancel.UseVisualStyleBackColor = true;
            this.tb_cancel.Click += new System.EventHandler(this.tb_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ImageInfoManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 476);
            this.Controls.Add(this.tb_cancel);
            this.Controls.Add(this.tb_OK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_uploadOrSelect);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_title);
            this.Controls.Add(this.label1);
            this.Name = "ImageInfoManage";
            this.Text = "图片信息";
            ((System.ComponentModel.ISupportInitialize)(this.bs_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Button bt_uploadOrSelect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tb_OK;
        private System.Windows.Forms.Button tb_cancel;
        private System.Windows.Forms.BindingSource bs_main;
    }
}