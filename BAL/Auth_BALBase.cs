using Project_Management_Admin_Panel.DAL;
using Project_Management_Admin_Panel.Models;

namespace Project_Management_Admin_Panel.BAL
{
    #region Auth_BALBase
    public class Auth_BALBase : IAuthBAL
    {
        private readonly IAuthDAL _authDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="Auth_BALBase"/> class.
        /// </summary>
        /// <param name="authDAL">The instance of the IAuthDAL interface.</param>
        public Auth_BALBase(IAuthDAL authDAL)
        {
            _authDAL = authDAL;
        }

        /// <summary>
        /// Authenticates a user based on the provided username and password.
        /// </summary>
        /// <param name="authInfo">The Auth_Model object containing the username and password.</param>
        /// <returns>A User_Model object containing user information if authentication is successful, otherwise null.</returns>
        public User_Model AuthLoginDetails(Auth_Model authInfo)
        {
            return _authDAL.AuthUser(authInfo);
        }
    }
}
#endregion