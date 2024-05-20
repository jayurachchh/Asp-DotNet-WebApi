using Microsoft.AspNetCore.Mvc;
using Project_Management_Admin_Panel.BAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskPriorityController : ControllerBase
    {
        #region Model : TaskPriority

        #region GetAll
        [HttpGet("Get")]
        public IActionResult Get()
        {
            TaskPriority_BALBase taskPriority_BALBase = new TaskPriority_BALBase();
            List<TaskPriority> taskPriorityList = taskPriority_BALBase.dbo_API_TaskPriorityGetAll();
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (taskPriorityList.Count > 0 && taskPriorityList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", taskPriorityList);
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
        [HttpGet("Get{TaskPriorityID}")]
        public IActionResult Get(int TaskPriorityID)
        {
            TaskPriority_BALBase taskPriority_BALBase = new TaskPriority_BALBase();
            TaskPriority taskPriority = taskPriority_BALBase.dbo_API_TaskPriority_SelectByID(TaskPriorityID);
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (taskPriority.TaskPriorityID != 0)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", taskPriority);
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
        [HttpDelete("Delete{TaskPriorityID}")]

        public ActionResult Delete(int TaskPriorityID)
        {
            TaskPriority_BALBase taskPriority_BALBase = new TaskPriority_BALBase();
            bool issuccess = taskPriority_BALBase.dbo_API_TaskPriority_DeleteByID(TaskPriorityID);
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

        public ActionResult Insert([FromBody] TaskPriority taskPriority)
        {
            TaskPriority_BALBase taskPriority_BALBase = new TaskPriority_BALBase();
            bool IsSuccess = taskPriority_BALBase.dbo_API_TaskPriority_Insert(taskPriority);
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

        public ActionResult Update(int TaskPriorityID, TaskPriority taskPriority)
        {
            TaskPriority_BALBase taskPriority_BALBase = new TaskPriority_BALBase();
            bool IsSuccess = taskPriority_BALBase.dbo_API_TaskPriority_Update(TaskPriorityID,taskPriority);
            taskPriority.TaskPriorityID = TaskPriorityID;
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
