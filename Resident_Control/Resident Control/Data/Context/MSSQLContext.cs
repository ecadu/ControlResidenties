using Microsoft.EntityFrameworkCore;
using Resident_Control.Data.Entities;
using Resident_Control.Model.Loja1;
using Resident_Control.Model.Residenties;

namespace Resident_Control.Data.Context
{
    public class MSSQLContext : DbContext
    {
        public MSSQLContext()
        {

        }


        public MSSQLContext(DbContextOptions<MSSQLContext> options) : base(options)
        {

        }

        public DbSet<Model.Users.Users> Users { get; set; }

        public DbSet<Residenties> Residenties { get; set; }


        public DbSet<vehicles> vehicles { get; set; }
        public DbSet<ResidentiesVehicles> ResidentiesVehicles { get; set; }

        public DbSet<Automakers> Automakers { get; set; }   

    }
}
