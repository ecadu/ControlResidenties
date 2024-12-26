using System.ComponentModel.DataAnnotations;

namespace Resident_Control.Data.Entities
{
    public class Users
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserLogin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int typeID { get; set; }
    }
}
