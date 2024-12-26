using Resident_Control.Data.Context;
using Resident_Control.Model.Loja1;

namespace Resident_Control.Repository.Vehicles
{
    public class VehiclesReporitory :IVehiclesRepository
    {


        private readonly MSSQLContext _context;

        public VehiclesReporitory(MSSQLContext context)
        {
            _context = context;
        }




        public List<Model.Loja1.vehicles> GetVehicles( ) 
        {
            List< Model.Loja1.vehicles >vehiclesList = _context.vehicles.ToList();
            return vehiclesList;
        }

        public Model.Loja1.vehicles GetVehiclesById(int id)
        {
            return _context.vehicles.FirstOrDefault(v => v.Id == id);
            
        }


        public int CreateVehicle(Model.Loja1.vehicles vehicles)
        {
            try
            {
                _context.vehicles.Add(vehicles);
                _context.SaveChanges();
                return vehicles.Id;
            }
            catch (Exception ex) 
            {
                return 0;
            }
;
        }

        public bool CreateUserVehicle(ResidentiesVehicles residentiesVehicles)
        {
            _context.ResidentiesVehicles.Add(residentiesVehicles);
            var rowsAfftecd = _context.SaveChanges();
            return rowsAfftecd > 0;
        }

        public bool RemoveUserVehicle(ResidentiesVehicles residentiesVehicles)
        {
            _context.ResidentiesVehicles.Remove(residentiesVehicles);
            var rowsAfftecd = _context.SaveChanges();
            return rowsAfftecd > 0;
        }

        public bool RemoveVehicle(vehicles vehicles)
        {
            _context.vehicles.Remove(vehicles);
            var rowsAfftecd = _context.SaveChanges();
            return rowsAfftecd > 0;
        }




    }
}
