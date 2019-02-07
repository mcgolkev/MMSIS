﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MMSIS.DL;

namespace MMSIS.DL
{
    public class CustomerDb
    {
        //================================================================================================
        //           BEGIN GET CUSTOMER BY CLIENT ID NUMBER (NOT CURRENTLY USED)

        public static Customer GetCustomer(string clientId)
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spClientNameXClientID", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ClientId", SqlDbType.VarChar).Value = clientId;


                try
                {
                    connection.Open();
                    SqlDataReader custReader =
                        cmd.ExecuteReader(CommandBehavior.SingleRow);
                    if (custReader.Read())
                    {
                        Customer customer = new Customer();
                        customer.ClientId = custReader["ClientId"].ToString();
                        customer.ClientFn = custReader["ClientFn"].ToString();
                        customer.ClientLn = custReader["ClientLn"].ToString();
                        customer.ClientCreateDate = (DateTime)custReader["ClientCreateDate"];
                        customer.ClientLastActivity = (DateTime)custReader["ClientNaLastUpdate"];
                        return customer;
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
          //
          //==========================================================================================
          //            BEGIN GET CUSTOMER BY LAST NAME SEARCH TERM

        public static DataTable GetCustomerXLastName(string searchArg)
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spSelectClientNameXLastName", connection))
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
        } //end get customer by last name

        //=================================================================================================
        //               BEGIN ADD CUSTOMER

        public static int AddCustomer(Customer customer)
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spAddCustomer", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ContactFirstName", SqlDbType.VarChar).Value = customer.ContactFirstName;
                cmd.Parameters.Add("@ContactLastName", SqlDbType.VarChar).Value = customer.ContactLastName;
                cmd.Parameters.Add("@ContactCoName", SqlDbType.VarChar).Value = customer.ContactCoName;
                cmd.Parameters.Add("@ContactJobTitle", SqlDbType.VarChar).Value = customer.ContactJobTitle;
                cmd.Parameters.Add("@ContactType", SqlDbType.VarChar).Value = customer.ContactType;
                cmd.Parameters.Add("@ContactNote", SqlDbType.VarChar).Value = customer.ContactNote;

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

        //==========================================================================================
        //            BEGIN GET ALL CUSTOMERS, ORDER BY LAST NAME 

        public static DataTable GetAllCustomers()
        {
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spSelectAllClients", connection))
            {
                DataTable dataTable = new DataTable();

                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = searchArg;
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
