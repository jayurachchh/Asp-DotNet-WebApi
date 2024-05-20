namespace Project_Management_Admin_Panel.Models
{
    #region Model : Employee
    public class Employee
    {
        public int? EmpID { get; set; } = null;
        public string? EmpName { get; set; }
        public string? EmpCode { get; set; }
        public string? EmpPosition { get; set; }
        public string? EmpContact { get; set; }
        public string? EmpEmail { get; set; }
        public string? EmpDepartment { get; set; }
        public DateTime? EmpDateOfBirth { get; set; } = null;
        public string? EmpProfileImage { get; set; } = null;
        public IFormFile? EmpProfileImagefile { get; set; } = null;
        public IFormFile? EmpProofImagefile { get; set; } = null;
        public string? EmpProofImage { get; set; } = null;
        public string? EmpProofName { get; set; }
        public string? EmpManagerId { get; set; } = null;
        public string? EmpPerHourCharge { get; set;}
        public string? EmpGitLink { get; set; }
        public DateTime? Created { get; set; } = null;
        public DateTime? Modified { get; set; } = null;
    }
    #endregion
}