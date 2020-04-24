using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MMSIS.BL;

namespace MMSIS.DL
{
    public class VesselDb
    {
        public static int AddVessel(Vessel vessel)
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spAddVessel", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@vesselHIN", SqlDbType.VarChar).Value = vessel.VesselHIN;
                cmd.Parameters.Add("@vesselLOAFt", SqlDbType.Int).Value = vessel.VesselLOAft;
                cmd.Parameters.Add("@vesselLOAIn", SqlDbType.Int).Value = vessel.VesselLOAIn;
                cmd.Parameters.Add("@vesselBeamFt", SqlDbType.Int).Value = vessel.VesselBeamFt;
                cmd.Parameters.Add("@vesselBeamIn", SqlDbType.Int).Value = vessel.VesselBeamIn;
                cmd.Parameters.Add("@vesselDraftFt", SqlDbType.Int).Value = vessel.VesselDraftFt;
                cmd.Parameters.Add("@vesselDraftIn", SqlDbType.Int).Value = vessel.VesselDraftIn;
                cmd.Parameters.Add("@vesselEngineMake", SqlDbType.VarChar).Value = vessel.VesselEngineMake;
                cmd.Parameters.Add("@vesselEngineHP", SqlDbType.Int).Value = vessel.VesselEngineHP;
                cmd.Parameters.Add("@vesselNumOfEngines", SqlDbType.Int).Value = vessel.VesselNumOfEngines;
                cmd.Parameters.Add("@vesselEngineFuel", SqlDbType.VarChar).Value = vessel.VesselEngineFuel;
                cmd.Parameters.Add("@vesselEngineType", SqlDbType.VarChar).Value = vessel.VesselEngineType;

                try
                {
                    connection.Open();
                    int i = cmd.ExecuteNonQuery(); //stores the no. of rows affected.

                    return i;
                }
                catch
                {
                    return 0;
                }
              }
        }
    }
}