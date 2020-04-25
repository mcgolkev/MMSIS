using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MMSIS.DL;
using MMSIS.BL;
using System.Threading;

namespace MMSIS.DL
{
    public class ContactDb
    {
        
        //===============================================================================================
        //           BEGIN GET CUSTOMER BY CLIENT ID NUMBER

        public static Contact GetContact(Guid contactId)
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spContactNameXContactID", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ContactId", SqlDbType.VarChar).Value = contactId;


                try
                {
                    connection.Open();
                    SqlDataReader custReader =
                        cmd.ExecuteReader(CommandBehavior.SingleRow);
                    if (custReader.Read())
                    {
                        Contact contact = new Contact();
                        contact.ContactId = (Guid)custReader["ContactId"];
                        contact.ContactFirstName = custReader["ContactFirstName"].ToString();
                        contact.ContactLastName = custReader["ContactLastName"].ToString();
                        contact.ContactCreateDate = (DateTime)custReader["ContactCreateDate"];
                        contact.ContactLastActivity = (DateTime)custReader["ContactNaLastUpdate"];
                        return contact;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        } //end get customer
         
          //==========================================================================================
          //            BEGIN GET CONTACT BY LAST NAME SEARCH TERM

        public static DataTable GetContactXLastName(string searchArg)
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spSelectContactXLastName", connection))
            {
                DataTable dataTable = new DataTable();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = searchArg;
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                try
                {
                    connection.Open();
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        } //end get contact by last name

        //=================================================================================================
        //               BEGIN ADD CONTACT

        public static int AddContact(Contact contact)
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spAddContactWithAddress", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ContactFirstName", SqlDbType.VarChar).Value = contact.ContactFirstName;
                cmd.Parameters.Add("@ContactLastName", SqlDbType.VarChar).Value = contact.ContactLastName;
                cmd.Parameters.Add("@ContactType", SqlDbType.VarChar).Value = contact.ContactType;
                cmd.Parameters.Add("@ContactNote", SqlDbType.VarChar).Value = contact.ContactNote;
                cmd.Parameters.Add("@ContactStreet", SqlDbType.VarChar).Value = contact.ContactStreet;
                cmd.Parameters.Add("@ContactCity", SqlDbType.VarChar).Value = contact.ContactCity;
                cmd.Parameters.Add("@ContactState", SqlDbType.VarChar).Value = contact.ContactState;

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
                finally
                {
                    connection.Close();
                }
            }
        }

        //==========================================================================================

        //=================================================================================================
        //               BEGIN ADD CONTACT TYPE

        public static int AddContactType(string ContactType)
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spAddContactType", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ContactType", SqlDbType.VarChar).Value = ContactType;

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
                finally
                {
                    connection.Close();
                }
            }
        }

        //==========================================================================================
        //==========================================================================================

        //            BEGIN CHECK IF CONTACT TYPE EXISTS IN CONTACT TABLE

        public static int GetContactTypes(string ContactType)
        {
            int Count;
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spGetNumContactsXType", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // set up the parameters
                cmd.Parameters.Add("@Input", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@ret_value", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@Input"].Value = ContactType;

                // open connection and execute stored procedure
                connection.Open();
                cmd.ExecuteNonQuery();

                // read output value from @ret_value
                Count = Convert.ToInt32(cmd.Parameters["@ret_value"].Value);
                connection.Close();
                return Count;
            }
        } //end get contacts by contact type

        //==========================================================================================
        //=================================================================================================
        //               BEGIN DELETE CONTACT TYPE

        public static int DeleteContactType(string ContactType)
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spDeleteContactType", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ContactType", SqlDbType.VarChar).Value = ContactType;

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
                finally
                {
                    connection.Close();
                }
            }
        }

        //==========================================================================================

        //            BEGIN GET ALL CONTACTS, ORDER BY LAST NAME 

        public static DataTable GetAllContacts()
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spSelectAllContacts", connection))
            {
                DataTable dataTable = new DataTable();

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                try
                {
                    connection.Open();
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        } //end get customer by last name

        //==========================================================================================

        //==========================================================================================
        //            BEGIN GET ALL CONTACT TYPE NAMES 

        public static DataTable GetAllContactTypes()
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spGetAllContactTypes", connection))
            {
                DataTable dataTable = new DataTable();

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                try
                {
                    connection.Open();
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }

                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        } //end get contact type names

        //==========================================================================================




        //            BEGIN GET ALL US STATES 

        public static DataTable GetAllUSStates()
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spSelectAllUSStates", connection))
            {
                DataTable dataTable = new DataTable();

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter();

                try
                {
                    connection.Open();
                    dataAdapter.SelectCommand = cmd;
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }

} //end class

