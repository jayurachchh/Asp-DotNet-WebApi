using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Project_Management_Admin_Panel.Models;
using System.Data.Common;
using System.Data;
using WebApplication2.DAL;

namespace Project_Management_Admin_Panel.DAL
{
    public class ProjectWiseTask_DALBase:Dal_Helper
    {
        #region Model : ProjectWiseTask

        #region Method : dbo.API_ProjectWiseTask_Selectall
        public List<ProjectWiseTask> dbo_API_ProjectWiseTaskGetAll()
        {
            try
            {
                List<ProjectWiseTask> listOfProjectWiseTask = new List<ProjectWiseTask>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllProjWiseTasks");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        ProjectWiseTask projectWiseTaskModel = new ProjectWiseTask();
                        projectWiseTaskModel.ProjWiseTaskID = Convert.ToInt32(dataReader["ProjWiseTaskID"]);
                        projectWiseTaskModel.ProjID= Convert.ToInt32(dataReader["ProjID"]);
                        projectWiseTaskModel.ProjName = dataReader["ProjName"].ToString();
                        projectWiseTaskModel.ProjWiseTaskName = dataReader["ProjWiseTaskName"].ToString();
                        projectWiseTaskModel.ProjWiseTaskNumber = dataReader["ProjWiseTaskNumber"].ToString();
                        projectWiseTaskModel.ProjWiseTaskStartDate = Convert.ToDateTime(dataReader["ProjWiseTaskStartDate"].ToString());
                        projectWiseTaskModel.ProjWiseTaskEndDate= Convert.ToDateTime(dataReader["ProjWiseTaskEndDate"].ToString());
                        projectWiseTaskModel.ProjectWiseTaskEmployeeNumber = Convert.ToInt32(dataReader["ProjectWiseTaskEmployeeNumber"]);
                        projectWiseTaskModel.Created = Convert.ToDateTime(dataReader["Created"].ToString());
                        projectWiseTaskModel.Modified = Convert.ToDateTime(dataReader["Modified"].ToString());
                        listOfProjectWiseTask.Add(projectWiseTaskModel);
                    }
                }
                return listOfProjectWiseTask;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Method : dbo.API_ProjectWiseTask_SelectByID
        public ProjectWiseTask dbo_API_ProjectWiseTask_SelectByID(int ProjWiseTaskID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectProjWiseTaskById");
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskID", DbType.Int32, ProjWiseTaskID);
                ProjectWiseTask projectWiseTaskModel = new ProjectWiseTask();
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    dataReader.Read();
                    projectWiseTaskModel.ProjWiseTaskID = Convert.ToInt32(dataReader["ProjWiseTaskID"]);
                    projectWiseTaskModel.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                    projectWiseTaskModel.ProjName = dataReader["ProjName"].ToString();
                    projectWiseTaskModel.ProjWiseTaskName = dataReader["ProjWiseTaskName"].ToString();
                    projectWiseTaskModel.ProjWiseTaskNumber = dataReader["ProjWiseTaskNumber"].ToString();
                    projectWiseTaskModel.ProjWiseTaskStartDate = Convert.ToDateTime(dataReader["ProjWiseTaskStartDate"].ToString());
                    projectWiseTaskModel.ProjWiseTaskEndDate = Convert.ToDateTime(dataReader["ProjWiseTaskEndDate"].ToString());
                    projectWiseTaskModel.ProjectWiseTaskEmployeeNumber = Convert.ToInt32(dataReader["ProjectWiseTaskEmployeeNumber"]);
                    projectWiseTaskModel.Created = Convert.ToDateTime(dataReader["Created"].ToString());
                    projectWiseTaskModel.Modified = Convert.ToDateTime(dataReader["Modified"].ToString());
                }
                return projectWiseTaskModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_ProjectWiseTask_deleteByID
        public bool dbo_API_ProjectWiseTask_delete(int ProjWiseTaskID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_DeleteProjWiseTask");
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskID", DbType.Int32, ProjWiseTaskID);
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
         
        #region Method : dbo.API_ProjectWiseTask_deleteByMultipleID
        public bool dbo_API_ProjectWiseTask_Multiple_delete(string ProjectWisetasklist)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_ProjectWiseTask_MultiDeleteProcedure");
                sqlDatabase.AddInParameter(dbCommand, "@lstid", DbType.String, ProjectWisetasklist);
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

        #region Method : dbo.API_ProjectWiseTask_insert
        public bool dbo_API_ProjectWiseTask_insert(ProjectWiseTask projectWiseTaskModel)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_InsertProjWiseTask");
                sqlDatabase.AddInParameter(dbCommand, "@ProjID", SqlDbType.Int, projectWiseTaskModel.ProjID);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskNumber", SqlDbType.VarChar, projectWiseTaskModel.ProjWiseTaskNumber);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskName", SqlDbType.VarChar, projectWiseTaskModel.ProjWiseTaskName);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskStartDate", SqlDbType.DateTime, projectWiseTaskModel.ProjWiseTaskStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskEndDate", SqlDbType.DateTime, projectWiseTaskModel.ProjWiseTaskEndDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjectWiseTaskEmployeeNumber", SqlDbType.Int, projectWiseTaskModel.ProjectWiseTaskEmployeeNumber);
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

