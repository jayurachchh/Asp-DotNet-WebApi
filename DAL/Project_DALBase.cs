using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Project_Management_Admin_Panel.Models;
using System.Data.Common;
using System.Data;
using WebApplication2.DAL;

namespace Project_Management_Admin_Panel.DAL
{
    public class Project_DALBase:Dal_Helper
    {
        #region Model:Project

        #region Method : dbo.API_Project_Selectall
        public List<Project> dbo_API_ProjectGetAll()
        {
            try
            {
                List<Project> listOfproject = new List<Project>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllProjects");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Project projectModel = new Project();
                        projectModel.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                        projectModel.ProjName = dataReader["ProjName"].ToString();
                        projectModel.ProjDescription = dataReader["ProjDescription"].ToString();
                        projectModel.ProjStartDate =Convert.ToDateTime(dataReader["ProjStartDate"].ToString());
                        projectModel.ProjEndDate = Convert.ToDateTime(dataReader["ProjEndDate"].ToString());
                        projectModel.ProjTotalCost = dataReader["ProjTotalCost"].ToString();
                        projectModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        projectModel.EmpName = dataReader["EmpName"].ToString();
                        projectModel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                        projectModel.StatusName = dataReader["StatusName"].ToString();
                        projectModel.StatusCssColor = dataReader["StatusCssColor"].ToString();
                        projectModel.ProjSource = dataReader["ProjSource"].ToString();
                        projectModel.ProjDocumentation = dataReader["ProjDocumentation"].ToString();
                        projectModel.Created = Convert.ToDateTime(dataReader["ProjCreated"].ToString());
                        projectModel.Modified = Convert.ToDateTime(dataReader["Projmodified"].ToString());
                        listOfproject.Add(projectModel);
                    }
                }
                return listOfproject;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Method : dbo.API_Project_SelectallUpcoming
        public List<Project> dbo_API_ProjectGetAllUpcoming()
        {
            try
            {
                List<Project> listOfproject = new List<Project>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllUpcomingProjects");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Project projectModel = new Project();
                        projectModel.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                        projectModel.ProjName = dataReader["ProjName"].ToString();
                        projectModel.ProjDescription = dataReader["ProjDescription"].ToString();
                        projectModel.ProjStartDate = Convert.ToDateTime(dataReader["ProjStartDate"].ToString());
                        projectModel.ProjEndDate = Convert.ToDateTime(dataReader["ProjEndDate"].ToString());
                        projectModel.ProjTotalCost = dataReader["ProjTotalCost"].ToString();
                        projectModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        projectModel.EmpName = dataReader["EmpName"].ToString();
                        projectModel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                        projectModel.StatusName = dataReader["StatusName"].ToString();
                        projectModel.StatusCssColor = dataReader["StatusCssColor"].ToString();
                        projectModel.ProjSource = dataReader["ProjSource"].ToString();
                        projectModel.ProjDocumentation = dataReader["ProjDocumentation"].ToString();
                        projectModel.Created = Convert.ToDateTime(dataReader["ProjCreated"].ToString());
                        projectModel.Modified = Convert.ToDateTime(dataReader["Projmodified"].ToString());
                        listOfproject.Add(projectModel);
                    }
                }
                return listOfproject;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Method : dbo.API_Project_SelectallCurrent
        public List<Project> dbo_API_ProjectGetAllCurrent()
        {
            try
            {
                List<Project> listOfproject = new List<Project>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllCurrentProjects");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Project projectModel = new Project();
                        projectModel.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                        projectModel.ProjName = dataReader["ProjName"].ToString();
                        projectModel.ProjDescription = dataReader["ProjDescription"].ToString();
                        projectModel.ProjStartDate = Convert.ToDateTime(dataReader["ProjStartDate"].ToString());
                        projectModel.ProjEndDate = Convert.ToDateTime(dataReader["ProjEndDate"].ToString());
                        projectModel.ProjTotalCost = dataReader["ProjTotalCost"].ToString();
                        projectModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        projectModel.EmpName = dataReader["EmpName"].ToString();
                        projectModel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                        projectModel.StatusName = dataReader["StatusName"].ToString();
                        projectModel.StatusCssColor = dataReader["StatusCssColor"].ToString();
                        projectModel.ProjSource = dataReader["ProjSource"].ToString();
                        projectModel.ProjDocumentation = dataReader["ProjDocumentation"].ToString();
                        projectModel.Created = Convert.ToDateTime(dataReader["ProjCreated"].ToString());
                        projectModel.Modified = Convert.ToDateTime(dataReader["Projmodified"].ToString());
                        listOfproject.Add(projectModel);
                    }
                }
                return listOfproject;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Method : dbo.API_Project_SelectallComplete
        public List<Project> dbo_API_ProjectGetAllComplete()
        {
            try
            {
                List<Project> listOfproject = new List<Project>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllCompleteProjects");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Project projectModel = new Project();
                        projectModel.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                        projectModel.ProjName = dataReader["ProjName"].ToString();
                        projectModel.ProjDescription = dataReader["ProjDescription"].ToString();
                        projectModel.ProjStartDate = Convert.ToDateTime(dataReader["ProjStartDate"].ToString());
                        projectModel.ProjEndDate = Convert.ToDateTime(dataReader["ProjEndDate"].ToString());
                        projectModel.ProjTotalCost = dataReader["ProjTotalCost"].ToString();
                        projectModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        projectModel.EmpName = dataReader["EmpName"].ToString();
                        projectModel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                        projectModel.StatusName = dataReader["StatusName"].ToString();
                        projectModel.StatusCssColor = dataReader["StatusCssColor"].ToString();
                        projectModel.ProjSource = dataReader["ProjSource"].ToString();
                        projectModel.ProjDocumentation = dataReader["ProjDocumentation"].ToString();
                        projectModel.Created = Convert.ToDateTime(dataReader["ProjCreated"].ToString());
                        projectModel.Modified = Convert.ToDateTime(dataReader["Projmodified"].ToString());
                        listOfproject.Add(projectModel);
                    }
                }
                return listOfproject;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        #region Method : dbo.API_Project_SelectByID
        public Project dbo_API_Project_SelectByID(int ProjID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectProjectById");
                sqlDatabase.AddInParameter(dbCommand, "@ProjID", DbType.Int32, ProjID);
                Project projectModel = new Project();
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    dataReader.Read();
                    projectModel.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                    projectModel.ProjName = dataReader["ProjName"].ToString();
                    projectModel.ProjDescription = dataReader["ProjDescription"].ToString();
                    projectModel.ProjStartDate = Convert.ToDateTime(dataReader["ProjStartDate"].ToString());
                    projectModel.ProjEndDate = Convert.ToDateTime(dataReader["ProjEndDate"].ToString());
                    projectModel.ProjTotalCost = dataReader["ProjTotalCost"].ToString();
                    projectModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                    projectModel.EmpName = dataReader["EmpName"].ToString();
                    projectModel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                    projectModel.StatusName = dataReader["StatusName"].ToString();
                    projectModel.ProjSource = dataReader["ProjSource"].ToString();
                    projectModel.ProjDocumentation = dataReader["ProjDocumentation"].ToString();
                    projectModel.Created = Convert.ToDateTime(dataReader["ProjCreated"].ToString());
                    projectModel.Modified = Convert.ToDateTime(dataReader["Projmodified"].ToString());
                }
                return projectModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Project_deleteByID
        public bool dbo_API_Project_delete(int ProjID) 
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_DeleteProject");
                sqlDatabase.AddInParameter(dbCommand, "@ProjID", DbType.Int32, ProjID);
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

