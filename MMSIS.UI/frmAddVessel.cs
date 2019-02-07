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
    public partial class frmAddVessel : Form
    {
        public frmAddVessel()
        {
            InitializeComponent();
        }

        private string vesselHIN;
        private int vesselLOAFt;
        private int vesselLOAIn;
        private int vesselBeamFt;
        private int vesselBeamIn;
        private int vesselDraftFt;
        private int vesselDraftIn;
        private int vesselDisplacement;
        private string vesselEngineMake;
        private string vesselEngineModel;
        private int vesselEngineHP;
        private int vesselNumOfEngines;
        private string vesselEngineFuel;
        private string vesselEngineType;

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
                    vesselDisplacement = Convert.ToInt32(txtVesselDisplacement.Text);
                    vesselEngineMake = (txtVesselEngineMake.Text);
                    vesselEngineModel = (txtVesselEngineModel.Text);
                    vesselEngineHP = Convert.ToInt32(txtVesselEngineHP.Text);
                    vesselNumOfEngines = Convert.ToInt32(txtVesselNumOfEngines.Text);
                    vesselEngineFuel = (txtVesselEngineFuel.Text);
                    vesselEngineType = (txtVesselEngineType.Text);

                    //Instanciate Vessel Object
                    Vessel vessel = new Vessel(vesselHIN, vesselLOAFt, vesselLOAIn, vesselBeamFt, vesselBeamIn, vesselDraftFt,
                        vesselDraftIn, vesselDisplacement, vesselEngineMake, vesselEngineModel, vesselEngineHP, vesselNumOfEngines,
                        vesselEngineFuel, vesselEngineType);

                    //Invoke AddVesel Db stored procedure and pass in Vessel object
                    dbUpdateSuccessful = VesselDb.AddVessel(vessel);

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
                Validator.IsDecimal(txtVesselLOAFt, "LOA Ft.") &&
                Validator.IsDecimal(txtVesselLOAIn, "LOA In.") &&
                Validator.IsDecimal(txtVesselBeamFt, "Beam Ft.") &&
                Validator.IsDecimal(txtVesselBeamIn, "Beam In.") &&
                Validator.IsDecimal(txtVesselDraftFt, "Draft Ft.") &&
                Validator.IsDecimal(txtVesselDraftIn, "Draft In.") &&
                Validator.IsDecimal(txtVesselDisplacement, "Displacement") &&
                Validator.IsDecimal(txtVesselNumOfEngines, "Number of Engines") &&
                Validator.IsDecimal(txtVesselEngineHP, "Engine HP");
        }














        private void label10_Click(object sender, EventArgs e)
        {

        }

    }
}
