namespace Project_Management_Admin_Panel.Models
{
    #region Model : DashBord
    public class Dashbord
    {
        public int? TotalEmployee {get; set;}

        public int? TotalEmployeesWithoutTasks { get; set;}

        public int? TotalEmployeeAssignedtask { get; set;}

        public int? TotalProject { get; set;}

        public int? TotalUpcomingProject { get; set;}

        public int? TotalCurrentProject {get; set;}

        public int? TotalCompleteProject { get;set;}


    }
    #endregion
}
