using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Project_Management_Admin_Panel.Models;
using System.Data.Common;
using System.Data;
using WebApplication2.DAL;

namespace Project_Management_Admin_Panel.DAL
{
    public class RecentAction_DALBase:Dal_Helper
    {
        #region Model : RecentAction

        #region Method : dbo.API_RecentAction_Selectall
        public List<RecentAction> dbo_API_RecentActionGetAll()
        {
            try
            {
                List<RecentAction> listOfrecentaction = new List<RecentAction>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllRecentAction");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        RecentAction recentAction = new RecentAction();
                        recentAction.Rec_Act_Id = Convert.ToInt32(dataReader[0]);
                        recentAction.Rec_Act_Table_Name = dataReader[1].ToString();
                        recentAction.Rec_Act_Info = dataReader[2].ToString();
                        recentAction.Rec_Act_Create = Convert.ToDateTime(dataReader[3].ToString());
                        listOfrecentaction.Add(recentAction);
                    }
                }
                return listOfrecentaction;
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
