using TestForModsen.Models;

namespace TestForModsen.Interfaces
{
    public interface IUserService
    {
        bool IsValidUserInformation(LoginModel model);
    }
}
