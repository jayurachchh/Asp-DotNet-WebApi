using Microsoft.AspNetCore.Mvc;
using Project_Management_Admin_Panel.BAL;
using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectWiseTaskController:ControllerBase
    {
        #region ProjectWiseTaskController

        #region GetAll
        [HttpGet("Get")]
        public IActionResult Get()
        {
           ProjectWiseTask_BALBase projectWiseTask_BALBase = new ProjectWiseTask_BALBase();
            List<ProjectWiseTask> ProjectWiseTaskList = projectWiseTask_BALBase.dbo_API_ProjectWiseTaskGetAll();
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (ProjectWiseTaskList.Count > 0 && ProjectWiseTaskList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", ProjectWiseTaskList);
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
        [HttpGet("Get{ProjWiseTaskID}")]
        public IActionResult Get(int ProjWiseTaskID)
        {
            ProjectWiseTask_BALBase projectWiseTask_BALBase = new ProjectWiseTask_BALBase();
            ProjectWiseTask projectWiseTaskModel = projectWiseTask_BALBase.dbo_API_ProjectWiseTask_SelectByID(ProjWiseTaskID);
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (projectWiseTaskModel.ProjWiseTaskID != 0)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", projectWiseTaskModel);
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

       /* #region Delete
        [HttpDelete("Delete{ProjWiseTaskID}")]

        public ActionResult Delete(int ProjWiseTaskID)
        {
            ProjectWiseTask_BALBase projectWiseTask_BALBase = new ProjectWiseTask_BALBase();
            bool issuccess = projectWiseTask_BALBase.dbo_API_ProjectWiseTask_DeleteByID(ProjWiseTaskID);
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
        #endregion*/

        #region MultipleDelete
        [HttpDelete("Delete{ProjectWisetaskIDlist}")]

        public ActionResult MultipleDelete(string ProjectWisetaskIDlist)
        {
            ProjectWiseTask_BALBase projectWiseTask_BALBase = new ProjectWiseTask_BALBase();
            bool issuccess = projectWiseTask_BALBase.dbo_API_ProjectWiseTask_Multiple_delete(ProjectWisetaskIDlist);
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

        public ActionResult Insert(ProjectWiseTask projectWiseTaskModel)
        {
            ProjectWiseTask_BALBase projectWiseTask_BALBase=new ProjectWiseTask_BALBase();
            bool IsSuccess = projectWiseTask_BALBase.dbo_API_ProjectWiseTask_Insert(projectWiseTaskModel);
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

        public ActionResult Update(int ProjWiseTaskID, ProjectWiseTask projectWiseTaskModel)
        {
            ProjectWiseTask_BALBase projectWiseTask_BALBase =new ProjectWiseTask_BALBase();
            bool IsSuccess = projectWiseTask_BALBase.dbo_API_ProjectTaskWise_Update(ProjWiseTaskID, projectWiseTaskModel);
            projectWiseTaskModel.ProjWiseTaskID = ProjWiseTaskID;
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

        #region Filter
        [HttpPost("Post")]
        public IActionResult Filter(ProjectWiseTask? projectWiseTaskModel)
        {
            ProjectWiseTask_BALBase projectWiseTask_BALBase = new ProjectWiseTask_BALBase();
            List<ProjectWiseTask> projectWiseTaskList = projectWiseTask_BALBase.Filter(projectWiseTaskModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            
            
                response.Add("status", true);
                response.Add("message", "Successfully added");
                response.Add("data", projectWiseTaskList);
                return Ok(response);
        }
        #endregion

        #endregion

    }
}
