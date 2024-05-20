﻿using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Project_Management_Admin_Panel.Models;
using System.Data.Common;
using System.Data;
using WebApplication2.DAL;

namespace Project_Management_Admin_Panel.DAL
{
    #region Auth_DALBase
    public class Auth_DALBase : Dal_Helper, IAuthDAL
    {
        #region Section: SetUp Of Database Connection and Initialization

        private SqlDatabase sqlDatabase;

        /// <summary>
        /// Initializes a new instance of the Payment_DALBase class, setting up the database connection.
        /// </summary>
        public Auth_DALBase()
        {
            // Assuming 'Database_Connection' is a predefined string or obtained elsewhere in your application.

            sqlDatabase = new SqlDatabase(Constr);
        }

        /// <summary>
        /// Retrieves a DbCommand object configured for executing the specified stored procedure.
        /// </summary>
        /// <param name="storedProcedureName">The name of the stored procedure for which to get the DbCommand.</param>
        /// <returns>A DbCommand object configured to execute the named stored procedure.</returns>
        private DbCommand Command_Name(string storedProcedureName)
        {
            return sqlDatabase.GetStoredProcCommand(storedProcedureName);
        }

        #endregion

        #region Section : Auth User Check

        /// <summary>
        /// Authenticates a user based on the provided username and password.
        /// </summary>
        /// <param name="auth_details">The Auth_Model object containing the username and password.</param>
        /// <returns>A User_Model object containing user information if authentication is successful, otherwise null.</returns>
        public User_Model AuthUser(Auth_Model auth_details)
        {
            DbCommand dbCommand = Command_Name("API_CHECK_AUTH_DETAILS");
            sqlDatabase.AddInParameter(dbCommand, "@Auth_Username", SqlDbType.VarChar, auth_details.Username);
            sqlDatabase.AddInParameter(dbCommand, "@Auth_Password", SqlDbType.VarChar, auth_details.Password);

            User_Model user_info = new User_Model();

            using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
            {
                if (dataReader.Read())
                {
                    user_info.Userid = Convert.ToInt32(dataReader["AUTH_ID"].ToString());
                    user_info.Username = dataReader["AUTH_NAME"].ToString();
                    user_info.Emailaddress = dataReader["AUTH_EMAIL"].ToString();
                    user_info.Password = dataReader["AUTH_PASSWORD"].ToString();
                    user_info.Phoneno = dataReader["AUTH_PHONE_NO"].ToString();
                }
            }

            return user_info;
        }


        public User_Model GetAuthUserByEmail(string email)
        {
            DbCommand dbCommand = Command_Name("API_GET_AUTH_BY_EMAIL");
            sqlDatabase.AddInParameter(dbCommand, "@Email", SqlDbType.VarChar, email);

            User_Model user_info = null;

            using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
            {
                if (dataReader.Read())
                {
                    user_info = new User_Model
                    {
                        Userid = Convert.ToInt32(dataReader["AUTH_ID"]),
                        Username = dataReader["AUTH_NAME"].ToString(),
                        Emailaddress = dataReader["AUTH_EMAIL"].ToString()
                    };
                }
            }

            return user_info;
        }

        #endregion
    }


}
#endregion