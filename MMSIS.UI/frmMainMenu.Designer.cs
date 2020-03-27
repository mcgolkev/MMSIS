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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAddVessel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAddClient = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearchClients = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearchVessels = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAddVessel,
            this.tsbtnAddClient,
            this.tsbtnSearchClients,
            this.tsbtnSearchVessels});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(25, 640);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAddVessel
            // 
            this.tsbtnAddVessel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddVessel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddVessel.Image")));
            this.tsbtnAddVessel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddVessel.Name = "tsbtnAddVessel";
            this.tsbtnAddVessel.Size = new System.Drawing.Size(24, 24);
            this.tsbtnAddVessel.Text = "Add Vessel";
            this.tsbtnAddVessel.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // tsbtnAddClient
            // 
            this.tsbtnAddClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddClient.Image")));
            this.tsbtnAddClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddClient.Name = "tsbtnAddClient";
            this.tsbtnAddClient.Size = new System.Drawing.Size(24, 24);
            this.tsbtnAddClient.Text = "Add Client";
            this.tsbtnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // tsbtnSearchClients
            // 
            this.tsbtnSearchClients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSearchClients.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchClients.Image")));
            this.tsbtnSearchClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearchClients.Name = "tsbtnSearchClients";
            this.tsbtnSearchClients.Size = new System.Drawing.Size(24, 24);
            this.tsbtnSearchClients.Text = "Search Clients";
           // this.tsbtnSearchClients.Click += new System.EventHandler(this.btnSearchClients_Click);
            // 
            // tsbtnSearchVessels
            // 
            this.tsbtnSearchVessels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSearchVessels.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearchVessels.Image")));
            this.tsbtnSearchVessels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearchVessels.Name = "tsbtnSearchVessels";
            this.tsbtnSearchVessels.Size = new System.Drawing.Size(24, 24);
            this.tsbtnSearchVessels.Text = "toolStripButton1";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 640);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMainMenu";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAddVessel;
        private System.Windows.Forms.ToolStripButton tsbtnAddClient;
        private System.Windows.Forms.ToolStripButton tsbtnSearchClients;
        private System.Windows.Forms.ToolStripButton tsbtnSearchVessels;
    }
}