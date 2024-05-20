using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Project_Management_Admin_Panel.Models;
using System.Data.Common;
using System.Data;
using WebApplication2.DAL;

namespace Project_Management_Admin_Panel.DAL
{
    public class Dashbord_DALBase:Dal_Helper
    {
        #region Model : DashBord

        #region Method : dbo.API_Dashbord_Selectall
        public List<Dashbord> dbo_API_DashbordGetAll() 
        {
            try
            {
                List<Dashbord> listOfdashbordcount = new List<Dashbord>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("API_ALL_Dashboord_COUNTS");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Dashbord dashbord = new Dashbord();
                        dashbord.TotalEmployee = Convert.ToInt32(dataReader["TotalEmployee"]);
                        dashbord.TotalEmployeesWithoutTasks = Convert.ToInt32(dataReader["TotalEmployeesWithoutTasks"]);
                        dashbord.TotalEmployeeAssignedtask = Convert.ToInt32(dataReader["TotalEmployeeAssignedtask"]);
                        dashbord.TotalProject = Convert.ToInt32(dataReader["TotalProject"]);
                        dashbord.TotalUpcomingProject = Convert.ToInt32(dataReader["TotalUpcomingProject"]);
                        dashbord.TotalCurrentProject = Convert.ToInt32(dataReader["TotalCurrentProject"]);
                        dashbord.TotalCompleteProject = Convert.ToInt32(dataReader["TotalCompleteProject"]);
                        listOfdashbordcount.Add(dashbord);
                    }
                }
                return listOfdashbordcount;
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
