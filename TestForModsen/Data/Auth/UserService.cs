using TestForModsen.Models;

namespace TestForModsen.Data.Auth
{
    public class UserService : IUserService
    {
        public bool IsValidUserInformation(LoginModel model)
        {
            if (model.UserName.Equals("Jay") && model.Password.Equals("123456")) 
                return true;
            else 
                return false;
        }
    }
}
