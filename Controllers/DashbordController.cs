using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project_Management_Admin_Panel.BAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class DashbordController : ControllerBase
    {
        #region  DashbordController

        #region GetAll
        [HttpGet("Get")]
        public IActionResult Get()
        {
            Dashbord_BALBase dashbord_BALBase = new Dashbord_BALBase();
            List<Dashbord> DashbordList = dashbord_BALBase.dbo_API_DashbordGetAll();
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (DashbordList.Count > 0 && DashbordList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", DashbordList);
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
