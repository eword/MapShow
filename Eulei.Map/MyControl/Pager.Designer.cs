namespace Eulei.Map.MyControl
{
    partial class Pager
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.llb_last = new System.Windows.Forms.LinkLabel();
            this.llb_first = new System.Windows.Forms.LinkLabel();
            this.llb_down = new System.Windows.Forms.LinkLabel();
            this.llb_up = new System.Windows.Forms.LinkLabel();
            this.lb_pageInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.llb_last);
            this.panel1.Controls.Add(this.llb_first);
            this.panel1.Controls.Add(this.llb_down);
            this.panel1.Controls.Add(this.llb_up);
            this.panel1.Location = new System.Drawing.Point(349, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 18);
            this.panel1.TabIndex = 3;
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
            // lb_pageInfo
            // 
            this.lb_pageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_pageInfo.Location = new System.Drawing.Point(3, 3);
            this.lb_pageInfo.Name = "lb_pageInfo";
            this.lb_pageInfo.Size = new System.Drawing.Size(288, 18);
            this.lb_pageInfo.TabIndex = 4;
            this.lb_pageInfo.Text = "共{0}项，每页{1}项，共{2}页，当前第{3}页";
            this.lb_pageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_pageInfo);
            this.Controls.Add(this.panel1);
            this.Name = "Pager";
            this.Size = new System.Drawing.Size(582, 25);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llb_last;
        private System.Windows.Forms.LinkLabel llb_first;
        private System.Windows.Forms.LinkLabel llb_down;
        private System.Windows.Forms.LinkLabel llb_up;
        private System.Windows.Forms.Label lb_pageInfo;
    }
}
