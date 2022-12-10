using Microsoft.CodeAnalysis.CSharp.Syntax;
using TestForModsen.Interfaces;
using TestForModsen.Models;

namespace TestForModsen.Data.Auth
{
    public class UserService : IUserService
    {
        public bool IsValidUserInformation(LoginModel model)=>
            model.UserName.Equals("Jay") && model.Password.Equals("123456");
    }
}
