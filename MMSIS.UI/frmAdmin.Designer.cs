namespace MMSIS.UI
{
    partial class frmAdmin
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstContactType = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addContactTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tools";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact Type:";
            // 
            // lstContactType
            // 
            this.lstContactType.ContextMenuStrip = this.contextMenuStrip1;
            this.lstContactType.FormattingEnabled = true;
            this.lstContactType.ItemHeight = 20;
            this.lstContactType.Location = new System.Drawing.Point(179, 76);
            this.lstContactType.Name = "lstContactType";
            this.lstContactType.Size = new System.Drawing.Size(143, 64);
            this.lstContactType.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactTypeToolStripMenuItem,
            this.deleteContactTypeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 101);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addContactTypeToolStripMenuItem
            // 
            this.addContactTypeToolStripMenuItem.Name = "addContactTypeToolStripMenuItem";
            this.addContactTypeToolStripMenuItem.Size = new System.Drawing.Size(226, 32);
            this.addContactTypeToolStripMenuItem.Text = "Add Contact Type";
            this.addContactTypeToolStripMenuItem.Click += new System.EventHandler(this.addContactTypeToolStripMenuItem_Click);
            // 
            // deleteContactTypeToolStripMenuItem
            // 
            this.deleteContactTypeToolStripMenuItem.Name = "deleteContactTypeToolStripMenuItem";
            this.deleteContactTypeToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.deleteContactTypeToolStripMenuItem.Text = "Delete Contact Type";
            this.deleteContactTypeToolStripMenuItem.Click += new System.EventHandler(this.deleteContactTypeToolStripMenuItem_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstContactType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstContactType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addContactTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactTypeToolStripMenuItem;
    }
}