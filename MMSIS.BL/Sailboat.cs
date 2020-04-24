using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace MMSIS.BL
{
    public class Sailboat : Vessel
    {
        public  Sailboat
        (string KeelType, string RudderType, int NumMasts, int NumSpreaders, string MastMaterial,
            string SteeringType)
        {
            keelType = KeelType;
            rudderType = RudderType;
            numMasts = NumMasts;
            numSpreaders = NumSpreaders;
            mastMaterial = MastMaterial;
            steeringType = SteeringType;
        }

        public string KeelType { get; set; }
        public string RudderType { get; set; }
        public int NumMasts { get; set; }
        public int NumSpreaders { get; set; }
        public string MastMaterial { get; set; }
        public string SteeringType { get; set; }

        private string keelType;
        private string rudderType;
        private int numMasts;
        private int numSpreaders;
        private string mastMaterial;
        private string steeringType;
    }
}
