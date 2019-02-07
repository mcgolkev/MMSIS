namespace MMSIS.UI
{
    partial class frmAddVessel
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVesselHIN = new System.Windows.Forms.TextBox();
            this.txtVesselLOAFt = new System.Windows.Forms.TextBox();
            this.txtVesselLOAIn = new System.Windows.Forms.TextBox();
            this.txtVesselBeamFt = new System.Windows.Forms.TextBox();
            this.txtVesselBeamIn = new System.Windows.Forms.TextBox();
            this.txtVesselDraftFt = new System.Windows.Forms.TextBox();
            this.txtVesselDraftIn = new System.Windows.Forms.TextBox();
            this.txtVesselDisplacement = new System.Windows.Forms.TextBox();
            this.txtVesselEngineMake = new System.Windows.Forms.TextBox();
            this.txtVesselEngineModel = new System.Windows.Forms.TextBox();
            this.txtVesselEngineHP = new System.Windows.Forms.TextBox();
            this.txtVesselNumOfEngines = new System.Windows.Forms.TextBox();
            this.txtVesselEngineFuel = new System.Windows.Forms.TextBox();
            this.txtVesselEngineType = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Vessel Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "HIN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOA (ft./in.):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Beam (ft./in.):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Draft (ft./in.):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Displacement:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Engine Manufacturer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Engine Model:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Engine HP:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Number of Engines:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 369);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Engine Fuel:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(47, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Engine Type:";
            // 
            // txtVesselHIN
            // 
            this.txtVesselHIN.Location = new System.Drawing.Point(91, 53);
            this.txtVesselHIN.Name = "txtVesselHIN";
            this.txtVesselHIN.Size = new System.Drawing.Size(335, 22);
            this.txtVesselHIN.TabIndex = 12;
            // 
            // txtVesselLOAFt
            // 
            this.txtVesselLOAFt.Location = new System.Drawing.Point(138, 88);
            this.txtVesselLOAFt.Name = "txtVesselLOAFt";
            this.txtVesselLOAFt.Size = new System.Drawing.Size(42, 22);
            this.txtVesselLOAFt.TabIndex = 13;
            // 
            // txtVesselLOAIn
            // 
            this.txtVesselLOAIn.Location = new System.Drawing.Point(225, 88);
            this.txtVesselLOAIn.Name = "txtVesselLOAIn";
            this.txtVesselLOAIn.Size = new System.Drawing.Size(40, 22);
            this.txtVesselLOAIn.TabIndex = 14;
            // 
            // txtVesselBeamFt
            // 
            this.txtVesselBeamFt.Location = new System.Drawing.Point(146, 122);
            this.txtVesselBeamFt.Name = "txtVesselBeamFt";
            this.txtVesselBeamFt.Size = new System.Drawing.Size(34, 22);
            this.txtVesselBeamFt.TabIndex = 15;
            // 
            // txtVesselBeamIn
            // 
            this.txtVesselBeamIn.Location = new System.Drawing.Point(225, 122);
            this.txtVesselBeamIn.Name = "txtVesselBeamIn";
            this.txtVesselBeamIn.Size = new System.Drawing.Size(40, 22);
            this.txtVesselBeamIn.TabIndex = 16;
            // 
            // txtVesselDraftFt
            // 
            this.txtVesselDraftFt.Location = new System.Drawing.Point(146, 159);
            this.txtVesselDraftFt.Name = "txtVesselDraftFt";
            this.txtVesselDraftFt.Size = new System.Drawing.Size(34, 22);
            this.txtVesselDraftFt.TabIndex = 17;
            // 
            // txtVesselDraftIn
            // 
            this.txtVesselDraftIn.Location = new System.Drawing.Point(225, 159);
            this.txtVesselDraftIn.Name = "txtVesselDraftIn";
            this.txtVesselDraftIn.Size = new System.Drawing.Size(40, 22);
            this.txtVesselDraftIn.TabIndex = 18;
            // 
            // txtVesselDisplacement
            // 
            this.txtVesselDisplacement.Location = new System.Drawing.Point(146, 196);
            this.txtVesselDisplacement.Name = "txtVesselDisplacement";
            this.txtVesselDisplacement.Size = new System.Drawing.Size(208, 22);
            this.txtVesselDisplacement.TabIndex = 19;
            // 
            // txtVesselEngineMake
            // 
            this.txtVesselEngineMake.Location = new System.Drawing.Point(197, 223);
            this.txtVesselEngineMake.Name = "txtVesselEngineMake";
            this.txtVesselEngineMake.Size = new System.Drawing.Size(252, 22);
            this.txtVesselEngineMake.TabIndex = 20;
            // 
            // txtVesselEngineModel
            // 
            this.txtVesselEngineModel.Location = new System.Drawing.Point(151, 257);
            this.txtVesselEngineModel.Name = "txtVesselEngineModel";
            this.txtVesselEngineModel.Size = new System.Drawing.Size(242, 22);
            this.txtVesselEngineModel.TabIndex = 21;
            // 
            // txtVesselEngineHP
            // 
            this.txtVesselEngineHP.Location = new System.Drawing.Point(132, 290);
            this.txtVesselEngineHP.Name = "txtVesselEngineHP";
            this.txtVesselEngineHP.Size = new System.Drawing.Size(118, 22);
            this.txtVesselEngineHP.TabIndex = 22;
            // 
            // txtVesselNumOfEngines
            // 
            this.txtVesselNumOfEngines.Location = new System.Drawing.Point(189, 331);
            this.txtVesselNumOfEngines.Name = "txtVesselNumOfEngines";
            this.txtVesselNumOfEngines.Size = new System.Drawing.Size(100, 22);
            this.txtVesselNumOfEngines.TabIndex = 23;
            // 
            // txtVesselEngineFuel
            // 
            this.txtVesselEngineFuel.Location = new System.Drawing.Point(151, 366);
            this.txtVesselEngineFuel.Name = "txtVesselEngineFuel";
            this.txtVesselEngineFuel.Size = new System.Drawing.Size(163, 22);
            this.txtVesselEngineFuel.TabIndex = 24;
            // 
            // txtVesselEngineType
            // 
            this.txtVesselEngineType.Location = new System.Drawing.Point(151, 405);
            this.txtVesselEngineType.Name = "txtVesselEngineType";
            this.txtVesselEngineType.Size = new System.Drawing.Size(163, 22);
            this.txtVesselEngineType.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "/";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(186, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "/";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(186, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "/";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(350, 469);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AddVessel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 597);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtVesselEngineType);
            this.Controls.Add(this.txtVesselEngineFuel);
            this.Controls.Add(this.txtVesselNumOfEngines);
            this.Controls.Add(this.txtVesselEngineHP);
            this.Controls.Add(this.txtVesselEngineModel);
            this.Controls.Add(this.txtVesselEngineMake);
            this.Controls.Add(this.txtVesselDisplacement);
            this.Controls.Add(this.txtVesselDraftIn);
            this.Controls.Add(this.txtVesselDraftFt);
            this.Controls.Add(this.txtVesselBeamIn);
            this.Controls.Add(this.txtVesselBeamFt);
            this.Controls.Add(this.txtVesselLOAIn);
            this.Controls.Add(this.txtVesselLOAFt);
            this.Controls.Add(this.txtVesselHIN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddVessel";
            this.Text = "AddVessel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVesselHIN;
        private System.Windows.Forms.TextBox txtVesselLOAFt;
        private System.Windows.Forms.TextBox txtVesselLOAIn;
        private System.Windows.Forms.TextBox txtVesselBeamFt;
        private System.Windows.Forms.TextBox txtVesselBeamIn;
        private System.Windows.Forms.TextBox txtVesselDraftFt;
        private System.Windows.Forms.TextBox txtVesselDraftIn;
        private System.Windows.Forms.TextBox txtVesselDisplacement;
        private System.Windows.Forms.TextBox txtVesselEngineMake;
        private System.Windows.Forms.TextBox txtVesselEngineModel;
        private System.Windows.Forms.TextBox txtVesselEngineHP;
        private System.Windows.Forms.TextBox txtVesselNumOfEngines;
        private System.Windows.Forms.TextBox txtVesselEngineFuel;
        private System.Windows.Forms.TextBox txtVesselEngineType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSubmit;
    }
}