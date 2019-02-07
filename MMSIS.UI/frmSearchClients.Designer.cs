namespace MMSIS.UI
{
    partial class frmSearchClients
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
            this.lstCustomerResults = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchArg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstCustomerResults
            // 
            this.lstCustomerResults.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomerResults.FormattingEnabled = true;
            this.lstCustomerResults.ItemHeight = 22;
            this.lstCustomerResults.Location = new System.Drawing.Point(66, 155);
            this.lstCustomerResults.Name = "lstCustomerResults";
            this.lstCustomerResults.Size = new System.Drawing.Size(805, 422);
            this.lstCustomerResults.TabIndex = 0;
            this.lstCustomerResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCustomerResults_MouseDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(672, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Last Name:";
            // 
            // txtSearchArg
            // 
            this.txtSearchArg.Location = new System.Drawing.Point(192, 56);
            this.txtSearchArg.Name = "txtSearchArg";
            this.txtSearchArg.Size = new System.Drawing.Size(431, 22);
            this.txtSearchArg.TabIndex = 3;
            // 
            // frmSearchClients
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 637);
            this.Controls.Add(this.txtSearchArg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstCustomerResults);
            this.Name = "frmSearchClients";
            this.Text = "frmSearchClients";
            this.Load += new System.EventHandler(this.frmSearchClients_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomerResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchArg;
    }
}