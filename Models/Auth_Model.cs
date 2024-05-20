using System.ComponentModel.DataAnnotations;

namespace Project_Management_Admin_Panel.Models
{
    #region Model : Auth Model
    public class Auth_Model
    {
        public string? Username { get; set; }

        public string? Password { get; set; }
    }
    #endregion

    #region Model : User Model
    public class User_Model
    {
        public int Userid { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string? Emailaddress { get; set; }

        public string? Phoneno { get; set; }

        public string? Token { get; set; }
    }
    #endregion
}

