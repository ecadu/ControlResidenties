using Resident_Control.Model.Users;

namespace Resident_Control.Business.Users
{
    public interface IUsersBusiness
    {
        dynamic GetAllUsers();

        public Model.Users.Users VerificationLoguin(string userLoguin, string userPassword);
    }

    
}
