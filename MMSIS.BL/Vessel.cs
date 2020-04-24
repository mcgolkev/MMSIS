//  Created: 1/16/17
//  Programmer: Kevin McGoldrick
//  Description: This class contains the business logic for a specific vessel.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMSIS.BL
{
    public class Vessel
    {
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

        public Vessel()
        {
            //construtor
        }

        public Vessel(string VesselHIN, int VesselLOAFt, int VesselLOAIn, int VesselBeamFt, int VesselBeamIn,
            int VesselDraftFt, int VesselDraftIn, string VesselEngineMake, int VesselEngineHP, 
            int VesselNumOfEngines, string VesselEngineFuel, string VesselEngineType)
        {
                vesselHIN = VesselHIN;
                vesselLOAFt = VesselLOAFt;
                vesselLOAIn = VesselLOAIn;
                vesselBeamFt = VesselBeamFt;
                vesselBeamIn = VesselBeamIn;
                vesselDraftFt = VesselDraftFt;
                vesselDraftIn = VesselDraftIn;
                vesselEngineMake = VesselEngineMake;
                vesselEngineHP = VesselEngineHP;
                vesselNumOfEngines = VesselNumOfEngines;
                vesselEngineFuel = VesselEngineFuel;
                vesselEngineType = VesselEngineType;
        }
        public string VesselHIN
        {
            get
            {
                return vesselHIN;
            }
            set
            {
                vesselHIN = value;
            }
        }

        public int VesselLOAft
        {
            get
            {
                return vesselLOAFt;
            }
            set
            {
                vesselLOAFt = value;
            }
        }
        public int VesselLOAIn
        {
            get
            {
                return vesselLOAIn;
            }
            set
            {
                vesselLOAIn = value;
            }
        }
        public int VesselBeamFt
        {
            get
            {
                return vesselBeamFt;
            }
            set
            {
                vesselBeamFt = value;
            }
        }
        public int VesselBeamIn
        {
            get
            {
                return vesselBeamIn;
            }
            set
            {
                vesselBeamIn = value;
            }
        }
        public int VesselDraftFt
        {
            get
            {
                return vesselDraftFt;
            }
            set
            {
                vesselDraftFt = value;
            }
        }
        public int VesselDraftIn
        {
            get
            {
                return vesselDraftIn;
            }
            set
            {
                vesselDraftIn = value;
            }
        }
        public string VesselEngineMake
        {
            get
            {
                return vesselEngineMake;
            }
            set
            {
                vesselEngineMake = value;
            }
        }
        public int VesselEngineHP
        {
            get
            {
                return vesselEngineHP;
            }
            set
            {
                vesselEngineHP = value;
            }
        }
        public int VesselNumOfEngines
        {
            get
            {
                return vesselNumOfEngines;
            }
            set
            {
                vesselNumOfEngines = value;
            }
        }
        public string VesselEngineFuel
        {
            get
            {
                return vesselEngineFuel;
            }
            set
            {
                vesselEngineFuel = value;
            }
        }
        public string VesselEngineType
        {
            get
            {
                return vesselEngineType;
            }
            set
            {
                vesselEngineType = value;
            }
        }
    } // end class
}
