namespace MMSIS.UI
{
    partial class frmFindContact
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
            this.lstSrchResults = new System.Windows.Forms.ListBox();
            this.txtSrchLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSrchResults
            // 
            this.lstSrchResults.ColumnWidth = 2;
            this.lstSrchResults.FormattingEnabled = true;
            this.lstSrchResults.ItemHeight = 20;
            this.lstSrchResults.Location = new System.Drawing.Point(23, 98);
            this.lstSrchResults.Name = "lstSrchResults";
            this.lstSrchResults.Size = new System.Drawing.Size(1075, 524);
            this.lstSrchResults.TabIndex = 0;
            // 
            // txtSrchLastName
            // 
            this.txtSrchLastName.Location = new System.Drawing.Point(347, 25);
            this.txtSrchLastName.Name = "txtSrchLastName";
            this.txtSrchLastName.Size = new System.Drawing.Size(389, 26);
            this.txtSrchLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contact Last Name";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(826, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(108, 34);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "FIND";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Results:";
            // 
            // frmFindContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 674);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSrchLastName);
            this.Controls.Add(this.lstSrchResults);
            this.Name = "frmFindContact";
            this.Text = "frmFindContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSrchResults;
        private System.Windows.Forms.TextBox txtSrchLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
    }
}