        #region Method : dbo.API_ProjectWiseTask_Update
        public bool dbo_API_ProjectWiseTask_update(int ProjWiseTaskID, ProjectWiseTask projectWiseTaskModel)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_UpdateProjWiseTask");
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskID", SqlDbType.Int, projectWiseTaskModel.ProjWiseTaskID);
                sqlDatabase.AddInParameter(dbCommand, "@ProjID", SqlDbType.Int, projectWiseTaskModel.ProjID);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskNumber", SqlDbType.VarChar, projectWiseTaskModel.ProjWiseTaskNumber);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskName", SqlDbType.VarChar, projectWiseTaskModel.ProjWiseTaskName);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskStartDate", SqlDbType.DateTime, projectWiseTaskModel.ProjWiseTaskStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskEndDate", SqlDbType.DateTime, projectWiseTaskModel.ProjWiseTaskEndDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjectWiseTaskEmployeeNumber", SqlDbType.Int, projectWiseTaskModel.ProjectWiseTaskEmployeeNumber);
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

        #region Method : dbo.API_ProjectWiseTask_Filter
        public List<ProjectWiseTask> Filter(ProjectWiseTask? projectWiseTaskModel)
        {
            try
            {
                List<ProjectWiseTask> listofprojectWiseTask = new List<ProjectWiseTask>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllProjWiseTasks");

                sqlDatabase.AddInParameter(dbCommand, "@ProjID", SqlDbType.VarChar, projectWiseTaskModel?.ProjID);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskName", SqlDbType.VarChar, projectWiseTaskModel?.ProjWiseTaskName);
/*                sqlDatabase.AddInParameter(dbCommand, "@ProjectWiseTaskEmployeeNumber", SqlDbType.VarChar, projectWiseTaskModel?.ProjectWiseTaskEmployeeNumber);*/
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskNumber", SqlDbType.VarChar, projectWiseTaskModel?.ProjWiseTaskNumber);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskStartDate", SqlDbType.DateTime, projectWiseTaskModel?.ProjWiseTaskStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjWiseTaskEndDate", SqlDbType.DateTime, projectWiseTaskModel?.ProjWiseTaskEndDate);

                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        ProjectWiseTask projectWiseTask = new ProjectWiseTask();
                        projectWiseTask.ProjWiseTaskID = Convert.ToInt32(dataReader["ProjWiseTaskID"]);
                        projectWiseTask.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                        projectWiseTask.ProjName = dataReader["ProjName"].ToString();
                        projectWiseTask.ProjWiseTaskName = dataReader["ProjWiseTaskName"].ToString();
                        projectWiseTask.ProjWiseTaskNumber = dataReader["ProjWiseTaskNumber"].ToString();
                        projectWiseTask.ProjWiseTaskStartDate = Convert.ToDateTime(dataReader["ProjWiseTaskStartDate"].ToString());
                        projectWiseTask.ProjWiseTaskEndDate = Convert.ToDateTime(dataReader["ProjWiseTaskEndDate"].ToString());
                        projectWiseTask.ProjectWiseTaskEmployeeNumber = Convert.ToInt32(dataReader["ProjectWiseTaskEmployeeNumber"]);
                        projectWiseTask.Created = Convert.ToDateTime(dataReader["Created"].ToString());
                        projectWiseTask.Modified = Convert.ToDateTime(dataReader["Modified"].ToString());
                        listofprojectWiseTask.Add(projectWiseTask);
                    }
                }
                return listofprojectWiseTask;
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
