namespace Project_Management_Admin_Panel.Models
{
    #region Model : Project
    public class Project
    {
        public int? ProjID { get; set; } = null;
        public string? ProjName { get; set; }
        public string? ProjDescription { get; set;}
        public DateTime? ProjStartDate { get; set; } = null;
        public DateTime? ProjEndDate { get; set; } = null;
        public string? ProjTotalCost {get;set; }
        public string? ProjSource { get; set;}
        public string? ProjDocumentation { get; set;}
        public int? EmpID { get; set; } = null;
        public string? EmpName { get; set; }
        public int? StatusID { get; set; } = null;
        public string? StatusName { get; set; }
        public string? StatusCssColor { get; set; }
        public DateTime? Created { get; set; } = null;
        public DateTime? Modified { get; set; } = null;

    }
    #endregion
}
