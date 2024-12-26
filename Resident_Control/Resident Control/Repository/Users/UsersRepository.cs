using Resident_Control.Data.Context;
using Resident_Control.Model.Users;

namespace Resident_Control.Repository.Users
{
    public class UsersRepository : IUsersRepository
    {
        private readonly MSSQLContext _context;

        public UsersRepository(MSSQLContext context)
        {
            _context=context;
        }

        public dynamic GetAllUsers()
        {
            return _context.Users.ToList();
            
        }

 
        public Model.Users.Users VerificationLoguin(string UserLoguin, string UserPassword)
        {
            return _context.Users.FirstOrDefault(u => u.UserLoguin == UserLoguin && u.UserPassword == UserPassword);
        }
    }
}
