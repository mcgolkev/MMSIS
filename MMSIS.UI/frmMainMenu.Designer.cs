namespace MMSIS.UI
{
    partial class frmMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuClient = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuClientAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vesselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerboatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sailboatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuClient,
            this.vesselToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MnuClient
            // 
            this.MnuClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuClientAdd,
            this.findToolStripMenuItem});
            this.MnuClient.Name = "MnuClient";
            this.MnuClient.Size = new System.Drawing.Size(72, 29);
            this.MnuClient.Text = "Client";
            // 
            // MnuClientAdd
            // 
            this.MnuClientAdd.Name = "MnuClientAdd";
            this.MnuClientAdd.Size = new System.Drawing.Size(148, 34);
            this.MnuClientAdd.Text = "Add";
            this.MnuClientAdd.Click += new System.EventHandler(this.MnuClientAdd_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(148, 34);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // vesselToolStripMenuItem
            // 
            this.vesselToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem1,
            this.addToolStripMenuItem});
            this.vesselToolStripMenuItem.Name = "vesselToolStripMenuItem";
            this.vesselToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.vesselToolStripMenuItem.Text = "Vessel";
            // 
            // findToolStripMenuItem1
            // 
            this.findToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.powerboatToolStripMenuItem,
            this.sailboatToolStripMenuItem});
            this.findToolStripMenuItem1.Name = "findToolStripMenuItem1";
            this.findToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.findToolStripMenuItem1.Text = "Add";
            this.findToolStripMenuItem1.Click += new System.EventHandler(this.findToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addToolStripMenuItem.Text = "Find";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // powerboatToolStripMenuItem
            // 
            this.powerboatToolStripMenuItem.Name = "powerboatToolStripMenuItem";
            this.powerboatToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.powerboatToolStripMenuItem.Text = "Powerboat";
            this.powerboatToolStripMenuItem.Click += new System.EventHandler(this.powerboatToolStripMenuItem_Click);
            // 
            // sailboatToolStripMenuItem
            // 
            this.sailboatToolStripMenuItem.Name = "sailboatToolStripMenuItem";
            this.sailboatToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sailboatToolStripMenuItem.Text = "Sailboat";
            this.sailboatToolStripMenuItem.Click += new System.EventHandler(this.sailboatToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 800);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmMainMenu";
            this.Text = "MMSIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mnuAddClient_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuClient;
        private System.Windows.Forms.ToolStripMenuItem MnuClientAdd;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vesselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerboatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sailboatToolStripMenuItem;
    }
}