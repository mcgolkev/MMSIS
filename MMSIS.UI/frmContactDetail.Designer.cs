namespace MMSIS.UI
{
    partial class frmContactDetail
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
            this.txtContactFirstName = new System.Windows.Forms.TextBox();
            this.txtContactLastName = new System.Windows.Forms.TextBox();
            this.txtContactId = new System.Windows.Forms.TextBox();
            this.txtContactCreateDate = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Creation Date";
            // 
            // txtContactFirstName
            // 
            this.txtContactFirstName.Location = new System.Drawing.Point(273, 46);
            this.txtContactFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactFirstName.Name = "txtContactFirstName";
            this.txtContactFirstName.Size = new System.Drawing.Size(112, 26);
            this.txtContactFirstName.TabIndex = 4;
            // 
            // txtContactLastName
            // 
            this.txtContactLastName.Location = new System.Drawing.Point(273, 92);
            this.txtContactLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactLastName.Name = "txtContactLastName";
            this.txtContactLastName.Size = new System.Drawing.Size(112, 26);
            this.txtContactLastName.TabIndex = 5;
            // 
            // txtContactId
            // 
            this.txtContactId.Location = new System.Drawing.Point(273, 141);
            this.txtContactId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactId.Name = "txtContactId";
            this.txtContactId.Size = new System.Drawing.Size(112, 26);
            this.txtContactId.TabIndex = 6;
            // 
            // txtContactCreateDate
            // 
            this.txtContactCreateDate.Location = new System.Drawing.Point(273, 194);
            this.txtContactCreateDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactCreateDate.Name = "txtContactCreateDate";
            this.txtContactCreateDate.Size = new System.Drawing.Size(112, 26);
            this.txtContactCreateDate.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(327, 321);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(582, 321);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmContactDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 599);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtContactCreateDate);
            this.Controls.Add(this.txtContactId);
            this.Controls.Add(this.txtContactLastName);
            this.Controls.Add(this.txtContactFirstName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmContactDetail";
            this.Text = "ClientDetail";
            this.Load += new System.EventHandler(this.frmClientDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactFirstName;
        private System.Windows.Forms.TextBox txtContactLastName;
        private System.Windows.Forms.TextBox txtContactId;
        private System.Windows.Forms.TextBox txtContactCreateDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}