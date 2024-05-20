using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.BAL
{
    public class Project_BALBase
    {
        #region Model: Project
        #region Method : dbo.API_Project_SelectAll
        public List<Project> dbo_API_ProjectGetAll()
        {
            try
            {
                Project_DALBase project_DALBase = new Project_DALBase();
                List<Project> projectModels  = project_DALBase.dbo_API_ProjectGetAll();
                return projectModels; 
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Project_SelectAllUpcoming
        public List<Project> dbo_API_ProjectGetAllUpcoming()
        {
            try
            {
                Project_DALBase project_DALBase = new Project_DALBase();
                List<Project> projectModels = project_DALBase.dbo_API_ProjectGetAllUpcoming();
                return projectModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Project_SelectAllCurrent
        public List<Project> dbo_API_ProjectGetAllCurrent()
        {
            try
            {
                Project_DALBase project_DALBase = new Project_DALBase();
                List<Project> projectModels = project_DALBase.dbo_API_ProjectGetAllCurrent();
                return projectModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Project_SelectAllComplete
        public List<Project> dbo_API_ProjectGetAllComplete()
        {
            try
            {
                Project_DALBase project_DALBase = new Project_DALBase();
                List<Project> projectModels = project_DALBase.dbo_API_ProjectGetAllComplete();
                return projectModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Project_SelectByID
        public Project dbo_API_Employee_SelectByID(int ProjID)
        {
            try
            {
                Project_DALBase project_DALBase = new Project_DALBase();
                Project ProjectModel = project_DALBase.dbo_API_Project_SelectByID(ProjID);
                return ProjectModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Project_DeleteByID
        public bool dbo_API_Project_DeleteByID(int ProjID)
        {
            try
            {
                Project_DALBase project_DALBase = new Project_DALBase();
                if (project_DALBase.dbo_API_Project_delete(ProjID)) 
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

        #region Method : dbo.API_Project_DeleteByMultipleID
        public bool dbo_API_Project_Multiple_delete(string Projectlist)
        {
            try
            {
                Project_DALBase project_DALBase = new Project_DALBase();
                if (project_DALBase.dbo_API_Project_Multiple_delete(Projectlist))
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

        #region Method : dbo.API_Project_Insert
        public bool dbo_API_Project_Insert(Project projectModel)
        {
            try
            {
                Project_DALBase project_DALBase = new Project_DALBase();
                if (project_DALBase.dbo_API_Project_insert(projectModel))
                {
                    return true;
                }
                else
                { return false; }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Method : dbo.API_Project_Updateedbyid
        public bool dbo_API_Project_Update(int ProjID,  Project projectModel)
        {
            try
            {
                Project_DALBase project_DALBase = new Project_DALBase();
                if (project_DALBase.dbo_API_Project_update(ProjID,projectModel))
                {
                    return true;
                }
                else
                { return false; }

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
                Project_DALBase project_DALBase = new Project_DALBase();
                List<Project> projectModels = project_DALBase.Filter(projectModel);
                return projectModels;
            }
            catch (Exception ex)
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
                Project_DALBase project_DALBase = new Project_DALBase();
                List<Project> projectModels = project_DALBase.FilterUpcoming(projectModel);
                return projectModels;
            }
            catch (Exception ex)
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
                Project_DALBase project_DALBase = new Project_DALBase();
                List<Project> projectModels = project_DALBase.FilterCurrent(projectModel);
                return projectModels;
            }
            catch (Exception ex)
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
                Project_DALBase project_DALBase = new Project_DALBase();
                List<Project> projectModels = project_DALBase.FilterComplete(projectModel);
                return projectModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
        #endregion
    }
}
