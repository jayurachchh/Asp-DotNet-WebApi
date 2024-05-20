using Microsoft.AspNetCore.Mvc;
using Project_Management_Admin_Panel.BAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        #region Model : Status

        #region GetAll
        [HttpGet("Get")]
        public IActionResult Get()
        {
            Status_BALBase status_BALBase = new Status_BALBase();
            List<StatusModel> StatusList = status_BALBase.dbo_API_StatusGetAll();
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (StatusList.Count > 0 && StatusList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", StatusList);
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

        #region GetByID
        [HttpGet("Get{StatusID}")]
        public IActionResult Get(int StatusID)
        {
            Status_BALBase status_BALBase = new Status_BALBase();
            StatusModel statusModel = status_BALBase.dbo_API_Status_SelectByID(StatusID);
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (statusModel.StatusID != 0)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", statusModel);
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

        #region Delete
        [HttpDelete("Delete{StatusID}")]

        public ActionResult Delete(int StatusID)
        {
            Status_BALBase status_BALBase = new Status_BALBase();
            bool issuccess = status_BALBase.dbo_API_Status_DeleteByID(StatusID);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (issuccess)
            {
                response.Add("status", true);
                response.Add("message", "Data Deleted");
                return Ok(response);
            }
            else
            {
                response.Add("status", false);
                response.Add("message", "Data Not Deleted");
                return NotFound(response);
            }

        }
        #endregion

        #region Insert
        [HttpPost("Insert")]

        public ActionResult Insert([FromBody] StatusModel statusModel)
        {
            Status_BALBase status_BALBase = new Status_BALBase();
            bool IsSuccess = status_BALBase.dbo_API_Employee_Insert(statusModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (IsSuccess)
            {
                response.Add("status", true);
                response.Add("message", "Data Inserted");
                return Ok(response);
            }
            else
            {
                response.Add("status", false);
                response.Add("message", "Data Not Inserted");
                return NotFound(response);
            }

        }
        #endregion

        #region Update
        [HttpPut("Update")]

        public ActionResult Update(int StatusID, StatusModel statusModel)
        {
            Status_BALBase status_BALBase = new Status_BALBase();
            bool IsSuccess = status_BALBase.dbo_API_Status_Update(StatusID,statusModel);
            statusModel.StatusID = StatusID;
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (IsSuccess)
            {
                response.Add("status", true);
                response.Add("message", "Data Updated");
                return Ok(response);
            }
            else
            {
                response.Add("status", false);
                response.Add("message", "Data Not Updated");
                return NotFound(response);
            }

        }
        #endregion
        #endregion
    }
}
