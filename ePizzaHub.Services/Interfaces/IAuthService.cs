using ePizzaHub.Core.Database.Entities;
using ePizzaHub.Models;

namespace ePizzaHub.Services.Interfaces
{
    public interface IAuthService : IService<User>
    {
        bool CreateUser(User user, string role);
        UserModel? ValidateUser(string email, string password);
    }
}
