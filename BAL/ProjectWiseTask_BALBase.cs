using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.BAL
{
    public class ProjectWiseTask_BALBase
    {
        #region Model : ProjectWiseTask

        #region Method : dbo.API_ProjectWiseTask_SelectAll
        public List<ProjectWiseTask> dbo_API_ProjectWiseTaskGetAll()
        {
            try
            {
                ProjectWiseTask_DALBase projectWiseTask_DALBase = new ProjectWiseTask_DALBase();
                List<ProjectWiseTask> ProjectWiseTaskModels = projectWiseTask_DALBase.dbo_API_ProjectWiseTaskGetAll();
                return ProjectWiseTaskModels;
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
                ProjectWiseTask_DALBase projectWiseTask_DALBase  = new ProjectWiseTask_DALBase();
                ProjectWiseTask projectWiseTaskModel = projectWiseTask_DALBase.dbo_API_ProjectWiseTask_SelectByID(ProjWiseTaskID);
                return projectWiseTaskModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_ProjectWiseTask_DeleteByID
        public bool dbo_API_ProjectWiseTask_DeleteByID(int ProjWiseTaskID)
        {
            try
            {
                ProjectWiseTask_DALBase projectWiseTask_DALBase = new ProjectWiseTask_DALBase();
                if (projectWiseTask_DALBase.dbo_API_ProjectWiseTask_delete(ProjWiseTaskID))
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

        #region Method : dbo.API_ProjectWisetask_DeleteByMultipleID
        public bool dbo_API_ProjectWiseTask_Multiple_delete(string ProjectWiselist) 
        {
            try
            {
                ProjectWiseTask_DALBase projectWiseTask_DALBase = new ProjectWiseTask_DALBase();
                if (projectWiseTask_DALBase.dbo_API_ProjectWiseTask_Multiple_delete(ProjectWiselist))
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

        #region Method : dbo.API_ProjectWiseTask_Insert
        public bool dbo_API_ProjectWiseTask_Insert(ProjectWiseTask projectWiseTaskModel)
        {
            try
            {
                ProjectWiseTask_DALBase projectWiseTask_DALBase = new ProjectWiseTask_DALBase();
                if (projectWiseTask_DALBase.dbo_API_ProjectWiseTask_insert(projectWiseTaskModel))
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

        #region Method : dbo.API_ProjectWiseTask_Updateedbyid
        public bool dbo_API_ProjectTaskWise_Update(int ProjWiseTaskID, ProjectWiseTask projectWiseTaskModel)
        {
            try
            {
                ProjectWiseTask_DALBase projectWiseTask_DALBase = new ProjectWiseTask_DALBase();
                if (projectWiseTask_DALBase.dbo_API_ProjectWiseTask_update(ProjWiseTaskID, projectWiseTaskModel))
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

        #region Method : dbo.API_ProjectWiseTask_Filter
        public List<ProjectWiseTask> Filter(ProjectWiseTask? projectWiseTaskModel)
        {
            try
            {
                ProjectWiseTask_DALBase projectWiseTask_DALBase = new ProjectWiseTask_DALBase();
                List<ProjectWiseTask> projectWiseTaskModels = projectWiseTask_DALBase.Filter(projectWiseTaskModel);
                return projectWiseTaskModels;
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
