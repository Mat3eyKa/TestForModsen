using TestForModsen.Models;

namespace TestForModsen.Data.Auth
{
    public interface IUserService
    {
        bool IsValidUserInformation(LoginModel model);
    }
}
