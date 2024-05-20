using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;
using System.Linq.Expressions;

namespace Project_Management_Admin_Panel.BAL
{
    public class TaskAssign_BALBase
    {
        #region Model:TaskAssign

        #region Method : dbo.API_TaskAssign_SelectAll
        public List<TaskAssign> dbo_API_TaskAssignGetAll()
        {
            try
            {
                TaskAssign_DALBase taskAssign_DALBase = new TaskAssign_DALBase();   
                List<TaskAssign> TaskAssignModels = taskAssign_DALBase.dbo_API_TaskAssignGetAll();
                return TaskAssignModels;
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
                TaskAssign_DALBase taskAssign_DALBase = new TaskAssign_DALBase();
                TaskAssign TaskAssignModel = taskAssign_DALBase.dbo_API_TaskAssign_SelectByID(TaskAssignID);
                return TaskAssignModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_TaskAssign_DeleteByID
        public bool dbo_API_TaskAssign_DeleteByID(int TaskAssignID)
        {
            try
            {
                TaskAssign_DALBase taskAssign_DALBase = new TaskAssign_DALBase();
                if (taskAssign_DALBase.dbo_API_TaskAssign_delete(TaskAssignID))
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

        #region Method : dbo.API_TaskAssign_DeleteByMultipleID
        public bool dbo_API_TaskAssign_Multiple_delete(string TaskAssignlist)
        {
            try
            {
                TaskAssign_DALBase taskAssign_DALBase = new TaskAssign_DALBase();
                if (taskAssign_DALBase.dbo_API_TaskAssign_Multiple_delete(TaskAssignlist))
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

        #region Method : dbo.API_TaskAssign_Insert
        public bool dbo_API_TaskAssign_Insert(TaskAssign TaskAssignModel)
        {
            try
            {
                TaskAssign_DALBase taskAssign_DALBase = new TaskAssign_DALBase();
                if (taskAssign_DALBase.dbo_API_TaskAssign_insert(TaskAssignModel))
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

        #region Method : dbo.API_TaskAssign_Updateedbyid
        public bool dbo_API_TaskAssign_Update(int TaskAssignID, TaskAssign TaskAssignModel)
        {
            try
            {
                TaskAssign_DALBase taskAssign_DALBase = new TaskAssign_DALBase();
                if (taskAssign_DALBase.dbo_API_Employee_update(TaskAssignID, TaskAssignModel))
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

        #region Method : dbo.API_TaskAssign_Filter
        public List<TaskAssign> Filter(TaskAssign? taskAssignModel)
        {
            try
            {
                TaskAssign_DALBase taskAssign_DALBase = new TaskAssign_DALBase();
                List<TaskAssign> taskAssignModels = taskAssign_DALBase.Filter(taskAssignModel);
                return taskAssignModels;
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
