using Microsoft.AspNetCore.Mvc;
using Project_Management_Admin_Panel.BAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController:ControllerBase
    {
        #region ProjectController

        #region GetAll
        [HttpGet("Get")]
        public IActionResult Get()
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            List<Project> ProjectList = project_BALBase.dbo_API_ProjectGetAll();
            // Make the Response in Key Value Pair 
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (ProjectList.Count > 0 && ProjectList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", ProjectList);
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

        #region GetAllUpcoming
        [HttpGet("Upcoming")]
        public IActionResult GetUpcoming()
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            List<Project> ProjectList = project_BALBase.dbo_API_ProjectGetAllUpcoming();
            // Make the Response in Key Value Pair 
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (ProjectList.Count > 0 && ProjectList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", ProjectList);
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

        #region GetAllCurrent 
        [HttpGet("Current")]
        public IActionResult GetCurrent()
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            List<Project> ProjectList = project_BALBase.dbo_API_ProjectGetAllCurrent();
            // Make the Response in Key Value Pair 
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (ProjectList.Count > 0 && ProjectList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", ProjectList);
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

        #region GetAllComplete
        [HttpGet("Complete")]
        public IActionResult GetComplete()
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            List<Project> ProjectList = project_BALBase.dbo_API_ProjectGetAllComplete();
            // Make the Response in Key Value Pair 
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (ProjectList.Count > 0 && ProjectList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", ProjectList);
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
        [HttpGet("Get{ProjID}")]
        public IActionResult Get(int ProjID)
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            Project projectModel = project_BALBase.dbo_API_Employee_SelectByID(ProjID);
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (projectModel.ProjID != 0)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", projectModel);
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
        [HttpDelete("Delete{ProjID}")]

        public ActionResult Delete(int ProjID)
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            bool issuccess = project_BALBase.dbo_API_Project_DeleteByID(ProjID);
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
        [HttpDelete("Delete{ProjectIDlist}")]

        public ActionResult MultipleDelete(string ProjectIDlist)
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            bool issuccess = project_BALBase.dbo_API_Project_Multiple_delete(ProjectIDlist);
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

        public ActionResult Insert(Project projectModel)
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            bool IsSuccess = project_BALBase.dbo_API_Project_Insert(projectModel);
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

        public ActionResult Update(int ProjID, Project projectModel)
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            bool IsSuccess = project_BALBase.dbo_API_Project_Update(ProjID, projectModel);
            projectModel.ProjID = ProjID;
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
        public IActionResult Filter(Project? projectModel)
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            List<Project> projectList = project_BALBase.Filter(projectModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();

                response.Add("status", true);
                response.Add("message", "Successfully added");
                response.Add("data", projectList);
                return Ok(response);
            
      /*      else
            {
                response.Add("status", false);
                response.Add("message", "error");
                response.Add("data", projectList);
                return NotFound(response);
            }*/
        }
        #endregion

        #region FilterUpcoming
        [HttpPost("Upcoming")]
        public IActionResult FilterUpcoming(Project? projectModel)
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            List<Project> projectList = project_BALBase.FilterUpcoming(projectModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();

            response.Add("status", true);
            response.Add("message", "Successfully added");
            response.Add("data", projectList);
            return Ok(response);

            /*      else
                  {
                      response.Add("status", false);
                      response.Add("message", "error");
                      response.Add("data", projectList);
                      return NotFound(response);
                  }*/
        }
        #endregion

        #region FilterCurrent
        [HttpPost("Current")]
        public IActionResult FilterCurrent(Project? projectModel)
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            List<Project> projectList = project_BALBase.FilterCurrent(projectModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();

            response.Add("status", true);
            response.Add("message", "Successfully added");
            response.Add("data", projectList);
            return Ok(response);

            /*      else
                  {
                      response.Add("status", false);
                      response.Add("message", "error");
                      response.Add("data", projectList);
                      return NotFound(response);
                  }*/
        }
        #endregion

        #region FilterComplete
        [HttpPost("Complete")]
        public IActionResult FilterComplete(Project? projectModel)
        {
            Project_BALBase project_BALBase = new Project_BALBase();
            List<Project> projectList = project_BALBase.FilterComplete(projectModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();

            response.Add("status", true);
            response.Add("message", "Successfully added");
            response.Add("data", projectList);
            return Ok(response);

            /*      else
                  {
                      response.Add("status", false);
                      response.Add("message", "error");
                      response.Add("data", projectList);
                      return NotFound(response);
                  }*/
        }
        #endregion

        #endregion
    }
}
