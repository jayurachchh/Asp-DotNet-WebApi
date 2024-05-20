namespace Project_Management_Admin_Panel.Models
{
    #region Model : ProjectWiseTask
    public class ProjectWiseTask
    {
        public int? ProjWiseTaskID { get; set; } = null;
        public int? ProjID { get; set; } = null;  
        public string? ProjName { get; set; }
        public string? ProjWiseTaskName { get; set; } = null;
        public string? ProjWiseTaskNumber { get; set; } = null;
        public DateTime? ProjWiseTaskStartDate { get; set; } = null;
        public DateTime? ProjWiseTaskEndDate { get; set; } = null;
        public int? ProjectWiseTaskEmployeeNumber { get; set; } = null;
        public DateTime? Created { get; set; } = null;
        public DateTime? Modified { get; set; } = null; 
    }
    #endregion
}