        #region Method : dbo.API_Project_deleteByMultipleID
        public bool dbo_API_Project_Multiple_delete(string Projectlist)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_Project_MultiDeleteProcedure");
                sqlDatabase.AddInParameter(dbCommand, "@lstid", DbType.String, Projectlist);
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

        #region Method : dbo.API_Project_insert
        public bool dbo_API_Project_insert(Project projectModel)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_InsertProject");
                sqlDatabase.AddInParameter(dbCommand, "@ProjName", SqlDbType.VarChar,projectModel.ProjName);
                sqlDatabase.AddInParameter(dbCommand, "@ProjDescription", SqlDbType.VarChar, projectModel.ProjDescription);
                sqlDatabase.AddInParameter(dbCommand, "@ProjStartDate", SqlDbType.DateTime, projectModel.ProjStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjEndDate", SqlDbType.DateTime, projectModel.ProjEndDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjTotalCost", SqlDbType.Float, projectModel.ProjTotalCost);
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", SqlDbType.Int, projectModel.EmpID);
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", SqlDbType.Int, projectModel.StatusID);
                sqlDatabase.AddInParameter(dbCommand, "@ProjSource", SqlDbType.VarChar,projectModel.ProjSource);
                sqlDatabase.AddInParameter(dbCommand, "@ProjDocumentation", SqlDbType.VarChar,projectModel.ProjDocumentation);
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

