using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.DAL
{
    #region IAuthDAL
    public interface IAuthDAL
    {
        /// <summary>
        /// Authenticates a user based on the provided username and password.
        /// </summary>
        /// <param name="auth_info">The Auth_Model object containing the username and password.</param>
        /// <returns>A User_Model object containing user information if authentication is successful, otherwise null.</returns>
        User_Model AuthUser(Auth_Model auth_info);

/*        User_Model GetAuthUserByEmail(string email);
        bool SavePasswordResetToken(string email, string token);
        bool ValidatePasswordResetToken(string email, string token);
        bool ChangePassword(string email, string newPassword);

        bool DeleteToken(string email, string token);*/

    }
    #endregion
}
