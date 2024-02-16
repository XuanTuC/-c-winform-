namespace WindowsFormsApp1
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.医护管理工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.住院登记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病床管理工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病床管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.医护管理工具ToolStripMenuItem,
            this.住院登记ToolStripMenuItem,
            this.病床管理工具ToolStripMenuItem,
            this.病床管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(126, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 医护管理工具ToolStripMenuItem
            // 
            this.医护管理工具ToolStripMenuItem.Name = "医护管理工具ToolStripMenuItem";
            this.医护管理工具ToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.医护管理工具ToolStripMenuItem.Text = "医护管理";
            this.医护管理工具ToolStripMenuItem.Click += new System.EventHandler(this.医护管理工具ToolStripMenuItem_Click);
            // 
            // 住院登记ToolStripMenuItem
            // 
            this.住院登记ToolStripMenuItem.Name = "住院登记ToolStripMenuItem";
            this.住院登记ToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.住院登记ToolStripMenuItem.Text = "住院登记";
            this.住院登记ToolStripMenuItem.Click += new System.EventHandler(this.住院登记ToolStripMenuItem_Click);
            // 
            // 病床管理工具ToolStripMenuItem
            // 
            this.病床管理工具ToolStripMenuItem.Name = "病床管理工具ToolStripMenuItem";
            this.病床管理工具ToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.病床管理工具ToolStripMenuItem.Text = "病床管理";
            this.病床管理工具ToolStripMenuItem.Click += new System.EventHandler(this.病床管理工具ToolStripMenuItem_Click);
            // 
            // 病床管理ToolStripMenuItem
            // 
            this.病床管理ToolStripMenuItem.Name = "病床管理ToolStripMenuItem";
            this.病床管理ToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.病床管理ToolStripMenuItem.Text = "病房管理";
            this.病床管理ToolStripMenuItem.Click += new System.EventHandler(this.病床管理ToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "管理员面板";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 医护管理工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 住院登记ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病床管理工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病床管理ToolStripMenuItem;
    }
}