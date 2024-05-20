using System.Data.Common;
using System.Data;
using System;
using Project_Management_Admin_Panel.Models;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using WebApplication2.DAL;
using System.Reflection.Emit;
using System.Reflection;

namespace Project_Management_Admin_Panel.DAL
{
    public class Employee_DALBase:Dal_Helper
    {
        #region Model : Employee
        public async Task<Dictionary<string, dynamic>> Upload(IFormFile file)
        {
            Dictionary<String, dynamic> dict = new Dictionary<String, dynamic>();
            try
            {

                dict.Add("status", false);
                if (file == null || file.Length == 0)
                {
                    return dict;
                }

                if (!file.ContentType.ToLower().StartsWith("image/"))
                {
                    return dict;
                }

                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "uploads");
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                dict.Add("filePath", filePath);
                dict["status"] = true;
                return dict;
            }
            catch (Exception ex)
            {
                return dict;
            }
        }
        #region Method : dbo.API_Employee_Selectall
        public List<Employee> dbo_API_EmployeeGetAll()
        {
            try
            {
                List<Employee> listOfemployee = new List<Employee>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllEmployees");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Employee employeeModel = new Employee();
                        employeeModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        employeeModel.EmpName = dataReader["EmpName"].ToString();
                        employeeModel.EmpCode = dataReader["EmpCode"].ToString();
                        employeeModel.EmpPosition = dataReader["EmpPosition"].ToString();
                        employeeModel.EmpContact = dataReader["EmpContact"].ToString();
                        employeeModel.EmpEmail = dataReader["EmpEmail"].ToString();
                        employeeModel.EmpDepartment = dataReader["EmpDepartment"].ToString();
                        employeeModel.EmpDateOfBirth = Convert.ToDateTime(dataReader["EmpDateOfBirth"].ToString());
                        employeeModel.EmpProfileImage = dataReader["EmpProfileImage"].ToString();
                        employeeModel.EmpProofImage = dataReader["EmpProofImage"].ToString();
                        employeeModel.EmpProofName = dataReader["EmpProofName"].ToString();
                        employeeModel.EmpManagerId = dataReader["EmpManagerId"].ToString();
                        employeeModel.EmpPerHourCharge = dataReader["EmpPerHourCharge"].ToString();
                        employeeModel.EmpGitLink = dataReader["EmpGitLink"].ToString();
                        employeeModel.Created = Convert.ToDateTime(dataReader["EmpCreated"].ToString());
                        employeeModel.Modified = Convert.ToDateTime(dataReader["EmpModified"].ToString());
                        listOfemployee.Add(employeeModel);
                    }
                }
               return listOfemployee;
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
                List<Employee> listOfemployee = new List<Employee>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectnotassignTask");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Employee employeeModel = new Employee();
                        employeeModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        employeeModel.EmpName = dataReader["EmpName"].ToString();
                        employeeModel.EmpCode = dataReader["EmpCode"].ToString();
                        employeeModel.EmpPosition = dataReader["EmpPosition"].ToString();
                        employeeModel.EmpContact = dataReader["EmpContact"].ToString();
                        employeeModel.EmpEmail = dataReader["EmpEmail"].ToString();
                        employeeModel.EmpDepartment = dataReader["EmpDepartment"].ToString();
                        employeeModel.EmpDateOfBirth = Convert.ToDateTime(dataReader["EmpDateOfBirth"].ToString());
                        employeeModel.EmpProfileImage = dataReader["EmpProfileImage"].ToString();
                        employeeModel.EmpProofImage = dataReader["EmpProofImage"].ToString();
                        employeeModel.EmpProofName = dataReader["EmpProofName"].ToString();
                        employeeModel.EmpManagerId = dataReader["EmpManagerId"].ToString();
                        employeeModel.EmpPerHourCharge = dataReader["EmpPerHourCharge"].ToString();
                        employeeModel.EmpGitLink = dataReader["EmpGitLink"].ToString();
                        employeeModel.Created = Convert.ToDateTime(dataReader["EmpCreated"].ToString());
                        employeeModel.Modified = Convert.ToDateTime(dataReader["EmpModified"].ToString());
                        listOfemployee.Add(employeeModel);
                    }
                }
                return listOfemployee;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Employee_Selecttaskassign
        public List<Employee> dbo_API_EmployeeGetAlltaskassign()
        {
            try
            {
                List<Employee> listOfemployee = new List<Employee>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectassignTask");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Employee employeeModel = new Employee();
                        employeeModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        employeeModel.EmpName = dataReader["EmpName"].ToString();
                        employeeModel.EmpCode = dataReader["EmpCode"].ToString();
                        employeeModel.EmpPosition = dataReader["EmpPosition"].ToString();
                        employeeModel.EmpContact = dataReader["EmpContact"].ToString();
                        employeeModel.EmpEmail = dataReader["EmpEmail"].ToString();
                        employeeModel.EmpDepartment = dataReader["EmpDepartment"].ToString();
                        employeeModel.EmpDateOfBirth = Convert.ToDateTime(dataReader["EmpDateOfBirth"].ToString());
                        employeeModel.EmpProfileImage = dataReader["EmpProfileImage"].ToString();
                        employeeModel.EmpProofImage = dataReader["EmpProofImage"].ToString();
                        employeeModel.EmpProofName = dataReader["EmpProofName"].ToString();
                        employeeModel.EmpManagerId = dataReader["EmpManagerId"].ToString();
                        employeeModel.EmpPerHourCharge = dataReader["EmpPerHourCharge"].ToString();
                        employeeModel.EmpGitLink = dataReader["EmpGitLink"].ToString();
                        employeeModel.Created = Convert.ToDateTime(dataReader["EmpCreated"].ToString());
                        employeeModel.Modified = Convert.ToDateTime(dataReader["EmpModified"].ToString());
                        listOfemployee.Add(employeeModel);
                    }
                }
                return listOfemployee;
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
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectEmployeeById");
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", DbType.Int32, EmpID);
                Employee employeeModel = new Employee();
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    dataReader.Read();
                    employeeModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                    employeeModel.EmpName = dataReader["EmpName"].ToString();
                    employeeModel.EmpCode = dataReader["EmpCode"].ToString();
                    employeeModel.EmpPosition = dataReader["EmpPosition"].ToString();
                    employeeModel.EmpContact = dataReader["EmpContact"].ToString();
                    employeeModel.EmpEmail = dataReader["EmpEmail"].ToString();
                    employeeModel.EmpDepartment = dataReader["EmpDepartment"].ToString();
                    employeeModel.EmpDateOfBirth = Convert.ToDateTime(dataReader["EmpDateOfBirth"].ToString());
                    employeeModel.EmpProfileImage = dataReader["EmpProfileImage"].ToString();
                    employeeModel.EmpProofImage = dataReader["EmpProofImage"].ToString();
                    employeeModel.EmpProofName = dataReader["EmpProofName"].ToString();
                    employeeModel.EmpManagerId = dataReader["EmpManagerId"].ToString();
                    employeeModel.EmpPerHourCharge = dataReader["EmpPerHourCharge"].ToString();
                    employeeModel.EmpGitLink = dataReader["EmpGitLink"].ToString();
                    employeeModel.Created = Convert.ToDateTime(dataReader["EmpCreated"].ToString());
                    employeeModel.Modified = Convert.ToDateTime(dataReader["EmpModified"].ToString());
                }
                return employeeModel;
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
                List<Employee> listOfemployee = new List<Employee>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectEmployeeByEmployee_manager");
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Employee employeeModel = new Employee();
                        employeeModel.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        employeeModel.EmpName = dataReader["EmpName"].ToString();
                        employeeModel.EmpCode = dataReader["EmpCode"].ToString();
                        employeeModel.EmpPosition = dataReader["EmpPosition"].ToString();
                        employeeModel.EmpContact = dataReader["EmpContact"].ToString();
                        employeeModel.EmpEmail = dataReader["EmpEmail"].ToString();
                        employeeModel.EmpDepartment = dataReader["EmpDepartment"].ToString();
                        employeeModel.EmpDateOfBirth = Convert.ToDateTime(dataReader["EmpDateOfBirth"].ToString());
                        employeeModel.EmpProfileImage = dataReader["EmpProfileImage"].ToString();
                        employeeModel.EmpProofImage = dataReader["EmpProofImage"].ToString();
                        employeeModel.EmpProofName = dataReader["EmpProofName"].ToString();
                        employeeModel.EmpManagerId = dataReader["EmpManagerId"].ToString();
                        employeeModel.EmpPerHourCharge = dataReader["EmpPerHourCharge"].ToString();
                        employeeModel.EmpGitLink = dataReader["EmpGitLink"].ToString();
                        employeeModel.Created = Convert.ToDateTime(dataReader["EmpCreated"].ToString());
                        employeeModel.Modified = Convert.ToDateTime(dataReader["EmpModified"].ToString());
                        listOfemployee.Add(employeeModel);
                    }
                }
                return listOfemployee;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Method : dbo.API_Employee_deleteByID
        public bool dbo_API_Employee_delete(int EmpID)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_DeleteEmployee");
                sqlDatabase.AddInParameter(dbCommand, "@EmpID", DbType.Int32, EmpID);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand)))
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

        #region Method : dbo.API_Employee_deleteByMultipleID
        public bool dbo_API_Employee_Multiple_delete(string EmpIDlist)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_Employee_MultiDeleteProcedure");
                sqlDatabase.AddInParameter(dbCommand, "@lstid", DbType.String, EmpIDlist);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand)))
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

        #region Method : dbo.API_Employee_insert
        public async Task<bool> dbo_API_Employee_insertAsync(Employee employeeModel)
        {  
            try
            {
              SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                //EmpProfileImage
                Dictionary<string, dynamic> EmpProfileImagefile = await Upload(employeeModel.EmpProfileImagefile);
                if (EmpProfileImagefile["status"])
                {
                    employeeModel.EmpProfileImage = EmpProfileImagefile["filePath"];
                }
                Dictionary<string, dynamic> EmpProofImagefile = await Upload(employeeModel.EmpProofImagefile);
                if (EmpProofImagefile["status"])
                {
                    employeeModel.EmpProofImage = EmpProofImagefile["filePath"];
                }
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_InsertEmployee");
                sqlDatabase.AddInParameter(dbCommand, "@EmpName", SqlDbType.VarChar, employeeModel.EmpName);
                sqlDatabase.AddInParameter(dbCommand, "@EmpCode", SqlDbType.VarChar, employeeModel.EmpCode);
                sqlDatabase.AddInParameter(dbCommand, "@EmpPosition", SqlDbType.VarChar, employeeModel.EmpPosition);
                sqlDatabase.AddInParameter(dbCommand, "@EmpContact", SqlDbType.VarChar, employeeModel.EmpContact);
                sqlDatabase.AddInParameter(dbCommand, "@EmpEmail", SqlDbType.VarChar, employeeModel.EmpEmail);
                sqlDatabase.AddInParameter(dbCommand, "@EmpDepartment", SqlDbType.VarChar, employeeModel.EmpDepartment);
                sqlDatabase.AddInParameter(dbCommand, "@EmpDateOfBirth", SqlDbType.DateTime, employeeModel.EmpDateOfBirth);
                sqlDatabase.AddInParameter(dbCommand, "@EmpProfileImage", SqlDbType.VarChar, employeeModel.EmpProfileImage);
                sqlDatabase.AddInParameter(dbCommand, "@EmpProofImage", SqlDbType.VarChar, employeeModel.EmpProofImage);
                sqlDatabase.AddInParameter(dbCommand, "@EmpProofName", SqlDbType.VarChar, employeeModel.EmpProofName);
                sqlDatabase.AddInParameter(dbCommand, "@EmpPerHourCharge", SqlDbType.VarChar, employeeModel.EmpPerHourCharge);
                sqlDatabase.AddInParameter(dbCommand, "@EmpManagerId", SqlDbType.VarChar, employeeModel.EmpManagerId);
                sqlDatabase.AddInParameter(dbCommand, "@EmpGitLink", SqlDbType.VarChar, employeeModel.EmpGitLink);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand)))
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

        #region Method : dbo.API_Employee_Update
        public bool dbo_API_Employee_update(int EmpID, Employee employeeModel)
        {
            try
            {
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_UpdateEmployee");
                sqlDatabase.AddInParameter(dbCommand,"@EmpID",SqlDbType.Int, employeeModel.EmpID);
                sqlDatabase.AddInParameter(dbCommand, "@EmpName", SqlDbType.VarChar, employeeModel.EmpName);
                sqlDatabase.AddInParameter(dbCommand, "@EmpCode", SqlDbType.VarChar, employeeModel.EmpCode);
                sqlDatabase.AddInParameter(dbCommand, "@EmpPosition", SqlDbType.VarChar, employeeModel.EmpPosition);
                sqlDatabase.AddInParameter(dbCommand, "@EmpContact", SqlDbType.VarChar, employeeModel.EmpContact);
                sqlDatabase.AddInParameter(dbCommand, "@EmpEmail", SqlDbType.VarChar, employeeModel.EmpEmail);
                sqlDatabase.AddInParameter(dbCommand, "@EmpDepartment", SqlDbType.VarChar, employeeModel.EmpDepartment);
                sqlDatabase.AddInParameter(dbCommand, "@EmpDateOfBirth", SqlDbType.DateTime, employeeModel.EmpDateOfBirth);
                sqlDatabase.AddInParameter(dbCommand, "@EmpProfileImage", SqlDbType.VarChar, employeeModel.EmpProfileImage);
                sqlDatabase.AddInParameter(dbCommand, "@EmpProofImage", SqlDbType.VarChar, employeeModel.EmpProofImage);
                sqlDatabase.AddInParameter(dbCommand, "@EmpProofName", SqlDbType.VarChar, employeeModel.EmpProofName);
                sqlDatabase.AddInParameter(dbCommand, "@EmpPerHourCharge", SqlDbType.VarChar, employeeModel.EmpPerHourCharge);
                sqlDatabase.AddInParameter(dbCommand, "@EmpManagerId", SqlDbType.VarChar, employeeModel.EmpManagerId);
                sqlDatabase.AddInParameter(dbCommand, "@EmpGitLink", SqlDbType.VarChar, employeeModel.EmpGitLink);
                if (Convert.ToBoolean(sqlDatabase.ExecuteNonQuery(dbCommand)))
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

        #region Method : dbo.API_Employee_Filter
        public List<Employee> Filter(Employee? employeeModel)
        {
            try
            {
                List<Employee> listofemployee = new List<Employee>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectAllEmployees");
                sqlDatabase.AddInParameter(dbCommand, "@EmpName", DbType.String, employeeModel?.EmpName);
                sqlDatabase.AddInParameter(dbCommand, "@EmpCode", SqlDbType.VarChar, employeeModel?.EmpCode);
                sqlDatabase.AddInParameter(dbCommand, "@EmpPosition", SqlDbType.VarChar, employeeModel?.EmpPosition);
                /*                sqlDatabase.AddInParameter(dbCommand, "@EmpContact", SqlDbType.VarChar, employeeModel.EmpContact);*/
                /*           sqlDatabase.AddInParameter(dbCommand, "@EmpEmail", SqlDbType.VarChar, employeeModel?.EmpEmail);*/
                sqlDatabase.AddInParameter(dbCommand, "@EmpDepartment", SqlDbType.VarChar, employeeModel?.EmpDepartment);
                /*                sqlDatabase.AddInParameter(dbCommand, "@EmpDateOfBirth", SqlDbType.DateTime, employeeModel.EmpDateOfBirth);
                                sqlDatabase.AddInParameter(dbCommand, "@EmpProfileImage", SqlDbType.VarChar, employeeModel.EmpProfileImage);
                                sqlDatabase.AddInParameter(dbCommand, "@EmpProofImage", SqlDbType.VarChar, employeeModel.EmpProofImage);
                   sqlDatabase.AddInParameter(dbCommand, "@EmpProofName", SqlDbType.VarChar, employeeModel.EmpProofName);
                                sqlDatabase.AddInParameter(dbCommand, "@EmpPerHourCharge", SqlDbType.VarChar, employeeModel.EmpPerHourCharge);*/
                sqlDatabase.AddInParameter(dbCommand, "@EmpManagerId", SqlDbType.VarChar, employeeModel?.EmpManagerId);
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Employee em = new Employee();
                        em.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        em.EmpName = dataReader["EmpName"].ToString();
                        em.EmpCode = dataReader["EmpCode"].ToString();
                        em.EmpPosition = dataReader["EmpPosition"].ToString();
                        em.EmpContact = dataReader["EmpContact"].ToString();
                        em.EmpEmail = dataReader["EmpEmail"].ToString();
                        em.EmpDepartment = dataReader["EmpDepartment"].ToString();
                        em.EmpDateOfBirth = Convert.ToDateTime(dataReader["EmpDateOfBirth"].ToString());
                        em.EmpProfileImage = dataReader["EmpProfileImage"].ToString();
                        em.EmpProofImage = dataReader["EmpProofImage"].ToString();
                        em.EmpProofName = dataReader["EmpProofName"].ToString();
                        em.EmpManagerId = dataReader["EmpManagerId"].ToString();
                        em.EmpPerHourCharge = dataReader["EmpPerHourCharge"].ToString();
                        em.Created = Convert.ToDateTime(dataReader["EmpCreated"].ToString());
                        em.Modified = Convert.ToDateTime(dataReader["EmpModified"].ToString());
                        listofemployee.Add(em);
                    }
                }
                return listofemployee;
            }
            catch
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
                List<Employee> listofemployee = new List<Employee>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectnotassignTask");
                sqlDatabase.AddInParameter(dbCommand, "@EmpName", DbType.String, employeeModel?.EmpName);
                sqlDatabase.AddInParameter(dbCommand, "@EmpCode", SqlDbType.VarChar, employeeModel?.EmpCode);
                sqlDatabase.AddInParameter(dbCommand, "@EmpPosition", SqlDbType.VarChar, employeeModel?.EmpPosition);
                /*                sqlDatabase.AddInParameter(dbCommand, "@EmpContact", SqlDbType.VarChar, employeeModel.EmpContact);*/
                /*           sqlDatabase.AddInParameter(dbCommand, "@EmpEmail", SqlDbType.VarChar, employeeModel?.EmpEmail);*/
                sqlDatabase.AddInParameter(dbCommand, "@EmpDepartment", SqlDbType.VarChar, employeeModel?.EmpDepartment);
                /*                sqlDatabase.AddInParameter(dbCommand, "@EmpDateOfBirth", SqlDbType.DateTime, employeeModel.EmpDateOfBirth);
                                sqlDatabase.AddInParameter(dbCommand, "@EmpProfileImage", SqlDbType.VarChar, employeeModel.EmpProfileImage);
                                sqlDatabase.AddInParameter(dbCommand, "@EmpProofImage", SqlDbType.VarChar, employeeModel.EmpProofImage);
                   sqlDatabase.AddInParameter(dbCommand, "@EmpProofName", SqlDbType.VarChar, employeeModel.EmpProofName);
                                sqlDatabase.AddInParameter(dbCommand, "@EmpPerHourCharge", SqlDbType.VarChar, employeeModel.EmpPerHourCharge);*/
                sqlDatabase.AddInParameter(dbCommand, "@EmpManagerId", SqlDbType.VarChar, employeeModel?.EmpManagerId);
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Employee em = new Employee();
                        em.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        em.EmpName = dataReader["EmpName"].ToString();
                        em.EmpCode = dataReader["EmpCode"].ToString();
                        em.EmpPosition = dataReader["EmpPosition"].ToString();
                        em.EmpContact = dataReader["EmpContact"].ToString();
                        em.EmpEmail = dataReader["EmpEmail"].ToString();
                        em.EmpDepartment = dataReader["EmpDepartment"].ToString();
                        em.EmpDateOfBirth = Convert.ToDateTime(dataReader["EmpDateOfBirth"].ToString());
                        em.EmpProfileImage = dataReader["EmpProfileImage"].ToString();
                        em.EmpProofImage = dataReader["EmpProofImage"].ToString();
                        em.EmpProofName = dataReader["EmpProofName"].ToString();
                        em.EmpManagerId = dataReader["EmpManagerId"].ToString();
                        em.EmpPerHourCharge = dataReader["EmpPerHourCharge"].ToString();
                        em.Created = Convert.ToDateTime(dataReader["EmpCreated"].ToString());
                        em.Modified = Convert.ToDateTime(dataReader["EmpModified"].ToString());
                        listofemployee.Add(em);
                    }
                }
                return listofemployee;
            }
            catch
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
                List<Employee> listofemployee = new List<Employee>();
                SqlDatabase sqlDatabase = new SqlDatabase(Constr);
                DbCommand dbCommand = sqlDatabase.GetStoredProcCommand("Pro_SelectassignTask");
                sqlDatabase.AddInParameter(dbCommand, "@EmpName", DbType.String, employeeModel?.EmpName);
                sqlDatabase.AddInParameter(dbCommand, "@EmpCode", SqlDbType.VarChar, employeeModel?.EmpCode);
                sqlDatabase.AddInParameter(dbCommand, "@EmpPosition", SqlDbType.VarChar, employeeModel?.EmpPosition);
                /*                sqlDatabase.AddInParameter(dbCommand, "@EmpContact", SqlDbType.VarChar, employeeModel.EmpContact);*/
                /*           sqlDatabase.AddInParameter(dbCommand, "@EmpEmail", SqlDbType.VarChar, employeeModel?.EmpEmail);*/
                sqlDatabase.AddInParameter(dbCommand, "@EmpDepartment", SqlDbType.VarChar, employeeModel?.EmpDepartment);
                /*                sqlDatabase.AddInParameter(dbCommand, "@EmpDateOfBirth", SqlDbType.DateTime, employeeModel.EmpDateOfBirth);
                                sqlDatabase.AddInParameter(dbCommand, "@EmpProfileImage", SqlDbType.VarChar, employeeModel.EmpProfileImage);
                                sqlDatabase.AddInParameter(dbCommand, "@EmpProofImage", SqlDbType.VarChar, employeeModel.EmpProofImage);
                   sqlDatabase.AddInParameter(dbCommand, "@EmpProofName", SqlDbType.VarChar, employeeModel.EmpProofName);
                                sqlDatabase.AddInParameter(dbCommand, "@EmpPerHourCharge", SqlDbType.VarChar, employeeModel.EmpPerHourCharge);*/
                sqlDatabase.AddInParameter(dbCommand, "@EmpManagerId", SqlDbType.VarChar, employeeModel?.EmpManagerId);
                using (IDataReader dataReader = sqlDatabase.ExecuteReader(dbCommand))
                {
                    while (dataReader.Read())
                    {
                        Employee em = new Employee();
                        em.EmpID = Convert.ToInt32(dataReader["EmpID"]);
                        em.EmpName = dataReader["EmpName"].ToString();
                        em.EmpCode = dataReader["EmpCode"].ToString();
                        em.EmpPosition = dataReader["EmpPosition"].ToString();
                        em.EmpContact = dataReader["EmpContact"].ToString();
                        em.EmpEmail = dataReader["EmpEmail"].ToString();
                        em.EmpDepartment = dataReader["EmpDepartment"].ToString();
                        em.EmpDateOfBirth = Convert.ToDateTime(dataReader["EmpDateOfBirth"].ToString());
                        em.EmpProfileImage = dataReader["EmpProfileImage"].ToString();
                        em.EmpProofImage = dataReader["EmpProofImage"].ToString();
                        em.EmpProofName = dataReader["EmpProofName"].ToString();
                        em.EmpManagerId = dataReader["EmpManagerId"].ToString();
                        em.EmpPerHourCharge = dataReader["EmpPerHourCharge"].ToString();
                        em.Created = Convert.ToDateTime(dataReader["EmpCreated"].ToString());
                        em.Modified = Convert.ToDateTime(dataReader["EmpModified"].ToString());
                        listofemployee.Add(em);
                    }
                }
                return listofemployee;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #endregion
    }
}
