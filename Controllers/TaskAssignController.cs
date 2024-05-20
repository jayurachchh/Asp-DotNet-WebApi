using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project_Management_Admin_Panel.BAL;
using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;
using System.Linq.Expressions;
using Project_Management_Admin_Panel.Email_Services;
namespace Project_Management_Admin_Panel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskAssignController:ControllerBase
    {
        #region Model:TaskAssign

        private IEmailSender _emailSender;
        public TaskAssignController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        #region GetAll
        [HttpGet("Get")]
        public IActionResult Get()
        {
            TaskAssign_BALBase taskAssign_BALBase = new TaskAssign_BALBase();
            List<TaskAssign> TaskAssignList = taskAssign_BALBase.dbo_API_TaskAssignGetAll();
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (TaskAssignList.Count > 0 && TaskAssignList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", TaskAssignList);
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
        [HttpGet("Get{TaskAssignID}")]
        public IActionResult Get(int TaskAssignID)
        {
            TaskAssign_BALBase taskAssign_BALBase = new TaskAssign_BALBase();
            TaskAssign TaskAssignModel = taskAssign_BALBase.dbo_API_TaskAssign_SelectByID(TaskAssignID);
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (TaskAssignModel.TaskAssignID != 0)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", TaskAssignModel);
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

        /*#region Delete
        [HttpDelete("Delete{TaskAssignID}")]

        public ActionResult Delete(int TaskAssignID)
        {
            TaskAssign_BALBase taskAssign_BALBase = new TaskAssign_BALBase();
            bool issuccess = taskAssign_BALBase.dbo_API_TaskAssign_DeleteByID(TaskAssignID);
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
        [HttpDelete("Delete{TaskAssignlist}")]

        public ActionResult MultipleDelete(string TaskAssignlist)
        {
            TaskAssign_BALBase taskAssign_BALBase = new TaskAssign_BALBase();
            bool issuccess = taskAssign_BALBase.dbo_API_TaskAssign_Multiple_delete(TaskAssignlist);
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

        public async Task<IActionResult> Insert(TaskAssign TaskAssignModel)
        {
            TaskAssign_BALBase taskAssign_BALBase = new TaskAssign_BALBase();
            bool IsSuccess = taskAssign_BALBase.dbo_API_TaskAssign_Insert(TaskAssignModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
           
            if (IsSuccess)
            {
                response.Add("status", true);
                response.Add("message", "Data Inserted");

                Employee employee = dbo_API_Employee_SelectByID(TaskAssignModel.EmpID.Value);




                // Email Service - After successful Login Details Fetch, send a email
                string _email = employee.EmpEmail;// Dynamically fetch the admin's email
            string _emailSubject = "Task Details!";
            string _emailBody = $@"
<html>
<head>
</head>
<body style='font-family: Arial, sans-serif; color: #333; background-color: #f4f4f4;'>
    <div style='max-width: 600px; margin: 0 auto; background-color: #FFFFFF; padding: 20px;'>
        <div style='text-align: center;'>           
            <h1 style='color: #000000;'>Welcome to Project Management System!</h1>
            <p>Hello {employee.EmpName},</p>
            <p>You have been assigned a task. Please find the details below:</p>
            <p><strong>Task Description:</strong> {TaskAssignModel.Remarks}</p>
            <p><strong>Task Deadline:</strong> {TaskAssignModel.TaskAssignCompletionDate}</p>
            <p>After completing the task, please upload it using the following link: <a href={employee.EmpGitLink}>Upload Task</a></p>
            <p>Thank you for your cooperation.</p>
          
        </div>        
        <div style='margin-top: 40px; color: #333;'>
            <p style='font-weight:bold;'>Thanks & Regards,</p>
            <p style='font-weight:bold;'>Team Project Management System</p>
        </div>
    </div>
</body>
</html>";
            await _emailSender.SendEmailAsync(_email, _emailSubject, _emailBody);
            return Ok("Email Sent Successfully !!"); }
            else
            {
                response.Add("status", false);
                response.Add("message", "Data Not Inserted");
                return NotFound(response);
            }
        }
        #endregion

        private Employee dbo_API_Employee_SelectByID(int empID)
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                Employee employee = employee_DALBase.dbo_API_Employee_SelectByID(empID);
                return employee;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        #region Update
        [HttpPut("Update")]

        public ActionResult Update(int TaskAssignID, TaskAssign TaskAssignModel)
        {
            TaskAssign_BALBase taskAssign_BALBase = new TaskAssign_BALBase();
        
            bool IsSuccess = taskAssign_BALBase.dbo_API_TaskAssign_Update(TaskAssignID, TaskAssignModel);
            TaskAssignModel.TaskAssignID = TaskAssignID;
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
        public IActionResult Filter(TaskAssign? taskAssignModel)
        {
            TaskAssign_BALBase taskAssign_BALBase = new TaskAssign_BALBase();
            List<TaskAssign> taskAssignList = taskAssign_BALBase.Filter(taskAssignModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();

            if(taskAssignList  != null && taskAssignList.Count>0) 
            {
                response.Add("status", true);
                response.Add("message", "Successfully added");
                response.Add("data", taskAssignList);
                return Ok(response);
            }
            else
            {
                response.Add("status", false);
                response.Add("message", "error");
                response.Add("data", taskAssignList);
                return Ok(response);
            }
        }
        #endregion

        #endregion
    }
}
