using Resident_Control.Model.Loja1;

namespace Resident_Control.Repository.Vehicles
{
    public interface IVehiclesRepository
    {

        List<Model.Loja1.vehicles> GetVehicles();

        public int CreateVehicle(Model.Loja1.vehicles vehicles);
        public bool CreateUserVehicle(ResidentiesVehicles residentiesVehicles);


        public bool RemoveUserVehicle(ResidentiesVehicles residentiesVehicles);

        public bool RemoveVehicle(vehicles vehicles);


        public Model.Loja1.vehicles GetVehiclesById(int id);

    }
}
