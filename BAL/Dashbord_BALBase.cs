using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.BAL
{
    public class Dashbord_BALBase
    {
        #region Model : Dashbord

        #region Method : dbo.API_Dashbord_SelectAll
        public List<Dashbord> dbo_API_DashbordGetAll()
        {
            try
            {
                Dashbord_DALBase dashbord_DALBase = new Dashbord_DALBase();
                List<Dashbord> dashbordModels = dashbord_DALBase.dbo_API_DashbordGetAll();
                return dashbordModels;
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
