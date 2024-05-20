using Microsoft.AspNetCore.Mvc;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Project_Management_Admin_Panel.BAL;
using Project_Management_Admin_Panel.Models;
using System;
using System.Data.Common;
using System.Data;
using Project_Management_Admin_Panel.DAL;

namespace Project_Management_Admin_Panel.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController:ControllerBase
    {
        #region EmployeeController

        #region GetAll
        [HttpGet("Get")]
        public IActionResult Get()
        {
            Employee_BalBase employee_balbase = new Employee_BalBase();
            List<Employee> EmployeeList = employee_balbase.dbo_API_EmployeeGetAll();
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (EmployeeList.Count > 0 && EmployeeList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", EmployeeList);
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

        #region GetAllTask NotAssign
        [HttpGet("Gettasknotassign")]
        public IActionResult Gettasknotassign()
        {
            Employee_BalBase employee_balbase = new Employee_BalBase();
            List<Employee> EmployeeList = employee_balbase.dbo_API_EmployeeGetAlltasknotassign();
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (EmployeeList.Count > 0 && EmployeeList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", EmployeeList);
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
      
        #region GetAllTaskAssign
        [HttpGet("Gettaskassign")]
        public IActionResult Gettaskassign()
        {
            Employee_BalBase employee_balbase = new Employee_BalBase();
            List<Employee> EmployeeList = employee_balbase.dbo_API_EmployeeGetAlltaskassign();
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (EmployeeList.Count > 0 && EmployeeList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", EmployeeList);
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
        [HttpGet("Get{EmpID}")]
        public IActionResult Get(int EmpID)
        {
            Employee_BalBase employee_BalBase = new Employee_BalBase();
            Employee employeeModel = employee_BalBase.dbo_API_Employee_SelectByID(EmpID);
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (employeeModel.EmpID != 0)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", employeeModel);
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

        #region GetByManager
        [HttpGet("GetManager")]
        public IActionResult GetManager()
        {
            Employee_BalBase employee_balbase = new Employee_BalBase();
            List<Employee> EmployeeList = employee_balbase.dbo_API_EmployeeGetByIS_Manager();
            // Make the Response in Key Value Pair
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            if (EmployeeList.Count > 0 && EmployeeList != null)
            {
                response.Add("status", true);
                response.Add("message", "Data Found");
                response.Add("data", EmployeeList);
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
        /*[HttpDelete("Delete{EmpID}")]

        public ActionResult Delete(int EmpID)
        {
            Employee_BalBase employee_BalBase=new Employee_BalBase();
            bool issuccess = employee_BalBase.dbo_API_Employee_DeleteByID(EmpID);
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

        }*/
        #endregion

        #region MultipleDelete
        [HttpDelete("Delete{EmpIDlist}")]

        public ActionResult MultipleDelete(string EmpIDlist)
        {
            Employee_BalBase employee_BalBase = new Employee_BalBase();
            bool issuccess = employee_BalBase.dbo_API_Employee_Multiple_delete(EmpIDlist);
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

        public async Task<ActionResult> InsertAsync([FromForm]Employee employeemodel)
        {

            Employee_BalBase employee_BalBase = new Employee_BalBase();
            bool IsSuccess = await employee_BalBase.dbo_API_Employee_InsertAsync(employeemodel);
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

        public ActionResult Update([FromForm] int EmpID, Employee employeeModel)
        {
            Employee_BalBase employee_BalBase =new Employee_BalBase();
             bool IsSuccess = employee_BalBase.dbo_API_Employee_Update(EmpID,employeeModel);
            employeeModel.EmpID = EmpID;
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
        public IActionResult Filter(Employee? employeeModel)
        {
            Employee_BalBase employee_balbase = new Employee_BalBase();
            List<Employee> EmployeeList = employee_balbase.Filter(employeeModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
                response.Add("status", true);
                response.Add("message", "Successfully added");
                response.Add("data", EmployeeList);
                return Ok(response);
        }
        #endregion

        #region TaskNotAssignFilter
        [HttpPost("TaskNotassignFilter")]
        public IActionResult FilterTaskNotassign(Employee? employeeModel)
        {
            Employee_BalBase employee_balbase = new Employee_BalBase();
            List<Employee> EmployeeList = employee_balbase.FilterTaskNotassign(employeeModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            response.Add("status", true);
            response.Add("message", "Successfully added");
            response.Add("data", EmployeeList);
            return Ok(response);
        }
        #endregion

        #region TaskAssignFilter
        [HttpPost("TaskassignFilter")]
        public IActionResult FilterTaskassign(Employee? employeeModel)
        {
            Employee_BalBase employee_balbase = new Employee_BalBase();
            List<Employee> EmployeeList = employee_balbase.FilterTaskassign(employeeModel);
            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>();
            response.Add("status", true);
            response.Add("message", "Successfully added");
            response.Add("data", EmployeeList);
            return Ok(response);
        }
        #endregion
        #endregion
    }
}