        #region Method : dbo.API_Project_Update
        public bool dbo_API_Project_update(int ProjID, Project projectModel)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_UpdateProject");
                sqlDatabase.AddInParameter(dbCommand, "@ProjID", SqlDbType.Int, projectModel.ProjID); 
                sqlDatabase.AddInParameter(dbCommand, "@ProjName", SqlDbType.VarChar, projectModel.ProjName);
                sqlDatabase.AddInParameter(dbCommand, "@ProjDescription", SqlDbType.VarChar, projectModel.ProjDescription);
                sqlDatabase.AddInParameter(dbCommand, "@ProjStartDate", SqlDbType.DateTime, projectModel.ProjStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjEndDate", SqlDbType.DateTime, projectModel.ProjEndDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjTotalCost", SqlDbType.Float, projectModel.ProjTotalCost);
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", SqlDbType.Int, projectModel.EmpID);
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", SqlDbType.Int, projectModel.StatusID);
                sqlDatabase.AddInParameter(dbCommand, "@ProjSource", SqlDbType.VarChar, projectModel.ProjSource);
                sqlDatabase.AddInParameter(dbCommand, "@ProjDocumentation", SqlDbType.VarChar, projectModel.ProjDocumentation);
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

        #region Method : dbo.API_Project_Filter
        public List<Project> Filter(Project? projectModel)
        {
            try
            {
                List<Project> listofproject = new List<Project>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllProjects");

                sqlDatabase.AddInParameter(dbCommand, "@ProjName", SqlDbType.VarChar, projectModel?.ProjName);
                sqlDatabase.AddInParameter(dbCommand, "@ProjStartDate", SqlDbType.DateTime, projectModel?.ProjStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjEndDate", SqlDbType.DateTime, projectModel?.ProjEndDate);
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", SqlDbType.VarChar, projectModel?.EmpID);
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", SqlDbType.VarChar, projectModel?.StatusID);
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Project projectmodel = new Project();
                        projectmodel.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                        projectmodel.ProjName = dataReader["ProjName"].ToString();
                        projectmodel.ProjDescription = dataReader["ProjDescription"].ToString();
                        projectmodel.ProjStartDate = Convert.ToDateTime(dataReader["ProjStartDate"].ToString());
                        projectmodel.ProjEndDate = Convert.ToDateTime(dataReader["ProjEndDate"].ToString());
                        projectmodel.ProjTotalCost = dataReader["ProjTotalCost"].ToString();
                        projectmodel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        projectmodel.EmpName = dataReader["EmpName"].ToString();
                        projectmodel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                        projectmodel.StatusName = dataReader["StatusName"].ToString();
                        projectmodel.ProjSource = dataReader["ProjSource"].ToString();
                        projectmodel.ProjDocumentation = dataReader["ProjDocumentation"].ToString();
                        projectmodel.Created = Convert.ToDateTime(dataReader["ProjCreated"].ToString());
                        projectmodel.Modified = Convert.ToDateTime(dataReader["ProjModified"].ToString());
                        listofproject.Add(projectmodel);
                    }
                }
                return listofproject;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_ProjectUpcoming_Filter
        public List<Project> FilterUpcoming(Project? projectModel)
        {
            try
            {
                List<Project> listofproject = new List<Project>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllUpcomingProjects");

                sqlDatabase.AddInParameter(dbCommand, "@ProjName", SqlDbType.VarChar, projectModel?.ProjName);
                sqlDatabase.AddInParameter(dbCommand, "@ProjStartDate", SqlDbType.DateTime, projectModel?.ProjStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjEndDate", SqlDbType.DateTime, projectModel?.ProjEndDate);
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", SqlDbType.VarChar, projectModel?.EmpID);
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", SqlDbType.VarChar, projectModel?.StatusID);
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Project projectmodel = new Project();
                        projectmodel.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                        projectmodel.ProjName = dataReader["ProjName"].ToString();
                        projectmodel.ProjDescription = dataReader["ProjDescription"].ToString();
                        projectmodel.ProjStartDate = Convert.ToDateTime(dataReader["ProjStartDate"].ToString());
                        projectmodel.ProjEndDate = Convert.ToDateTime(dataReader["ProjEndDate"].ToString());
                        projectmodel.ProjTotalCost = dataReader["ProjTotalCost"].ToString();
                        projectmodel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        projectmodel.EmpName = dataReader["EmpName"].ToString();
                        projectmodel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                        projectmodel.StatusName = dataReader["StatusName"].ToString();
                        projectmodel.ProjSource = dataReader["ProjSource"].ToString();
                        projectmodel.ProjDocumentation = dataReader["ProjDocumentation"].ToString();
                        projectmodel.Created = Convert.ToDateTime(dataReader["ProjCreated"].ToString());
                        projectmodel.Modified = Convert.ToDateTime(dataReader["ProjModified"].ToString());
                        listofproject.Add(projectmodel);
                    }
                }
                return listofproject;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_ProjectCurrent_Filter
        public List<Project> FilterCurrent(Project? projectModel)
        {
            try
            {
                List<Project> listofproject = new List<Project>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllCurrentProjects");

                sqlDatabase.AddInParameter(dbCommand, "@ProjName", SqlDbType.VarChar, projectModel?.ProjName);
                sqlDatabase.AddInParameter(dbCommand, "@ProjStartDate", SqlDbType.DateTime, projectModel?.ProjStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjEndDate", SqlDbType.DateTime, projectModel?.ProjEndDate);
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", SqlDbType.VarChar, projectModel?.EmpID);
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", SqlDbType.VarChar, projectModel?.StatusID);
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Project projectmodel = new Project();
                        projectmodel.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                        projectmodel.ProjName = dataReader["ProjName"].ToString();
                        projectmodel.ProjDescription = dataReader["ProjDescription"].ToString();
                        projectmodel.ProjStartDate = Convert.ToDateTime(dataReader["ProjStartDate"].ToString());
                        projectmodel.ProjEndDate = Convert.ToDateTime(dataReader["ProjEndDate"].ToString());
                        projectmodel.ProjTotalCost = dataReader["ProjTotalCost"].ToString();
                        projectmodel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        projectmodel.EmpName = dataReader["EmpName"].ToString();
                        projectmodel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                        projectmodel.StatusName = dataReader["StatusName"].ToString();
                        projectmodel.ProjSource = dataReader["ProjSource"].ToString();
                        projectmodel.ProjDocumentation = dataReader["ProjDocumentation"].ToString();
                        projectmodel.Created = Convert.ToDateTime(dataReader["ProjCreated"].ToString());
                        projectmodel.Modified = Convert.ToDateTime(dataReader["ProjModified"].ToString());
                        listofproject.Add(projectmodel);
                    }
                }
                return listofproject;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_ProjectComplete_Filter
        public List<Project> FilterComplete(Project? projectModel)
        {
            try
            {
                List<Project> listofproject = new List<Project>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllCompleteProjects");

                sqlDatabase.AddInParameter(dbCommand, "@ProjName", SqlDbType.VarChar, projectModel?.ProjName);
                sqlDatabase.AddInParameter(dbCommand, "@ProjStartDate", SqlDbType.DateTime, projectModel?.ProjStartDate);
                sqlDatabase.AddInParameter(dbCommand, "@ProjEndDate", SqlDbType.DateTime, projectModel?.ProjEndDate);
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", SqlDbType.VarChar, projectModel?.EmpID);
                sqlDatabase.AddInParameter(dbCommand, "@StatusID", SqlDbType.VarChar, projectModel?.StatusID);
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Project projectmodel = new Project();
                        projectmodel.ProjID = Convert.ToInt32(dataReader["ProjID"]);
                        projectmodel.ProjName = dataReader["ProjName"].ToString();
                        projectmodel.ProjDescription = dataReader["ProjDescription"].ToString();
                        projectmodel.ProjStartDate = Convert.ToDateTime(dataReader["ProjStartDate"].ToString());
                        projectmodel.ProjEndDate = Convert.ToDateTime(dataReader["ProjEndDate"].ToString());
                        projectmodel.ProjTotalCost = dataReader["ProjTotalCost"].ToString();
                        projectmodel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        projectmodel.EmpName = dataReader["EmpName"].ToString();
                        projectmodel.StatusID = Convert.ToInt32(dataReader["StatusID"]);
                        projectmodel.StatusName = dataReader["StatusName"].ToString();
                        projectmodel.ProjSource = dataReader["ProjSource"].ToString();
                        projectmodel.ProjDocumentation = dataReader["ProjDocumentation"].ToString();
                        projectmodel.Created = Convert.ToDateTime(dataReader["ProjCreated"].ToString());
                        projectmodel.Modified = Convert.ToDateTime(dataReader["ProjModified"].ToString());
                        listofproject.Add(projectmodel);
                    }
                }
                return listofproject;
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
