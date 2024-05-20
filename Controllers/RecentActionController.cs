using Microsoft.AspNetCore.Mvc;
using Project_Management_Admin_Panel.BAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecentActionController : ControllerBase
    {
        #region RecentActionController

        #region GetAll
        [HttpGet("Get")]
        public IActionResult Get()
        {
            RecentAction_BALBase recentAction_BAL = new RecentAction_BALBase();
            List<RecentAction> RecentActionList = recentAction_BAL.dbo_API_RecentActionGetAll();
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (RecentActionList.Count > 0 && RecentActionList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", RecentActionList);
                return Ok(response);
            }
            else
            {
                response.Add("status", false);
                response.Add("message", "Data Not Found");
                response.Add("data", null);
                return NotFound(response);
            }
        }
        #endregion

        #endregion
    }
}
