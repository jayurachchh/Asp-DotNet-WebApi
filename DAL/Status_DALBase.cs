using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Project_Management_Admin_Panel.Models;
using System.Data.Common;
using System.Data;
using WebApplication2.DAL;

namespace Project_Management_Admin_Panel.DAL
{
    public class Status_DALBase:Dal_Helper
    {
        #region Model : Status

        #region Method : dbo.API_Status_Selectall
        public List<StatusModel> dbo_API_StatusGetAll()
        {
            try
            {
                List<StatusModel> listOfstatus = new List<StatusModel>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllStatus");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        StatusModel statusModel = new StatusModel();
                        statusModel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                        statusModel.StatusName = dataReader["StatusName"].ToString();
                        statusModel.StatusCssColor = dataReader["StatusCssColor"].ToString();
                        listOfstatus.Add(statusModel);
                    }
                }
                return listOfstatus;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Method : dbo.API_Status_SelectByID
        public StatusModel dbo_API_Status_SelectByID(int StatusID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectStatusById");
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", DbType.Int32, StatusID);
                StatusModel statusModel = new StatusModel();
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    dataReader.Read();
                    statusModel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                    statusModel.StatusName = dataReader["StatusName"].ToString();
                    statusModel.StatusCssColor = dataReader["StatusCssColor"].ToString();
                }
                return statusModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Status_deleteByID
        public bool dbo_API_Status_delete(int StatusID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_DeleteStatus");
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", DbType.Int32, StatusID);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand)))
                {
                    return true;
                }
                else { return false; }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Method : dbo.API_Status_insert
        public bool dbo_API_Status_insert(StatusModel statusModel)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_InsertStatus");
                sqlDatabase.AddInParameter(dbCommand, "@StatusName", SqlDbType.VarChar,statusModel.StatusName);
                sqlDatabase.AddInParameter(dbCommand, "@StatusCssColor", SqlDbType.VarChar, statusModel.StatusCssColor);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand)))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Method : dbo.API_Status_Update
        public bool dbo_API_Status_update(int StatusID, StatusModel statusModel)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_UpdateStatus");
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", SqlDbType.Int, statusModel.StatusID);
                sqlDatabase.AddInParameter(dbCommand, "@StatusName", SqlDbType.VarChar, statusModel.StatusName);
                sqlDatabase.AddInParameter(dbCommand, "@StatusCssColor", SqlDbType.VarChar, statusModel.StatusCssColor);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand)))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
        #endregion
    }
}
