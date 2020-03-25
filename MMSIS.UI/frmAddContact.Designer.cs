namespace MMSIS.UI
{
    partial class frmAddContact
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
            this.label10 = new System.Windows.Forms.Label();
            this.txtContactFirstName = new System.Windows.Forms.TextBox();
            this.txtContactLastName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Contact Input";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Name and Address";
            // 
            // txtContactFirstName
            // 
            this.txtContactFirstName.Location = new System.Drawing.Point(223, 95);
            this.txtContactFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactFirstName.Name = "txtContactFirstName";
            this.txtContactFirstName.Size = new System.Drawing.Size(398, 26);
            this.txtContactFirstName.TabIndex = 14;
            // 
            // txtContactLastName
            // 
            this.txtContactLastName.Location = new System.Drawing.Point(223, 130);
            this.txtContactLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactLastName.Name = "txtContactLastName";
            this.txtContactLastName.Size = new System.Drawing.Size(398, 26);
            this.txtContactLastName.TabIndex = 15;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(315, 218);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 29);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Client First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Client Last Name";
            // 
            // frmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 801);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtContactLastName);
            this.Controls.Add(this.txtContactFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddContact";
            this.Text = "Add Contact";
            this.Load += new System.EventHandler(this.frmAddClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtContactFirstName;
        private System.Windows.Forms.TextBox txtContactLastName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}