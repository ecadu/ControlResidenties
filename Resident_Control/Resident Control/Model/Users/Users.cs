using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Resident_Control.Model.Users
{
    public class Users
    {
        public int  Id { get; set; }
        public string UserLoguin { get; set; }

        public string UserPassword { get; set; }
    }
}
