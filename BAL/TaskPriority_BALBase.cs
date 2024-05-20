using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.BAL
{
    public class TaskPriority_BALBase
    {
        #region Model : TaskPriority
        #region Method : dbo.API_TaskPriority_SelectAll
        public List<TaskPriority> dbo_API_TaskPriorityGetAll()
        {
            try
            {
                TaskPriority_DALBase taskPriority_DALBase = new TaskPriority_DALBase();
                List<TaskPriority> taskPriority = taskPriority_DALBase.dbo_API_TaskPriorityGetAll();
                return taskPriority; 
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
                TaskPriority_DALBase taskPriority_DALBase = new TaskPriority_DALBase();
                TaskPriority taskPriority = taskPriority_DALBase.dbo_API_TaskPriority_SelectByID(TaskPriorityID);
                return taskPriority;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_TaskPriority_DeleteByID
        public bool dbo_API_TaskPriority_DeleteByID(int TaskPriorityID)
        {
            try
            {
                TaskPriority_DALBase taskPriority_DALBase = new TaskPriority_DALBase();
                if (taskPriority_DALBase.dbo_API_TaskPriority_delete(TaskPriorityID))
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

        #region Method : dbo.API_TaskPriority_Insert
        public bool dbo_API_TaskPriority_Insert(TaskPriority taskPriority)
        {
            try
            {
                TaskPriority_DALBase taskPriority_DALBase = new TaskPriority_DALBase();
                if (taskPriority_DALBase.dbo_API_TaskPriority_insert(taskPriority))
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

        #region Method : dbo.API_TaskPriority_Updateedbyid
        public bool dbo_API_TaskPriority_Update(int TaskPriorityID, TaskPriority taskPriority)
        {
            try
            {
                TaskPriority_DALBase taskPriority_DALBase = new TaskPriority_DALBase();
                if (taskPriority_DALBase.dbo_API_TaskPriority_update(TaskPriorityID,taskPriority))
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
        #endregion
    }
}
