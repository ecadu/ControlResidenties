using Resident_Control.Data.Entities;
using Resident_Control.Model.Users;

namespace Resident_Control.Repository.Users
{
    public interface  IUsersRepository
    {
        dynamic GetAllUsers();

        Model.Users.Users VerificationLoguin(string UserLoguin, string UserPassword);

        
    }
}
