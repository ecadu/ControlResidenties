using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Resident_Control.Model.Users;
using Resident_Control.Repository.Users;

namespace Resident_Control.Business.Users
{
    public class UsersBusiness : IUsersBusiness
    {
        private readonly IUsersRepository _usersRepository;

        public UsersBusiness(IUsersRepository usersRepository)
        {
            _usersRepository=usersRepository;
        }

        public dynamic GetAllUsers()
        {
            return _usersRepository.GetAllUsers();
        }

        public Model.Users.Users VerificationLoguin(string userLoguin, string userPassword)
        {

            return _usersRepository.VerificationLoguin(userLoguin, userPassword);
            
        }
    }
}
