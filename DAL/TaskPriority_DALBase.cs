using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Project_Management_Admin_Panel.Models;
using System.Data.Common;
using System.Data;
using WebApplication2.DAL;

namespace Project_Management_Admin_Panel.DAL
{
    public class TaskPriority_DALBase:Dal_Helper
    {
        #region Model : TaskPriority

        #region Method : dbo.API_TaskPriority_Selectall
        public List<TaskPriority> dbo_API_TaskPriorityGetAll()
        {
            try
            {
                List<TaskPriority> listOfTaskPriority = new List<TaskPriority>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllTasks");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        TaskPriority taskPriority = new TaskPriority();
                        taskPriority.TaskPriorityID = Convert.ToInt32(dataReader["TaskPriorityID"]);
                        taskPriority.TaskPriorityName = dataReader["TaskPriorityName"].ToString();
                        taskPriority.TaskPriorityCssColor = dataReader["TaskPriorityCssColor"].ToString();
                        listOfTaskPriority.Add(taskPriority);
                    }
                }
                return listOfTaskPriority;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Method : dbo.API_TaskPriority_SelectByID
        public TaskPriority dbo_API_TaskPriority_SelectByID(int TaskPriorityID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectTaskById");
                sqlDatabase.AddInParameter(dbCommand, "@TaskPriorityID", DbType.Int32, TaskPriorityID);
                TaskPriority taskPriority = new TaskPriority();
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    dataReader.Read();
                    taskPriority.TaskPriorityID = Convert.ToInt32(dataReader["TaskPriorityID"]);
                    taskPriority.TaskPriorityName = dataReader["TaskPriorityName"].ToString();
                    taskPriority.TaskPriorityCssColor = dataReader["TaskPriorityCssColor"].ToString();
                }
                return taskPriority;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_TaskPriority_deleteByID
        public bool dbo_API_TaskPriority_delete(int TaskPriorityID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_DeleteTask");
                sqlDatabase.AddInParameter(dbCommand, "@TaskPriorityID", DbType.Int32, TaskPriorityID);
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

        #region Method : dbo.API_TaskPriority_insert
        public bool dbo_API_TaskPriority_insert(TaskPriority taskPriority)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_InsertTask");
                sqlDatabase.AddInParameter(dbCommand, "@TaskPriorityName", SqlDbType.VarChar, taskPriority.TaskPriorityName);
                sqlDatabase.AddInParameter(dbCommand, "@TaskPriorityCssColor", SqlDbType.VarChar, taskPriority.TaskPriorityCssColor);
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

        #region Method : dbo.API_TaskPriority_Update
        public bool dbo_API_TaskPriority_update(int TaskPriorityID, TaskPriority taskPriority)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_UpdateTask");
                sqlDatabase.AddInParameter(dbCommand, "@TaskPriorityID", SqlDbType.Int, taskPriority.TaskPriorityID);
                sqlDatabase.AddInParameter(dbCommand, "@TaskPriorityName", SqlDbType.VarChar, taskPriority.TaskPriorityName);
                sqlDatabase.AddInParameter(dbCommand, "@TaskPriorityCssColor", SqlDbType.VarChar, taskPriority.TaskPriorityCssColor);
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
