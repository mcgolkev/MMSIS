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
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtContactNote = new System.Windows.Forms.TextBox();
            this.lblContactType = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.cboContactType = new System.Windows.Forms.ComboBox();
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
            this.txtContactFirstName.TabIndex = 1;
            // 
            // txtContactLastName
            // 
            this.txtContactLastName.Location = new System.Drawing.Point(223, 130);
            this.txtContactLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactLastName.Name = "txtContactLastName";
            this.txtContactLastName.Size = new System.Drawing.Size(398, 26);
            this.txtContactLastName.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(334, 543);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(84, 29);
            this.btnSubmit.TabIndex = 7;
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
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(193, 197);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(225, 26);
            this.txtStreet.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(193, 229);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(225, 26);
            this.txtCity.TabIndex = 4;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(98, 200);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(57, 20);
            this.lblStreet.TabIndex = 27;
            this.lblStreet.Text = "Street:";
            this.lblStreet.Click += new System.EventHandler(this.lblStreet_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(103, 235);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 28;
            this.lblCity.Text = "City:";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(49, 180);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(93, 20);
            this.lblAddress.TabIndex = 29;
            this.lblAddress.Text = "ADDRESS:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(98, 271);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(48, 20);
            this.lblState.TabIndex = 30;
            this.lblState.Text = "State";
            this.lblState.Click += new System.EventHandler(this.lblState_Click);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(193, 265);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(225, 26);
            this.txtState.TabIndex = 5;
            // 
            // txtContactNote
            // 
            this.txtContactNote.Location = new System.Drawing.Point(193, 338);
            this.txtContactNote.Multiline = true;
            this.txtContactNote.Name = "txtContactNote";
            this.txtContactNote.Size = new System.Drawing.Size(505, 179);
            this.txtContactNote.TabIndex = 6;
            // 
            // lblContactType
            // 
            this.lblContactType.AutoSize = true;
            this.lblContactType.Location = new System.Drawing.Point(219, 36);
            this.lblContactType.Name = "lblContactType";
            this.lblContactType.Size = new System.Drawing.Size(107, 20);
            this.lblContactType.TabIndex = 34;
            this.lblContactType.Text = "Contact Type:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(98, 338);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(47, 20);
            this.lblNote.TabIndex = 35;
            this.lblNote.Text = "Note:";
            // 
            // cboContactType
            // 
            this.cboContactType.AllowDrop = true;
            this.cboContactType.FormattingEnabled = true;
            this.cboContactType.Location = new System.Drawing.Point(333, 27);
            this.cboContactType.Name = "cboContactType";
            this.cboContactType.Size = new System.Drawing.Size(121, 28);
            this.cboContactType.TabIndex = 36;
            // 
            // frmAddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(806, 801);
            this.Controls.Add(this.cboContactType);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblContactType);
            this.Controls.Add(this.txtContactNote);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtContactLastName);
            this.Controls.Add(this.txtContactFirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddContact";
            this.Text = "Create Contact";
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
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtContactNote;
        private System.Windows.Forms.Label lblContactType;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.ComboBox cboContactType;
    }
}