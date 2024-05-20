namespace Project_Management_Admin_Panel.Models
{
    #region Model : TaskAssign
    public class TaskAssign
    {
        public int? TaskAssignID { get; set; } = null;
        public DateTime? TaskAssignStartDate { get; set; } = null;
        public DateTime? TaskAssignCompletionDate { get; set; } = null;
        public string? Remarks { get; set; } = null;
        public int? ProjWiseTaskID { get; set;} = null;
        public string? ProjWiseTaskName { get; set; } = null;
        public int? EmpID { get; set; } = null;
        public string? EmpName { get; set; } = null;
        public int? StatusID { get; set; } = null;
        public string? StatusName { get; set; }
        public string? StatusCssColor { get; set; }
        public DateTime? Created { get; set; } = null;
        public DateTime? Modified { get; set; } = null;
    }
    #endregion
}
