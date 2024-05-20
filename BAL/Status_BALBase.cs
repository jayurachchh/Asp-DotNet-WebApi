using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.BAL
{
    public class Status_BALBase
    {
        #region Model : Status
        #region Method : dbo.API_Status_SelectAll
        public List<StatusModel> dbo_API_StatusGetAll()
        {
            try
            {
                Status_DALBase status_DALBase = new Status_DALBase();
                List<StatusModel> statusModels = status_DALBase.dbo_API_StatusGetAll();
                return statusModels;
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
                Status_DALBase status_DALBase = new Status_DALBase();
                StatusModel statusModels = status_DALBase.dbo_API_Status_SelectByID(StatusID);
                return statusModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Status_DeleteByID
        public bool dbo_API_Status_DeleteByID(int StatusID)
        {
            try
            {
                Status_DALBase status_DALBase = new Status_DALBase();
                if (status_DALBase.dbo_API_Status_delete(StatusID))
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

        #region Method : dbo.API_Employee_Insert
        public bool dbo_API_Employee_Insert(StatusModel statusModel)
        {
            try
            {
                Status_DALBase status_DALBase = new Status_DALBase();
                if (status_DALBase.dbo_API_Status_insert(statusModel))
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

        #region Method : dbo.API_Status_Updateedbyid
        public bool dbo_API_Status_Update(int StatusID, StatusModel statusModel)
        {
            try
            {
                Status_DALBase status_DALBase = new Status_DALBase();
                if (status_DALBase.dbo_API_Status_update(StatusID,statusModel))
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
