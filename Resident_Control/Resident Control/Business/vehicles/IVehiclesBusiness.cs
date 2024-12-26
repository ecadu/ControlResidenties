using Resident_Control.Model.DTO;
using Resident_Control.Model.Loja1;

namespace Resident_Control.Business.vehicles
{
    public interface IVehiclesBusiness
    {

        List<Model.Loja1.vehicles> GetVehicles();


        public bool AssignVehicleToUser(AssignVehicleToUser assignVehicleToUser);

        bool RemoveUserVehicle(ResidentiesVehicles residentiesVehicles);
    }
}
