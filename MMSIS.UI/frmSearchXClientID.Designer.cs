namespace MMSIS
{
    partial class ClientSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtClientFn = new System.Windows.Forms.TextBox();
            this.txtClientLn = new System.Windows.Forms.TextBox();
            this.txtClientCreateDate = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtInputClientId = new System.Windows.Forms.TextBox();
            this.txtClientLastActivity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Search by ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Create Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(595, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Client ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Customer ID Search:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(85, 417);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "SUBMIT!";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // txtClientFn
            // 
            this.txtClientFn.Location = new System.Drawing.Point(183, 78);
            this.txtClientFn.Name = "txtClientFn";
            this.txtClientFn.Size = new System.Drawing.Size(349, 22);
            this.txtClientFn.TabIndex = 8;
            // 
            // txtClientLn
            // 
            this.txtClientLn.Location = new System.Drawing.Point(183, 110);
            this.txtClientLn.Name = "txtClientLn";
            this.txtClientLn.Size = new System.Drawing.Size(349, 22);
            this.txtClientLn.TabIndex = 9;
            // 
            // txtClientCreateDate
            // 
            this.txtClientCreateDate.Location = new System.Drawing.Point(665, 35);
            this.txtClientCreateDate.Name = "txtClientCreateDate";
            this.txtClientCreateDate.Size = new System.Drawing.Size(231, 22);
            this.txtClientCreateDate.TabIndex = 10;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(665, 91);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(231, 22);
            this.txtClientId.TabIndex = 12;
            // 
            // txtInputClientId
            // 
            this.txtInputClientId.Location = new System.Drawing.Point(226, 303);
            this.txtInputClientId.Name = "txtInputClientId";
            this.txtInputClientId.Size = new System.Drawing.Size(349, 22);
            this.txtInputClientId.TabIndex = 13;
            // 
            // txtClientLastActivity
            // 
            this.txtClientLastActivity.Location = new System.Drawing.Point(665, 63);
            this.txtClientLastActivity.Name = "txtClientLastActivity";
            this.txtClientLastActivity.Size = new System.Drawing.Size(231, 22);
            this.txtClientLastActivity.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Updated:";
            // 
            // ClientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 577);
            this.Controls.Add(this.txtInputClientId);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.txtClientLastActivity);
            this.Controls.Add(this.txtClientCreateDate);
            this.Controls.Add(this.txtClientLn);
            this.Controls.Add(this.txtClientFn);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientSearch";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtClientFn;
        private System.Windows.Forms.TextBox txtClientLn;
        private System.Windows.Forms.TextBox txtClientCreateDate;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtInputClientId;
        private System.Windows.Forms.TextBox txtClientLastActivity;
        private System.Windows.Forms.Label label5;
    }
}