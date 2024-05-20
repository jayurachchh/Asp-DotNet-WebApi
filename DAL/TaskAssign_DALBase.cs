using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Project_Management_Admin_Panel.Models;
using System.Data.Common;
using System.Data;
using WebApplication2.DAL;

namespace Project_Management_Admin_Panel.DAL
{
    public class TaskAssign_DALBase:Dal_Helper
    {
        #region Model:TaskAssign

        #region Method : dbo.API_TaskAssign_Selectall
        public List<TaskAssign> dbo_API_TaskAssignGetAll()
        {
            try
            {
                List<TaskAssign> listOfTaskAssign = new List<TaskAssign>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllTaskAssign");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        TaskAssign taskAssignModel =new TaskAssign();
                   
                        taskAssignModel.TaskAssignID = Convert.ToInt32(dataReader["TaskAssignID"]);
                        taskAssignModel.TaskAssignStartDate = Convert.ToDateTime(dataReader["TaskAssignStartDate"].ToString());
                        taskAssignModel.TaskAssignCompletionDate= Convert.ToDateTime(dataReader["TaskAssignCompletionDate"].ToString());
                        taskAssignModel.Remarks = dataReader["Remarks"].ToString();
                        taskAssignModel.ProjWiseTaskID= Convert.ToInt32(dataReader["ProjWiseTaskID"]);
                        taskAssignModel.ProjWiseTaskName = dataReader["ProjWiseTaskName"].ToString();
                        taskAssignModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        taskAssignModel.EmpName = dataReader["EmpName"].ToString();
                        taskAssignModel.StatusID= Convert.ToInt32(dataReader["StatusID"]);
                        taskAssignModel.StatusName = dataReader["StatusName"].ToString();
                        taskAssignModel.StatusCssColor = dataReader["StatusCssColor"].ToString();
                        taskAssignModel.Created = Convert.ToDateTime(dataReader["Created"].ToString());
                        taskAssignModel.Modified =Convert.ToDateTime(dataReader["Modified"].ToString());
                        listOfTaskAssign.Add(taskAssignModel);
                    }
                }
                return listOfTaskAssign;
            }
            catch (Exception ex)
            { 
                return null;
            }

        }
        #endregion

        #region Method : dbo.API_TaskAssign_SelectByID
        public TaskAssign dbo_API_TaskAssign_SelectByID(int TaskAssignID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectTaskAssignById");
                sqlDatabase.AddInParameter(dbCommand, "@TaskAssignID", DbType.Int32, TaskAssignID);
                TaskAssign taskAssignModel = new TaskAssign();
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                { 
                    dataReader.Read();
                    taskAssignModel.TaskAssignID = Convert.ToInt32(dataReader["TaskAssignID"]);
                    taskAssignModel.TaskAssignStartDate = Convert.ToDateTime(dataReader["TaskAssignStartDate"].ToString());
                    taskAssignModel.TaskAssignCompletionDate = Convert.ToDateTime(dataReader["TaskAssignCompletionDate"].ToString());
                    taskAssignModel.Remarks = dataReader["Remarks"].ToString();
                    taskAssignModel.ProjWiseTaskID = Convert.ToInt32(dataReader["ProjWiseTaskID"]);
                    taskAssignModel.ProjWiseTaskName = dataReader["ProjWiseTaskName"].ToString();
                    taskAssignModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                    taskAssignModel.EmpName= dataReader["EmpName"].ToString();
                    taskAssignModel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                    taskAssignModel.StatusName = dataReader["StatusName"].ToString();
                    taskAssignModel.Created = Convert.ToDateTime(dataReader["Created"].ToString());
                    taskAssignModel.Modified = Convert.ToDateTime(dataReader["Modified"].ToString());
                }
                return taskAssignModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_TaskAssign_deleteByID
        public bool dbo_API_TaskAssign_delete(int TaskAssignID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_DeleteTaskAssign");
                sqlDatabase.AddInParameter(dbCommand, "@TaskAssignID", DbType.Int32, TaskAssignID);
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

        #region Method : dbo.API_TaskAssign_deleteByMultipleID
        public bool dbo_API_TaskAssign_Multiple_delete(string TaskAssignlist)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_TaskAssign_MultiDeleteProcedure");
                sqlDatabase.AddInParameter(dbCommand, "@lstid", DbType.String, TaskAssignlist);
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

        #region Method : dbo.API_TaskAssign_insert
        public bool dbo_API_TaskAssign_insert(TaskAssign TaskAssignModel)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_InsertTaskAssign");
                sqlDatabase.AddInParameter(dbCommand, "@TaskAssignStartDate", SqlDbType.DateTime, TaskAssignModel.TaskAssignStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@TaskAssignCompletionDate", SqlDbType.DateTime, TaskAssignModel.TaskAssignCompletionDate);
                sqlDatabase.AddInParameter(dbCommand, "@Remarks", SqlDbType.VarChar, TaskAssignModel.Remarks);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskID", SqlDbType.Int,TaskAssignModel.ProjWiseTaskID);
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", SqlDbType.Int, TaskAssignModel.EmpID);
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", SqlDbType.Int, TaskAssignModel.StatusID);
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

        #region Method : dbo.API_TaskAssign_Update
        public bool dbo_API_Employee_update(int TaskAssignID, TaskAssign TaskAssignModel)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_UpdateTaskAssign");
                sqlDatabase.AddInParameter(dbCommand, "@TaskAssignID", DbType.Int32, TaskAssignModel.TaskAssignID);
                sqlDatabase.AddInParameter(dbCommand, "@TaskAssignStartDate", SqlDbType.DateTime, TaskAssignModel.TaskAssignStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@TaskAssignCompletionDate", SqlDbType.DateTime, TaskAssignModel.TaskAssignCompletionDate);
                sqlDatabase.AddInParameter(dbCommand, "@Remarks", SqlDbType.VarChar, TaskAssignModel.Remarks);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskID", SqlDbType.Int, TaskAssignModel.ProjWiseTaskID);
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", SqlDbType.Int, TaskAssignModel.EmpID);
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", SqlDbType.Int, TaskAssignModel.StatusID);
                var temp = sqlDatabase.ExecuteNonQuery(dbCommand);
                if (Convert.ToBoolean(temp))
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

        #region Method : dbo.API_TaskAssign_Filter
        public List<TaskAssign> Filter(TaskAssign? TaskAssignModel)
        {
            try
            {
                List<TaskAssign> listOfTaskAssign = new List<TaskAssign>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllTaskAssign");
                sqlDatabase.AddInParameter(dbCommand, "@TaskAssignStartDate", SqlDbType.DateTime, TaskAssignModel?.TaskAssignStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@TaskAssignCompletionDate", SqlDbType.DateTime, TaskAssignModel?.TaskAssignCompletionDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskID", SqlDbType.VarChar, TaskAssignModel?.ProjWiseTaskID);
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", SqlDbType.VarChar, TaskAssignModel?.EmpID);
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", SqlDbType.VarChar, TaskAssignModel?.StatusID);

                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        TaskAssign taskAssignModel = new TaskAssign(); ;
                        taskAssignModel.TaskAssignID = Convert.ToInt32(dataReader["TaskAssignID"]);
                        taskAssignModel.TaskAssignStartDate = Convert.ToDateTime(dataReader["TaskAssignStartDate"].ToString());
                        taskAssignModel.TaskAssignCompletionDate = Convert.ToDateTime(dataReader["TaskAssignCompletionDate"].ToString());
                        taskAssignModel.Remarks = dataReader["Remarks"].ToString();
                        taskAssignModel.ProjWiseTaskID = Convert.ToInt32(dataReader["ProjWiseTaskID"]);
                        taskAssignModel.ProjWiseTaskName = dataReader["ProjWiseTaskName"].ToString();
                        taskAssignModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        taskAssignModel.EmpName = dataReader["EmpName"].ToString();
                        taskAssignModel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                        taskAssignModel.StatusName = dataReader["StatusName"].ToString();
                        taskAssignModel.Created = Convert.ToDateTime(dataReader["Created"].ToString());
                        taskAssignModel.Modified = Convert.ToDateTime(dataReader["Modified"].ToString());
                        listOfTaskAssign.Add(taskAssignModel);
                    }
                }
                return listOfTaskAssign;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #endregion
    }
}
