using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMSIS.UL;
using MMSIS.DL;
using MMSIS.BL;

namespace MMSIS.UI
{
    public partial class frmAddPowerVessel : Form
    {
        public frmAddPowerVessel()
        {
            InitializeComponent();
        }


        private int dbUpdateSuccessful = 0;

        public  void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    //If the data is valid, then initialize fields to string or int and instanciate Vessel object
                    vesselHIN = (txtVesselHIN.Text);
                    vesselLOAFt = Convert.ToInt32(txtVesselLOAFt.Text);
                    vesselLOAIn = Convert.ToInt32 (txtVesselLOAIn.Text );
                    vesselBeamFt = Convert.ToInt32(txtVesselBeamFt.Text );
                    vesselBeamIn = Convert.ToInt32(txtVesselBeamIn.Text);
                    vesselDraftFt = Convert.ToInt32(txtVesselDraftFt.Text);
                    vesselDraftIn = Convert.ToInt32(txtVesselDraftIn.Text);
                    vesselEngineMake = (txtVesselEngineMake.Text);
                    vesselEngineHP = Convert.ToInt32(txtVesselEngineHP.Text);
                    vesselNumOfEngines = Convert.ToInt32(txtVesselNumOfEngines.Text);
                    vesselEngineFuel = (txtVesselEngineFuel.Text);
                    vesselEngineType = (txtVesselEngineType.Text);

                    //Instanciate Vessel Object
                    Vessel vessel = new Vessel(vesselHIN, vesselLOAFt, vesselLOAIn, vesselBeamFt, vesselBeamIn, vesselDraftFt,
                        vesselDraftIn,  vesselEngineMake, vesselEngineHP, vesselNumOfEngines,
                        vesselEngineFuel, vesselEngineType);

                    //Invoke AddVesel Db stored procedure and pass in Vessel object
                    dbUpdateSuccessful = VesselDb.AddVessel(vessel);

                    if (dbUpdateSuccessful == 0)
                    {
                        ClearAllFields();
                        MessageBox.Show("Database exception, contact administrator.");
                    }
                    else
                    {
                        ClearAllFields();
                        MessageBox.Show("Vessel Added.");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "/n" +
                    ex.StackTrace, "Exception");
            }

        } // end btn click

        private  bool  IsValidData()
        {
            // check to see if int input fields are int and that HIN has been input
            // does not check to make sure all data fields have been input

            return Validator.IsPresent(txtVesselHIN, "Vessel HIN") &&
                Validator.IsPresent(txtVesselEngineFuel, "Vessel Fuel Type") &&
                Validator.IsPresent(txtVesselEngineType, "Vessel HIN") &&
               Validator.IsPresent(txtVesselEngineMake, "Vessel HIN") &&
                Validator.IsDecimal(txtVesselLOAFt, "LOA Ft.") &&
                Validator.IsDecimal(txtVesselLOAIn, "LOA In.") &&
                Validator.IsDecimal(txtVesselBeamFt, "Beam Ft.") &&
                Validator.IsDecimal(txtVesselBeamIn, "Beam In.") &&
                Validator.IsDecimal(txtVesselDraftFt, "Draft Ft.") &&
                Validator.IsDecimal(txtVesselDraftIn, "Draft In.") &&
                Validator.IsDecimal(txtVesselNumOfEngines, "Number of Engines") &&
                Validator.IsDecimal(txtVesselEngineHP, "Engine HP");
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void ClearAllFields()
        {
            txtVesselBeamFt.Text = "";
            txtVesselBeamIn.Text = "";
            txtVesselDraftFt.Text = "";
            txtVesselDraftIn.Text = "";
            txtVesselEngineFuel.Text = "";
            txtVesselEngineHP.Text = "";
            txtVesselEngineMake.Text = "";
            txtVesselEngineType.Text = "";
            txtVesselHIN.Text = "";
            txtVesselLOAFt.Text = "";
            txtVesselLOAIn.Text = "";
            txtVesselNumOfEngines.Text = "";
        }

        private string vesselHIN;
        private int vesselLOAFt;
        private int vesselLOAIn;
        private int vesselBeamFt;
        private int vesselBeamIn;
        private int vesselDraftFt;
        private int vesselDraftIn;
        private string vesselEngineMake;
        private int vesselEngineHP;
        private int vesselNumOfEngines;
        private string vesselEngineFuel;
        private string vesselEngineType;


    }
}
