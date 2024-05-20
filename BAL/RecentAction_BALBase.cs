using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.BAL
{
    public class RecentAction_BALBase
    {
        #region Model : RecentAction

        #region Method : dbo.API_RecentAction_SelectAll
        public List<RecentAction> dbo_API_RecentActionGetAll()
        {
            try
            {
                RecentAction_DALBase recentAction_DAL = new RecentAction_DALBase();
                List<RecentAction> recentActions = recentAction_DAL.dbo_API_RecentActionGetAll();
                return recentActions;
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
