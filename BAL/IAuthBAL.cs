using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.BAL
{
    #region IAuthBAL
    public interface IAuthBAL
    {
        /// <summary>
        /// Authenticates a user based on the provided username and password.
        /// </summary>
        /// <param name="authInfo">The Auth_Model object containing the username and password.</param>
        /// <returns>A User_Model object containing user information if authentication is successful, otherwise null.</returns>
        User_Model AuthLoginDetails(Auth_Model authInfo);

/*        User_Model GetAuthUserByEmail(string email);
        bool SavePasswordResetToken(string email, string token);
        bool ValidatePasswordResetToken(string email, string token);
        bool ChangePassword(string email, string newPassword);

        bool ValidateAndDeleteToken(string email, string token);*/

    }
}
#endregion
