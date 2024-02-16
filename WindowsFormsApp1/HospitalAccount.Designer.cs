namespace WindowsFormsApp1
{
    partial class HospitalAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalAccount));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.缴费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的账单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的诊断表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的医嘱单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系工作人员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.缴费ToolStripMenuItem,
            this.我的账单ToolStripMenuItem,
            this.我的诊断表ToolStripMenuItem,
            this.我的医嘱单ToolStripMenuItem,
            this.联系工作人员ToolStripMenuItem,
            this.个人信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(13, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 缴费ToolStripMenuItem
            // 
            this.缴费ToolStripMenuItem.Name = "缴费ToolStripMenuItem";
            this.缴费ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.缴费ToolStripMenuItem.Text = "去缴费";
            // 
            // 我的账单ToolStripMenuItem
            // 
            this.我的账单ToolStripMenuItem.Name = "我的账单ToolStripMenuItem";
            this.我的账单ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.我的账单ToolStripMenuItem.Text = "我的账单";
            // 
            // 我的诊断表ToolStripMenuItem
            // 
            this.我的诊断表ToolStripMenuItem.Name = "我的诊断表ToolStripMenuItem";
            this.我的诊断表ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.我的诊断表ToolStripMenuItem.Text = "我的诊断单";
            this.我的诊断表ToolStripMenuItem.Click += new System.EventHandler(this.我的诊断表ToolStripMenuItem_Click);
            // 
            // 我的医嘱单ToolStripMenuItem
            // 
            this.我的医嘱单ToolStripMenuItem.Name = "我的医嘱单ToolStripMenuItem";
            this.我的医嘱单ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.我的医嘱单ToolStripMenuItem.Text = "我的医嘱单";
            // 
            // 联系工作人员ToolStripMenuItem
            // 
            this.联系工作人员ToolStripMenuItem.Name = "联系工作人员ToolStripMenuItem";
            this.联系工作人员ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.联系工作人员ToolStripMenuItem.Text = "联系工作人员";
            this.联系工作人员ToolStripMenuItem.Click += new System.EventHandler(this.联系工作人员ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文仿宋", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(171, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "尚未设计此功能";
            // 
            // HospitalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HospitalAccount";
            this.Text = "住院账户";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 缴费ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的账单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的诊断表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的医嘱单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系工作人员ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}