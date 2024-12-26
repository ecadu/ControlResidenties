using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Resident_Control.Model.DTO;
using Resident_Control.Model.Loja1;
using Resident_Control.Repository.Users;
using Resident_Control.Repository.Vehicles;

namespace Resident_Control.Business.vehicles
{
    public class VehiclesBusiness: IVehiclesBusiness
    {

        private readonly IVehiclesRepository  _vehiclesRepository;

        public VehiclesBusiness(IVehiclesRepository vehiclesRepository)
        {
            _vehiclesRepository = vehiclesRepository;
        }


        public List<Model.Loja1.vehicles> GetVehicles()
        {

            List<Model.Loja1.vehicles> listVehicles = _vehiclesRepository.GetVehicles().ToList();
            return listVehicles;
        }


        public bool AssignVehicleToUser(AssignVehicleToUser assignVehicleToUser)
        {
            var vehicleUser = new Model.Loja1.vehicles()
            {
                AutoMarkersId = assignVehicleToUser.AutoMarkersId,
                Color = assignVehicleToUser.Color,
                Name = assignVehicleToUser.Name,
                Price = assignVehicleToUser.Price,
                Year = assignVehicleToUser.Year,
                Plate = assignVehicleToUser.Plate,  
            };
            int newVehicleId = _vehiclesRepository.CreateVehicle(vehicleUser);
            if (newVehicleId != 0)
            {
                var ResidentiesVehicles = new ResidentiesVehicles()
                {
                    ResidentieId = assignVehicleToUser.ResidentieId,
                    VehiclesId = newVehicleId
                };
                return _vehiclesRepository.CreateUserVehicle(ResidentiesVehicles);

            } else 
            {
                return false;
            }

        }

        public bool RemoveUserVehicle(ResidentiesVehicles residentiesVehicles)
        {
            var getVechicleById = _vehiclesRepository.GetVehiclesById(residentiesVehicles.VehiclesId);
            if(getVechicleById != null ) return false;
            _vehiclesRepository.RemoveUserVehicle(residentiesVehicles);
            return _vehiclesRepository.RemoveVehicle(getVechicleById);
        }
    }
}
