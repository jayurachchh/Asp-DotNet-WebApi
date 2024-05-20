using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;
using System;
using WebApplication2.DAL;

namespace Project_Management_Admin_Panel.BAL
{
    public class Employee_BalBase
    {
        #region Model : Employee

        #region Method : dbo.API_Employee_SelectAll
        public List<Employee> dbo_API_EmployeeGetAll()
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                List<Employee> employeeModels = employee_DALBase.dbo_API_EmployeeGetAll();
                return employeeModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Employee_Selecttasknotassign
        public List<Employee> dbo_API_EmployeeGetAlltasknotassign()
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                List<Employee> employeeModels = employee_DALBase.dbo_API_EmployeeGetAlltasknotassign();
                return employeeModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Employee_Selecttaskanotssign
        public List<Employee> dbo_API_EmployeeGetAlltaskassign()
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                List<Employee> employeeModels = employee_DALBase.dbo_API_EmployeeGetAlltaskassign();
                return employeeModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Employee_SelectByID
        public Employee dbo_API_Employee_SelectByID(int EmpID)
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                Employee EmployeeModel = employee_DALBase.dbo_API_Employee_SelectByID(EmpID);
                return EmployeeModel;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_EmployeeGetByIS_Manager
        public List<Employee> dbo_API_EmployeeGetByIS_Manager()
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                List<Employee> employeeModels = employee_DALBase.dbo_API_EmployeeGetByIS_Manager();
                return employeeModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Employee_DeleteByID
        public bool dbo_API_Employee_DeleteByID(int EmpID)
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                if (employee_DALBase.dbo_API_Employee_delete(EmpID))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Method : dbo.API_Employee_DeleteByMultipleID
        public bool dbo_API_Employee_Multiple_delete(string EmpIDlist)
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                if (employee_DALBase.dbo_API_Employee_Multiple_delete(EmpIDlist))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Method : dbo.API_Employee_Insert
        public async Task<bool> dbo_API_Employee_InsertAsync(Employee employeemodel)
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                if (await employee_DALBase.dbo_API_Employee_insertAsync(employeemodel))
                {
                    return true;
                }
                else
                { return false; }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Method : dbo.API_Employee_Updateedbyid
        public bool dbo_API_Employee_Update(int EmpID, Employee employeeModel)
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                if (employee_DALBase.dbo_API_Employee_update(EmpID,employeeModel))
                {
                    return true;
                }
                else
                { return false; }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region Method : dbo.API_EmployeeFilter
        public List<Employee> Filter(Employee? employeeModel)
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                List<Employee> employeeModels = employee_DALBase.Filter(employeeModel);
                return employeeModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_EmployeeTaskNotAssign_Filter
        public List<Employee> FilterTaskNotassign(Employee? employeeModel)
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                List<Employee> employeeModels = employee_DALBase.FilterTaskNotassign(employeeModel);
                return employeeModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_EmployeeTaskAssign_Filter
        public List<Employee> FilterTaskassign(Employee? employeeModel)
        {
            try
            {
                Employee_DALBase employee_DALBase = new Employee_DALBase();
                List<Employee> employeeModels = employee_DALBase.FilterTaskassign(employeeModel);
                return employeeModels;
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
